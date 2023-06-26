using System.Drawing.Drawing2D;

namespace Library_Management_System
{
    public partial class ForgotPassword : Form
    {
        Login loginFrom;
        public ForgotPassword(Login login)
        {
            InitializeComponent();
            RoundFormCorners(30);
            loginFrom = login;
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
            loginFrom.Show();
            Close();
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
    }
}
