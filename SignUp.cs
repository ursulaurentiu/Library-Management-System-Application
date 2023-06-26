using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class SignUp : Form
    {
        Login loginForm;
        public SignUp(Login login)
        {
            InitializeComponent();
            RoundFormCorners(30);
            loginForm = login;
        }
        private void RoundFormCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            Region = new Region(path);
        }

        private void pictureBoxExit_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxExit.Image = Properties.Resources.icons8_no_64;
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxExit.Image = Properties.Resources.icons8_exit_64;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }

        private void textBoxFirstName_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "Your First Name")
            {
                textBoxFirstName.Text = string.Empty;
            }
        }

        private void textBoxFirstName_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxFirstName.Text == string.Empty)
            {
                textBoxFirstName.Text = "Your First Name";
            }
        }

        private void textBoxShortName_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "Your Last Name")
            {
                textBoxLastName.Text = string.Empty;
            }
        }

        private void textBoxShortName_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxLastName.Text == string.Empty)
            {
                textBoxLastName.Text = "Your Last Name";
            }
        }
        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Type your password")
            {
                textBoxPassword.Text = string.Empty;
            }
        }

        private void textBoxPassword_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxPassword.Text == string.Empty)
            {
                textBoxPassword.Text = "Type your password";
            }
        }

        private void textBoxMail_Click(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "Type your email")
            {
                textBoxMail.Text = string.Empty;
            }
        }

        private void textBoxMail_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxMail.Text == string.Empty)
            {
                textBoxMail.Text = "Type your email";
            }
        }

        private void textBoxConfirmPassword_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmPassword.Text == "Confirm your password")
            {
                textBoxConfirmPassword.Text = string.Empty;
            }
        }

        private void textBoxConfirmPassword_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxConfirmPassword.Text == string.Empty)
            {
                textBoxConfirmPassword.Text = "Confirm your password";
            }
        }
        private void pictureBoxVisiblePassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == false)
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxConfirmPassword.UseSystemPasswordChar = true;
                pictureBoxVisiblePassword.Image = Properties.Resources.icons8_eye_64;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxConfirmPassword.UseSystemPasswordChar= false;
                pictureBoxVisiblePassword.Image = Properties.Resources.icons8_invisible_64;
            }
        }

        private void textBoxPhoneNumber_Click(object sender, EventArgs e)
        {

            if (textBoxPhoneNumber.Text == "Type your phone number")
            {
                textBoxPhoneNumber.Text = string.Empty;
            }
        }

        private void textBoxPhoneNumber_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxPhoneNumber.Text == string.Empty)
            {
                textBoxPhoneNumber.Text = "Type your phone number";
            }
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "Type your user")
            {
                textBoxUser.Text = string.Empty;
            }
        }

        private void textBoxUser_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxUser.Text == string.Empty)
            {
                textBoxUser.Text = "Type your user";
            }
        }

        private void textBoxAdress_Click(object sender, EventArgs e)
        {
            if (textBoxAdress.Text == "Type your adress")
            {
                textBoxAdress.Text = string.Empty;
            }
        }
        private void textBoxAdress_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxAdress.Text == string.Empty)
            {
                textBoxAdress.Text = "Type your adress";
            }
        }

        private void textBoxCity_Click(object sender, EventArgs e)
        {
            if (textBoxCity.Text == "Type your city")
            {
                textBoxCity.Text = string.Empty;
            }
        }

        private void textBoxCity_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxCity.Text == string.Empty)
            {
                textBoxCity.Text = "Type your city";
            }
        }

        private void textBoxZipCode_Click(object sender, EventArgs e)
        {
            if (textBoxZipCode.Text == "Type your zip code")
            {
                textBoxZipCode.Text = string.Empty;
            }
        }

        private void textBoxZipCode_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxZipCode.Text == string.Empty)
            {
                textBoxZipCode.Text = "Type your zip code";
            }
        }

        private void textBoxMailConfirmation_Click(object sender, EventArgs e)
        {
            if (textBoxMailConfirmation.Text == "Confirm your email")
            {
                textBoxMailConfirmation.Text = string.Empty;
            }
        }

        private void textBoxMailConfirmation_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxMailConfirmation.Text == string.Empty)
            {
                textBoxMailConfirmation.Text = "Confirm your email";
            }
        }
    }
}
