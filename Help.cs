using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face_Detection_Security_System
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("If you are a new user and not registered with us then follow the following steps-\n");
            richTextBox1.AppendText("1. click on add new face.\n2. add id and name for the person whose facial data will be stored.\n");
            richTextBox1.AppendText("3. look straight into your laptop camera,you may try different expressions for better recognition.\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("If you are a registered user then follow the following steps-\n");
            richTextBox1.AppendText("1. click on detect.\n2. look straight into your laptop camera\n");
            richTextBox1.AppendText("3. you may see the match percentage or if the lighting id not proper,it may show 'unkown'.\n");
        }
    }
}
