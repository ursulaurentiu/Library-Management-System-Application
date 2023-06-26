using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        private Home homeForm;

        public Login(Home home)
        {
            InitializeComponent();
            RoundFormCorners(30);
            homeForm = home;
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
            pictureBoxExit.Image = Properties.Resources.icons8_no_64;
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.Image = Properties.Resources.icons8_exit_64;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            homeForm.Enabled = true;
            Close();
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Type your username")
            {
                textBoxUsername.Text = string.Empty;
            }
        }

        private void textBoxUsername_LostFocus(object sednder, EventArgs e)
        {
            if (textBoxUsername.Text == string.Empty)
            {
                textBoxUsername.Text = "Type your username";
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

        private void pictureBoxVisiblePassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == false)
            {
                textBoxPassword.UseSystemPasswordChar = true;
                pictureBoxVisiblePassword.Image = Properties.Resources.icons8_eye_64;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
                pictureBoxVisiblePassword.Image = Properties.Resources.icons8_invisible_64;
            }
        }

        private void lableForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword(this);
            forgotPassword.Show();
            Hide();
        }

        private void labelSingUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(this);
            signUp.Show();
            Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-L30S7MD; Initial Catalog = LMS; Integrated Security = true";
            string userName = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            string query = $"SELECT COUNT(*) FROM tbl_USERDATA WHERE USERACCOUNT = '{userName}' AND PASSWORD = '{password}'";

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            int numarUtilizatori = (int)command.ExecuteScalar();

            if (numarUtilizatori == 1)
            {
                query = $"SELECT COUNT(*) FROM tbl_USERDATA WHERE USERACCOUNT = '{userName}' AND ADMIN = '1'";
                command = new SqlCommand(query, connection);
                int isAdmin = (int)command.ExecuteScalar();
                if(isAdmin == 1)
                {
                    homeForm.HideUserMenu();
                    homeForm.GetUserId(userName);
                    Hide();
                    homeForm.GetAdminMenu();
                    homeForm.Enabled = true;
                    homeForm.LoginAnimation(8, "Welcome!");
                    Close();
                }
                else
                {
                    homeForm.HideAdminMenu();
                    homeForm.GetUserId(userName);
                    Hide();
                    homeForm.GetUserMenu();
                    homeForm.Enabled = true;
                    homeForm.LoginAnimation(8, "Welcome!");
                    Close();
                }

            }
            else
            {
                MessageBox.Show(this, "Incorrect username or password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connection.Close();
        }
    }
}
