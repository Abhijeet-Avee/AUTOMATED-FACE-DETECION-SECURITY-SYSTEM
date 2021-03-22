using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace Face_Detection_Security_System
{
    public partial class Register : Form
    {
        #region Variables
        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        readonly Mat frame = new Mat();
        readonly CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        String name;
        String file;
        String uid;
        static int countFaceAdded;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabels = new List<int>();
        FaceRecognizer model;
        int i = 0;
        #endregion
        public Register()
        {
            InitializeComponent();
            captureLabel.Hide();
            captureProgress.Hide();
            trainLabel.Hide();
            trainProgress.Hide();
            picCapture.InitialImage = Properties.Resources.download;    //using pic from resources
            picCapture.Image = picCapture.InitialImage;         //initailzing picture box on load
            picCapture.SizeMode = PictureBoxSizeMode.StretchImage;  //stretching pic to fit the window
        }
         
        private void btnAddFace_Click(object sender, EventArgs e)
        {
            //Take input name from user using a prompt box
            uid = Interaction.InputBox("Enter Unique Identification (UID): ","UNIQUE IDENTIFICATION","***");
            name = Interaction.InputBox("Enter Person Name: ", "INPUT NAME", "Type Here");

            //create a persondetails folder to store list of added face names
            file = Directory.GetCurrentDirectory()+@"\PersonDetails";
            if (!Directory.Exists(file))
                Directory.CreateDirectory(file);
            String filepath = Path.Combine(file, "UID.txt");

            //storing the record of number of faces added in database to use as a label
            String facepath = Path.Combine(file, "FaceCount.txt");
            if (!File.Exists(filepath))
            {
                // FileStream fs = File.Create(filepath);
                using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.ReadWrite))
                {
                    fs.Dispose();
                }
            }
            if (!File.Exists(facepath)) 
            {
                //FileStream fp = File.Create(facepath);
                using (FileStream fs = new FileStream(facepath, FileMode.Create, FileAccess.ReadWrite))
                {
                    fs.Dispose();
                }
            }
            using (BinaryReader reader = new BinaryReader(File.Open(facepath, FileMode.Open)))
            {
                try
                {
                    countFaceAdded = reader.ReadInt32();
                }
                catch (Exception)
                {
                    countFaceAdded = -1;
                }
            }
            string[] uids = File.ReadAllLines(filepath);
            if (uids.Contains(uid))
               MessageBox.Show("UID Already Exists");
            else
            {
                if (countFaceAdded == -1)
                {
                    countFaceAdded = 0;
                }
                countFaceAdded++;
                using (BinaryWriter writer = new BinaryWriter(File.Open(facepath, FileMode.Truncate)))
                {
                    writer.Write(countFaceAdded);
                }
                using (StreamWriter writer = new StreamWriter(filepath,true))
                {
                     writer.WriteLine(uid);
                }
               if (videoCapture != null) videoCapture.Dispose();
               videoCapture = new Capture();
               captureLabel.Show();
               captureProgress.Show();
               Application.Idle += ProcessFrame;
            }
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            int count = 0;
            bool status = false;
            //Capture Video
            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {
                status = false;
                videoCapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);
                //Detect Faces
                //Convert Bgr to Gray Image
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                //Enhance the image for better result
                CvInvoke.EqualizeHist(grayImage, grayImage);
                //Create Directory if does not exist
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages\" + uid;
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                string[] countfiles = Directory.GetFiles(path);

                Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                //If faces Detected
                if (faces.Length>0)
                {
                    //Project Square around Detected Face
                    foreach (var face in faces)
                    {
                        CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                        //Add Person 
                        Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                        resultImage.ROI = face;
                        Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                        CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                        captureBox.Image = grayFaceResult.Bitmap;
                        //Save Images to train with a delay of ms
                                //resize the image then saving it
                                resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + name.ToString()+ "_"+ uid.ToString() + "_" + (i++).ToString() + ".jpg");
                        Thread.Sleep(100);
                        foreach (string file in countfiles)
                        {
                            if (file.Contains(name))
                            {
                                count++;
                            }
                            if (count == 100)
                            {
                                MessageBox.Show("Records Succesfully Added");
                                videoCapture.Dispose();
                                status = true;
                                captureLabel.Hide();
                                captureProgress.Hide();
                                break;
                            }                                
                        }
                    }
                }
               // else MessageBox.Show("Multiple Faces Detected");
                //Render the Video Capture into the Picture Box picCapture
                picCapture.Image = currentFrame.Bitmap;
                if (status)
                {
                    //videoCapture.Dispose();
                    return;
                }
            }
            //Dispose the Current Frame after processing it to reduce the memory consumption.
            if (currentFrame != null)
                currentFrame.Dispose();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            trainLabel.Show();
            trainProgress.Show();
            picCapture.Image = Properties.Resources.download;
            MessageBox.Show("Face successfully added");
            eigenFaceTrainer();
            this.Close();
        }
        private void fetchFromDirectory()
        {
            TrainedFaces.Clear();
            PersonsLabels.Clear();
            string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
            string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                int label = Convert.ToInt32(file.Split('\\').Last().Split('_')[1]);
                PersonsLabels.Add(label);
                Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                CvInvoke.EqualizeHist(trainedImage, trainedImage);
                TrainedFaces.Add(trainedImage);
            }
        }
        public void eigenFaceTrainer() 
        {
            fetchFromDirectory();
            Debug.WriteLine("Size of images is: " + TrainedFaces.Count());
            Debug.WriteLine("Size of labels is: "+ PersonsLabels.Count());
            foreach (var name in PersonsLabels)
            {
                Debug.Write(" " + name);
            }
            if (TrainedFaces.Count() > 0)
            {
                file = Directory.GetCurrentDirectory() + @"\PersonDetails";
                model = new LBPHFaceRecognizer(1,8,8,8,1500);
                model.Train(TrainedFaces.ToArray(),PersonsLabels.ToArray());
                String path = Path.Combine(file, "trainset.yml");
                model.Save(path);  // Save trained data in yml file
                MessageBox.Show("Training Faces Completed..");
                trainProgress.Hide();
                trainLabel.Hide();
            }
        }
    }
}
