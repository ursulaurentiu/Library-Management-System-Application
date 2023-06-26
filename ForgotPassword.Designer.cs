namespace Library_Management_System
{
    partial class ForgotPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelYourPassword = new System.Windows.Forms.Label();
            this.labelForgot = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonForgotPassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelYourPassword);
            this.panel1.Controls.Add(this.labelForgot);
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 137);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Not to worry, we got you!";
            // 
            // labelYourPassword
            // 
            this.labelYourPassword.AutoSize = true;
            this.labelYourPassword.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelYourPassword.Location = new System.Drawing.Point(40, 62);
            this.labelYourPassword.Name = "labelYourPassword";
            this.labelYourPassword.Size = new System.Drawing.Size(238, 32);
            this.labelYourPassword.TabIndex = 6;
            this.labelYourPassword.Text = "YOUR PASSWORD?";
            // 
            // labelForgot
            // 
            this.labelForgot.AutoSize = true;
            this.labelForgot.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForgot.Location = new System.Drawing.Point(102, 30);
            this.labelForgot.Name = "labelForgot";
            this.labelForgot.Size = new System.Drawing.Size(111, 32);
            this.labelForgot.TabIndex = 5;
            this.labelForgot.Text = "FORGOT";
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = global::Library_Management_System.Properties.Resources.icons8_exit_64;
            this.pictureBoxExit.InitialImage = null;
            this.pictureBoxExit.Location = new System.Drawing.Point(280, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 1;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            this.pictureBoxExit.MouseEnter += new System.EventHandler(this.pictureBoxExit_MouseEnter);
            this.pictureBoxExit.MouseLeave += new System.EventHandler(this.pictureBoxExit_MouseLeave);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.SystemColors.Window;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMail.Location = new System.Drawing.Point(12, 161);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(56, 25);
            this.labelMail.TabIndex = 2;
            this.labelMail.Text = "Email";
            // 
            // textBoxMail
            // 
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxMail.Location = new System.Drawing.Point(71, 204);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(218, 24);
            this.textBoxMail.TabIndex = 3;
            this.textBoxMail.Text = "Type your email";
            this.textBoxMail.Click += new System.EventHandler(this.textBoxMail_Click);
            this.textBoxMail.LostFocus += new System.EventHandler(this.textBoxMail_LostFocus);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.icons8_gmail_logo_64;
            this.pictureBox1.Location = new System.Drawing.Point(21, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonForgotPassword
            // 
            this.buttonForgotPassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonForgotPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonForgotPassword.Location = new System.Drawing.Point(57, 268);
            this.buttonForgotPassword.Name = "buttonForgotPassword";
            this.buttonForgotPassword.Size = new System.Drawing.Size(190, 34);
            this.buttonForgotPassword.TabIndex = 5;
            this.buttonForgotPassword.Text = "Submit";
            this.buttonForgotPassword.UseVisualStyleBackColor = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(314, 314);
            this.ControlBox = false;
            this.Controls.Add(this.buttonForgotPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextBoxMail_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label labelForgot;
        private PictureBox pictureBoxExit;
        private Label labelMail;
        private Label label1;
        private Label labelYourPassword;
        private TextBox textBoxMail;
        private PictureBox pictureBox1;
        private Button buttonForgotPassword;
    }
}