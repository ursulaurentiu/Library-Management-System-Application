using System.Drawing.Drawing2D;

namespace Library_Management_System
{
    public partial class LogOut : Form
    {
        private Home homeForm;

        public LogOut(Home home)
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

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            homeForm.Enabled = true;
            Close();
        }

        private void pictureBoxExit_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxExit.Image = Properties.Resources.icons8_no_64;
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.Image = Properties.Resources.icons8_exit_64;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            homeForm.Enabled = true;
            Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Close();
            homeForm.HideMenus();
            homeForm.Enabled = true;
            homeForm.BringToFront();
            homeForm.LogOutAnimation(8, "Login");
            homeForm.ShowHomeMenu();
        }
    }
}
