using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media.Imaging;

namespace Face_Detection_Security_System
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }
        private void populateItems(List<string> path,List<string> uid) 
        {
            string lname;
            int count = uid.Count;
            //Populate list here
            MyList[] list = new MyList[count];
            //loop through each item
            //Add to flowLayout
            if (flowLayoutPanel1.Controls.Count > 0)
                flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                var file = path[i];
                lname = file.Split('\\').Last().Split('_')[0];
               // uisng below block to ensure that image resource is released after loading into icon
               //so that it does not gives IOException of image resource being used by another process
                using (FileStream stream = new FileStream(path[i], FileMode.Open, FileAccess.Read))
                {
                    list[i] = new MyList();
                    list[i].Width = flowLayoutPanel1.Width;
                    list[i].Icon = Image.FromStream(stream);
                    list[i].IconBackground = Color.Silver;
                    list[i].Title = lname;
                    list[i].Message = "USER ID: " + uid[i];
                    flowLayoutPanel1.Controls.Add(list[i]);
                    stream.Dispose();
                }
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            List<string> pathList = new List<string>();
            List<string> uid = new List<string>();
            string filepath = Directory.GetCurrentDirectory() + @"\PersonDetails\UID.txt";
            string[] uids = File.ReadAllLines(filepath);
            for (int i = 0; i < uids.Length; i++)
            {
                uid.Add(uids[i]);
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages\"+uids[i];
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
                pathList.Add(files[0]);
            }
            populateItems(pathList, uid);
        }
        public void delete(string uid)
        {
            string path = Directory.GetCurrentDirectory() + @"\TrainedImages\" + uid;
            DirectoryInfo directory = new DirectoryInfo(path);
            foreach (FileInfo file in directory.EnumerateFiles())
            {
                file.Delete();
            }
            directory.Delete();
            string filepath = Directory.GetCurrentDirectory() + @"\PersonDetails\UID.txt";
            List<string> id = new List<string>(File.ReadAllLines(filepath));
            if (id.Contains(uid))
                id.Remove(uid);
            using (StreamWriter writer = new StreamWriter(filepath, false))
            {
                for (int i = 0; i < id.Count; i++)
                    writer.WriteLine(id[i]);
            }
        }
        public void update_Query(string uid)
        {
            delete(uid);
            Register reg = new Register();
            reg.Show();
        }
        public void delete_Query(string uid)
        {
            delete(uid);
            Register reg = new Register();
            string filepath = Directory.GetCurrentDirectory() + @"\PersonDetails\UID.txt";
            List<string> id = new List<string>(File.ReadAllLines(filepath));
            if (id.Count > 0)
            {
                reg.eigenFaceTrainer();
            }
            else
            {
                string path = Directory.GetCurrentDirectory() + @"\PersonDetails\trainset.yml";
                File.Delete(path);
            }
            MessageBox.Show("Record Successfully Deleted");
            viewBtn.PerformClick();
        }

        private void resetDbBtn_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\PersonDetails\trainset.yml";
            File.Delete(path);
            path = Directory.GetCurrentDirectory() + @"\TrainedImages";
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo file in dir.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo directory in dir.GetDirectories())
            {
                directory.Delete(true);
            }
            string filepath = Directory.GetCurrentDirectory() + @"\PersonDetails\UID.txt";
            File.Delete(filepath);
            using (FileStream fs = new FileStream(filepath,FileMode.Create,FileAccess.ReadWrite))
            {
                fs.Dispose();
            }
            MessageBox.Show("All Databases are cleared!!");
        }
    }
}
