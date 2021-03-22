namespace Face_Detection_Security_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.abtUsBtn = new FontAwesome.Sharp.IconButton();
            this.dbBtn = new FontAwesome.Sharp.IconButton();
            this.survellianceBtn = new FontAwesome.Sharp.IconButton();
            this.registerBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.clockBar = new CircularProgressBar.CircularProgressBar();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.helpBtn = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.helpBtn);
            this.panelMenu.Controls.Add(this.abtUsBtn);
            this.panelMenu.Controls.Add(this.dbBtn);
            this.panelMenu.Controls.Add(this.survellianceBtn);
            this.panelMenu.Controls.Add(this.registerBtn);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 537);
            this.panelMenu.TabIndex = 0;
            // 
            // abtUsBtn
            // 
            this.abtUsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtUsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.abtUsBtn.FlatAppearance.BorderSize = 0;
            this.abtUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtUsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.abtUsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.abtUsBtn.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.abtUsBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.abtUsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.abtUsBtn.IconSize = 32;
            this.abtUsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abtUsBtn.Location = new System.Drawing.Point(0, 280);
            this.abtUsBtn.Name = "abtUsBtn";
            this.abtUsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.abtUsBtn.Rotation = 0D;
            this.abtUsBtn.Size = new System.Drawing.Size(220, 60);
            this.abtUsBtn.TabIndex = 4;
            this.abtUsBtn.Text = "About Us";
            this.abtUsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abtUsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.abtUsBtn.UseVisualStyleBackColor = true;
            this.abtUsBtn.Click += new System.EventHandler(this.abtUsBtn_Click);
            // 
            // dbBtn
            // 
            this.dbBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dbBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbBtn.FlatAppearance.BorderSize = 0;
            this.dbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.dbBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.dbBtn.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.dbBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.dbBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dbBtn.IconSize = 32;
            this.dbBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dbBtn.Location = new System.Drawing.Point(0, 220);
            this.dbBtn.Name = "dbBtn";
            this.dbBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.dbBtn.Rotation = 0D;
            this.dbBtn.Size = new System.Drawing.Size(220, 60);
            this.dbBtn.TabIndex = 3;
            this.dbBtn.Text = "View Database";
            this.dbBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dbBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dbBtn.UseVisualStyleBackColor = true;
            this.dbBtn.Click += new System.EventHandler(this.dbBtn_Click);
            // 
            // survellianceBtn
            // 
            this.survellianceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.survellianceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.survellianceBtn.FlatAppearance.BorderSize = 0;
            this.survellianceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.survellianceBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.survellianceBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.survellianceBtn.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.survellianceBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.survellianceBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.survellianceBtn.IconSize = 32;
            this.survellianceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.survellianceBtn.Location = new System.Drawing.Point(0, 160);
            this.survellianceBtn.Name = "survellianceBtn";
            this.survellianceBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.survellianceBtn.Rotation = 0D;
            this.survellianceBtn.Size = new System.Drawing.Size(220, 60);
            this.survellianceBtn.TabIndex = 2;
            this.survellianceBtn.Text = "Survelliance";
            this.survellianceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.survellianceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.survellianceBtn.UseVisualStyleBackColor = true;
            this.survellianceBtn.Click += new System.EventHandler(this.survellianceBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.registerBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.registerBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.registerBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.registerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registerBtn.IconSize = 32;
            this.registerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerBtn.Location = new System.Drawing.Point(0, 100);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.registerBtn.Rotation = 0D;
            this.registerBtn.Size = new System.Drawing.Size(220, 60);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register Faces";
            this.registerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 100);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(580, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.MediumPurple;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(550, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(27, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximize.IconColor = System.Drawing.Color.MediumPurple;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(517, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Rotation = 0D;
            this.btnMaximize.Size = new System.Drawing.Size(27, 29);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.MediumPurple;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(493, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0D;
            this.btnMinimize.Size = new System.Drawing.Size(18, 19);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(61, 32);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(23, 22);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(580, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.clockBar);
            this.panelDesktop.Controls.Add(this.lblDate);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(580, 453);
            this.panelDesktop.TabIndex = 3;
            // 
            // clockBar
            // 
            this.clockBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clockBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("clockBar.AnimationFunction")));
            this.clockBar.AnimationSpeed = 500;
            this.clockBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.clockBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.clockBar.ForeColor = System.Drawing.Color.White;
            this.clockBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.clockBar.InnerMargin = 2;
            this.clockBar.InnerWidth = -1;
            this.clockBar.Location = new System.Drawing.Point(163, 76);
            this.clockBar.MarqueeAnimationSpeed = 500;
            this.clockBar.Name = "clockBar";
            this.clockBar.OuterColor = System.Drawing.Color.Gray;
            this.clockBar.OuterMargin = -25;
            this.clockBar.OuterWidth = 26;
            this.clockBar.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.clockBar.ProgressWidth = 25;
            this.clockBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clockBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clockBar.Size = new System.Drawing.Size(257, 253);
            this.clockBar.StartAngle = 270;
            this.clockBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.clockBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.clockBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.clockBar.SubscriptText = "00";
            this.clockBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.clockBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.clockBar.SuperscriptText = "";
            this.clockBar.TabIndex = 3;
            this.clockBar.Text = "00:00:00";
            this.clockBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.clockBar.Value = 68;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblDate.Location = new System.Drawing.Point(158, 345);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "DATE";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(118, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Automated Face Recognition Security System";
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // helpBtn
            // 
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.helpBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.helpBtn.IconChar = FontAwesome.Sharp.IconChar.Guilded;
            this.helpBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.helpBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.helpBtn.IconSize = 32;
            this.helpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.Location = new System.Drawing.Point(0, 340);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.helpBtn.Rotation = 0D;
            this.helpBtn.Size = new System.Drawing.Size(220, 60);
            this.helpBtn.TabIndex = 5;
            this.helpBtn.Text = "Help";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton registerBtn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton dbBtn;
        private FontAwesome.Sharp.IconButton survellianceBtn;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar clockBar;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label lblDate;
        private FontAwesome.Sharp.IconButton abtUsBtn;
        private FontAwesome.Sharp.IconButton helpBtn;
    }
}