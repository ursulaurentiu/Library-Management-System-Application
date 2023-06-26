namespace Library_Management_System
{
    partial class Login
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxUsername = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxVisiblePassword = new System.Windows.Forms.PictureBox();
            this.lableForgotPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelSingUp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisiblePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 150);
            this.panel1.TabIndex = 0;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(106, 50);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(108, 45);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Login";
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
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserName.Location = new System.Drawing.Point(30, 155);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(96, 25);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(30, 235);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(90, 25);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxUsername.Location = new System.Drawing.Point(70, 185);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(220, 24);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.Text = "Type your username";
            this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_Click);
            this.textBoxUsername.LostFocus += new System.EventHandler(this.textBoxUsername_LostFocus);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPassword.Location = new System.Drawing.Point(70, 265);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(175, 24);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "Type your password";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
            this.textBoxPassword.LostFocus += new System.EventHandler(this.textBoxPassword_LostFocus);
            // 
            // pictureBoxUsername
            // 
            this.pictureBoxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUsername.Image = global::Library_Management_System.Properties.Resources.icons8_user_64;
            this.pictureBoxUsername.Location = new System.Drawing.Point(25, 185);
            this.pictureBoxUsername.Name = "pictureBoxUsername";
            this.pictureBoxUsername.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsername.TabIndex = 5;
            this.pictureBoxUsername.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPassword.Image = global::Library_Management_System.Properties.Resources.icons8_password_64;
            this.pictureBoxPassword.Location = new System.Drawing.Point(25, 265);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 6;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxVisiblePassword
            // 
            this.pictureBoxVisiblePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxVisiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVisiblePassword.Image = global::Library_Management_System.Properties.Resources.icons8_eye_64;
            this.pictureBoxVisiblePassword.Location = new System.Drawing.Point(260, 265);
            this.pictureBoxVisiblePassword.Name = "pictureBoxVisiblePassword";
            this.pictureBoxVisiblePassword.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxVisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVisiblePassword.TabIndex = 7;
            this.pictureBoxVisiblePassword.TabStop = false;
            this.pictureBoxVisiblePassword.Click += new System.EventHandler(this.pictureBoxVisiblePassword_Click);
            // 
            // lableForgotPassword
            // 
            this.lableForgotPassword.AutoSize = true;
            this.lableForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lableForgotPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lableForgotPassword.Location = new System.Drawing.Point(130, 298);
            this.lableForgotPassword.Name = "lableForgotPassword";
            this.lableForgotPassword.Size = new System.Drawing.Size(160, 25);
            this.lableForgotPassword.TabIndex = 8;
            this.lableForgotPassword.Text = "Forgot password?";
            this.lableForgotPassword.Click += new System.EventHandler(this.lableForgotPassword_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLogin.Location = new System.Drawing.Point(106, 338);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(106, 33);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelSingUp
            // 
            this.labelSingUp.AutoSize = true;
            this.labelSingUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSingUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSingUp.Location = new System.Drawing.Point(118, 434);
            this.labelSingUp.Name = "labelSingUp";
            this.labelSingUp.Size = new System.Drawing.Size(78, 25);
            this.labelSingUp.TabIndex = 10;
            this.labelSingUp.Text = "Sing Up";
            this.labelSingUp.Click += new System.EventHandler(this.labelSingUp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(314, 474);
            this.ControlBox = false;
            this.Controls.Add(this.labelSingUp);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.lableForgotPassword);
            this.Controls.Add(this.pictureBoxVisiblePassword);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.pictureBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisiblePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxExit;
        private Label labelUserName;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private Label labelLogin;
        private TextBox textBoxPassword;
        private PictureBox pictureBoxUsername;
        private PictureBox pictureBoxPassword;
        private PictureBox pictureBoxVisiblePassword;
        private Label lableForgotPassword;
        private Button buttonLogin;
        private Label labelSingUp;
    }
}