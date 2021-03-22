namespace Face_Detection_Security_System
{
    partial class Register
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
            this.btnAddFace = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.captureLabel = new System.Windows.Forms.Label();
            this.captureProgress = new System.Windows.Forms.ProgressBar();
            this.trainLabel = new System.Windows.Forms.Label();
            this.trainProgress = new System.Windows.Forms.ProgressBar();
            this.captureBox = new System.Windows.Forms.PictureBox();
            this.picCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.captureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFace
            // 
            this.btnAddFace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFace.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFace.Location = new System.Drawing.Point(379, 12);
            this.btnAddFace.Name = "btnAddFace";
            this.btnAddFace.Size = new System.Drawing.Size(161, 32);
            this.btnAddFace.TabIndex = 0;
            this.btnAddFace.Text = "1. Add New Face";
            this.btnAddFace.UseVisualStyleBackColor = true;
            this.btnAddFace.Click += new System.EventHandler(this.btnAddFace_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(379, 85);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(161, 33);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "2. Start Training";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(384, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Captured Face";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // captureLabel
            // 
            this.captureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.captureLabel.AutoSize = true;
            this.captureLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.captureLabel.Location = new System.Drawing.Point(385, 47);
            this.captureLabel.Name = "captureLabel";
            this.captureLabel.Size = new System.Drawing.Size(155, 18);
            this.captureLabel.TabIndex = 6;
            this.captureLabel.Text = "Capturing Faces...";
            // 
            // captureProgress
            // 
            this.captureProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.captureProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.captureProgress.Location = new System.Drawing.Point(379, 68);
            this.captureProgress.MarqueeAnimationSpeed = 50;
            this.captureProgress.Name = "captureProgress";
            this.captureProgress.Size = new System.Drawing.Size(161, 11);
            this.captureProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.captureProgress.TabIndex = 7;
            // 
            // trainLabel
            // 
            this.trainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trainLabel.AutoSize = true;
            this.trainLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.trainLabel.Location = new System.Drawing.Point(388, 121);
            this.trainLabel.Name = "trainLabel";
            this.trainLabel.Size = new System.Drawing.Size(136, 18);
            this.trainLabel.TabIndex = 6;
            this.trainLabel.Text = "Training Faces..";
            // 
            // trainProgress
            // 
            this.trainProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trainProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.trainProgress.Location = new System.Drawing.Point(379, 142);
            this.trainProgress.MarqueeAnimationSpeed = 50;
            this.trainProgress.Name = "trainProgress";
            this.trainProgress.Size = new System.Drawing.Size(161, 11);
            this.trainProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.trainProgress.TabIndex = 7;
            // 
            // captureBox
            // 
            this.captureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.captureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.captureBox.Location = new System.Drawing.Point(379, 199);
            this.captureBox.Name = "captureBox";
            this.captureBox.Size = new System.Drawing.Size(173, 204);
            this.captureBox.TabIndex = 3;
            this.captureBox.TabStop = false;
            // 
            // picCapture
            // 
            this.picCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCapture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCapture.Location = new System.Drawing.Point(12, 12);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(344, 390);
            this.picCapture.TabIndex = 1;
            this.picCapture.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(564, 414);
            this.Controls.Add(this.trainProgress);
            this.Controls.Add(this.captureProgress);
            this.Controls.Add(this.trainLabel);
            this.Controls.Add(this.captureLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.captureBox);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.picCapture);
            this.Controls.Add(this.btnAddFace);
            this.Name = "Register";
            this.Text = "REGISTER FACES - AUTOMATED FACE RECOGNITION SECURITY SYSTEM";
            ((System.ComponentModel.ISupportInitialize)(this.captureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFace;
        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox captureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label captureLabel;
        private System.Windows.Forms.ProgressBar captureProgress;
        private System.Windows.Forms.Label trainLabel;
        private System.Windows.Forms.ProgressBar trainProgress;
    }
}