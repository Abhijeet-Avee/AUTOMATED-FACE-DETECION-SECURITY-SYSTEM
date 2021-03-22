using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;

namespace Face_Detection_Security_System
{
    public partial class Survelliance : Form
    {
        #region Variables
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        LBPHFaceRecognizer model1;
        //EigenFaceRecognizer model2;
        //FisherFaceRecognizer model3;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        #endregion
        public Survelliance()
        {
            InitializeComponent();
        }

        private void Survelliance_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                choDevice.Items.Add(device.Name);
            choDevice.SelectedIndex = 0;
            device = new VideoCaptureDevice();
        }
        private void btnDetect_Click_1(object sender, EventArgs e)
        {
            model1 = new LBPHFaceRecognizer(1, 8, 8, 8, 1500);
            // model2 = new EigenFaceRecognizer();
            // model3 = new FisherFaceRecognizer();
            string file = Directory.GetCurrentDirectory() + @"\PersonDetails\trainset.yml";
            if (!File.Exists(file))
            {
                MessageBox.Show("Trained Dataset is Empty. Please add some!!");
                Register obj1 = new Register();
                obj1.Show();
                this.Hide();
                this.SuspendLayout();
            }
            else
            {
                model1.Load(file);
                //model2.Load(file);
                //model3.Load(file);
                device = new VideoCaptureDevice(filter[choDevice.SelectedIndex].MonikerString);
                device.NewFrame += Device_NewFrame;
                device.Start();
            }
        }

        private void Device_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Image<Bgr, Byte> currentFrame = new Image<Bgr, byte>((Bitmap)eventArgs.Frame.Clone()).Resize(pic.Width, pic.Height, Inter.Cubic);
            Mat grayImage = new Mat();
            CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);

            //Enhance the image for better result
            CvInvoke.EqualizeHist(grayImage, grayImage);
            Rectangle[] faces = cascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

            // Create font and brush.
            Font drawFont = new Font("Arial", 14);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.NoClip;
            foreach (Rectangle face in faces)
            {
                CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                resultImage.ROI = face;
                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                FaceRecognizer.PredictionResult resultLBPH = model1.Predict(grayFaceResult);
                //FaceRecognizer.PredictionResult resultEigen = model2.Predict(grayFaceResult);
                //FaceRecognizer.PredictionResult resultFisher = model3.Predict(grayFaceResult);
                // Debug.WriteLine("Econfidence: " + resultEigen.Distance + " Label: " + resultEigen.Label + "\n");
                // Debug.WriteLine("Fconfidence: " + resultFisher.Distance + " Label: " + resultFisher.Label + "\n");
                Debug.WriteLine("Lconfidence: " + resultLBPH.Distance + " Label: " + resultLBPH.Label + "\n");
                int label = -1;
                /*if (resultFisher.Label != -1 && resultEigen.Label != -1)
                {
                        if (resultEigen.Label == resultFisher.Label)
                            label = resultEigen.Label;
                }
                else
                {
                    label = -1;
                }*/
                if (resultLBPH.Label != -1)
                {
                    label = resultLBPH.Label;
                }
                else label = -1;

                //converting labels into corresponding names
                string lname;
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages\" + label;
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
                var file = files[0];
                lname = file.Split('\\').Last().Split('_')[0];
                var conf = Convert.ToInt32(100 - (100 * resultLBPH.Distance) / 200);
                if (conf >= 76 && label != -1)
                {
                    CvInvoke.PutText(currentFrame, lname + "-" + conf + "%", new Point(face.X - 2, face.Y - 2),
                        FontFace.HersheyComplex, 0.8, new Bgr(Color.Orange).MCvScalar);
                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                }
                //here results did not found any know faces
                else
                {
                    CvInvoke.PutText(currentFrame, "Unknown", new Point(face.X - 2, face.Y - 2),
                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                }
            }
            pic.Image = currentFrame.Bitmap;
            //Dispose the Current Frame after processing it to reduce the memory consumption.
            if (currentFrame != null)
                currentFrame.Dispose();
        }
        private void Survelliance_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }
    }
}
