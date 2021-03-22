using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Face_Detection_Security_System.Properties;

namespace Face_Detection_Security_System
{
    public partial class MyList : UserControl
    {
        public MyList()
        {
            InitializeComponent();
            
        }
        #region Properties
        private string _title;
        private string _message;
        private Image _icon;
        private Color _iconBack;

        [Category("Custom Props")]
        public string Title
        {
            get => _title;
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custom Props")]
        public Color IconBackground
        {
            get => _iconBack;
            set { _iconBack = value; panel1.BackColor= value; }
        }

        [Category("Custom Props")]
        public string Message 
        { 
            get => _message;
            set{ _message = value; lblMessage.Text = value; }
        }
        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        #endregion

        private void MyList_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void MyList_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void updateFaceBtn_Click(object sender, EventArgs e)
        {
            string uid = Message.Split(' ').Last();
            Database db = new Database();
            db.update_Query(uid);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string uid = Message.Split(' ').Last();
            Database db = new Database();
            db.delete_Query(uid);
        }
    }
}
