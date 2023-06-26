using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using CheckBox = System.Windows.Forms.CheckBox;

namespace Library_Management_System
{
    public partial class Home : Form
    {
        private int userId;

        public Home()
        {
            InitializeComponent();
            RoundFormCorners(30);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //user
            panelBorrowedBookMenu.Hide();
            panelSearchBookMenu.Hide();
            panelUserMenu.Hide();
            panelUserSettingsMenu.Hide();

            //admin
            panelReturnBookMenuAdmin.Hide();
            panelRetunBookSearchUserMenu.Hide();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxLogin_MouseEnter(object sender, EventArgs e)
        {
            const int pixels = 20;
            pictureBoxLogin.Width = pictureBoxLogin.Width - pixels;
            pictureBoxLogin.Height = pictureBoxLogin.Height - pixels;

            Point pictureBoxLoginLocation = pictureBoxLogin.Location;
            pictureBoxLoginLocation.X += pixels / 2;
            pictureBoxLoginLocation.Y += pixels / 2;
            pictureBoxLogin.Location = pictureBoxLoginLocation;
        }

        private void pictureBoxLogin_MouseLeave(object sender, EventArgs e)
        {
            const int pixels = 20;
            pictureBoxLogin.Width = pictureBoxLogin.Width + pixels;
            pictureBoxLogin.Height = pictureBoxLogin.Height + pixels;

            Point pictureBoxLoginLocation = pictureBoxLogin.Location;
            pictureBoxLoginLocation.X -= pixels / 2;
            pictureBoxLoginLocation.Y -= pixels / 2;
            pictureBoxLogin.Location = pictureBoxLoginLocation;
        }

        private void pictureBoxExit_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxExit.Image = Properties.Resources.icons8_no_64;
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.Image = Properties.Resources.icons8_exit_64;
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            Enabled = false;
            Login login = new Login(this);
            login.Show();
        }

        private void labelLogin_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLogin_MouseEnter(sender, e);
        }
        private void labelLogin_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLogin_MouseLeave(sender, e);
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            pictureBoxLogin_Click(sender, e);
        }

        private void Slide(int pixelPoxition)
        {
            BringToFront();
            Point position = pictureBoxFirstHalfLibrary.Location;
            const int slidingSpeed = 20;
            while (pictureBoxFirstHalfLibrary.Location.X != pixelPoxition)
            {
                if (pixelPoxition < 0)
                {
                    position.X = pictureBoxFirstHalfLibrary.Location.X - slidingSpeed;
                    pictureBoxFirstHalfLibrary.Location = position;
                }
                else
                {
                    position.X = pictureBoxFirstHalfLibrary.Location.X + slidingSpeed;
                    pictureBoxFirstHalfLibrary.Location = position;
                }

                Refresh();
            }
        }

        private void ReduceLogo()
        {
            Point position = pictureBoxLogin.Location;
            const int pixels = 4;
            while (pictureBoxLogin.Size.Width != 0)
            {
                pictureBoxLogin.Width -= pixels;
                pictureBoxLogin.Height -= pixels;

                position.X += pixels / 2;
                position.Y += pixels / 2;
                pictureBoxLogin.Location = position;
                Refresh();
            }

            pictureBoxLogin.Hide();
        }

        private void IncreaseLogo()
        {
            pictureBoxLogin.Show();
            Point position = pictureBoxLogin.Location;
            const int pixels = 4;
            while (pictureBoxLogin.Size.Width != 68)
            {
                pictureBoxLogin.Width += pixels;
                pictureBoxLogin.Height += pixels;

                position.X -= pixels / 2;
                position.Y -= pixels / 2;
                pictureBoxLogin.Location = position;
                Refresh();
            }
        }

        private void AddText(string text)
        {
            foreach (char c in text)
            {
                labelLogin.Text += c;
                Refresh();
            }
        }

        private void RemoveText()
        {
            while (labelLogin.Text != string.Empty)
            {

                labelLogin.Text = labelLogin.Text[..0];
                Refresh();
            }
        }

        private void LocationChange(int number)
        {
            labelLogin.Location = new Point(labelLogin.Location.X, number);
        }

        public void GetUserId(string user)
        {
            string stringConnection = "Data Source = DESKTOP-L30S7MD; Initial Catalog = LMS; Integrated Security = true";
            SqlConnection connection = new SqlConnection(stringConnection);
            connection.Open();

            string query = $"SELECT USERID FROM tbl_USERDATA WHERE USERACCOUNT = '{user}'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                userId = Convert.ToInt32(reader["USERID"].ToString());
            }

            connection.Close();
        }

        public void LoginAnimation(int position, string text)
        {
            Slide(-pictureBoxFirstHalfLibrary.Size.Width);
            pictureBoxFirstHalfLibrary.Hide();
            labelLogin.Click -= labelLogin_Click;
            labelLogin.Cursor = Cursors.Default;
            ReduceLogo();
            RemoveText();
            LocationChange(position);
            AddText(text);
        }

        public void LogOutAnimation(int position, string text)
        {
            pictureBoxFirstHalfLibrary.Show();
            pictureBoxSecondHalfOfLibrary.BringToFront();
            Slide(0);
            labelLogin.Click += labelLogin_Click;
            labelLogin.Cursor = Cursors.Hand;
            RemoveText();
            LocationChange(position);
            AddText(text);
            IncreaseLogo();
        }

        public void GetUserMenu()
        {
            if (!panelUserMenu.Visible)
            {
                panelUserMenu.Show();
                panelUserMenu.SendToBack();
            }
        }

        public void HideUserMenu()
        {
            panelUserMenu.Hide();
        }

        private void panelBookSearch_Click(object sender, EventArgs e)
        {
            HideMenus();
            if (!panelSearchBookMenu.Visible)
            {
                comboBoxSearchBook.SelectedIndex = 0;
                DisplayData_SearchMenu("SELECT * FROM tbl_BOOKDATA"); // display all books
                panelSearchBookMenu.Show();
                panelSearchBookMenu.BringToFront();
                pictureBoxSecondHalfOfLibrary.Hide();
            }
        }

        private void panelBorrowedBooks_Click(object sender, EventArgs e)
        {
            HideMenus();
            if (!panelBorrowedBookMenu.Visible)
            {
                DisplayData_BorrowMenu();
                panelBorrowedBookMenu.Show();
                panelBorrowedBookMenu.BringToFront();
                pictureBoxSecondHalfOfLibrary.Hide();
            }
        }

        private void panelSettings_Click(object sender, EventArgs e)
        {
            HideMenus();
            if (!panelUserSettingsMenu.Visible)
            {
                panelUserSettingsMenu_LoadMenu();
                panelUserSettingsMenu.Show();
                panelUserSettingsMenu.BringToFront();
                pictureBoxSecondHalfOfLibrary.Hide();
            }
        }

        private void panelLogOut_Click(object sender, EventArgs e)
        {
            Enabled = false;
            LogOut logout = new LogOut(this);
            logout.Show();
        }

        public void ShowHomeMenu()
        {
            pictureBoxSecondHalfOfLibrary.Show();
        }

        public void HideMenus()
        {

            //user
            panelBorrowedBookMenu.Hide();
            panelUserSettingsMenu.Hide();
            panelSearchBookMenu.Hide();


            //Admin
            panelSearchBookMenu.Hide();
            panelRetunBookSearchUserMenu.Hide();
            panelReturnBookMenuAdmin.Hide();


        }

        private void DisplayData_SearchMenu(string query)
        {
            listViewSearchBook.Items.Clear();

            string connectionString = "Data Source = DESKTOP-L30S7MD; Initial Catalog = LMS; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            int index = 1;
            while (reader.Read())
            {
                string column1Value = reader["BOOKNAME"].ToString();
                string column2Value = reader["BOOKAUTHOR"].ToString();
                string column3Value = reader["BOOKPUBLICATION"].ToString();
                DateTime purchaseDate = (DateTime)reader["BOOKRELEASEDATE"];
                string column4Value = purchaseDate.ToShortDateString();
                string column5Value = reader["BOOKPRICE"].ToString();
                string column6Value = reader["BOOKQUANTITY"].ToString();
                string[] row = { Convert.ToString(index), column1Value, column2Value, column3Value, column4Value, column5Value + " $", column6Value };

                listViewSearchBook.Items.Add(new ListViewItem(row));
                index++;
            }

            ResizeBasedOnChecked();
            connection.Close();
        }

        private void ResizeBasedOnChecked()
        {
            if (checkBoxBookNameSearchBook.Checked)
            {
                AutoResizeColumn(listViewSearchBook, 1);
            }

            if (checkBoxBookAuthorSearchBook.Checked)
            {
                AutoResizeColumn(listViewSearchBook, 2);
            }

            if (checkBoxBookPublicationSearchBook.Checked)
            {
                AutoResizeColumn(listViewSearchBook, 3);
            }

            if (checkBoxBookReleaseSearchBook.Checked)
            {
                AutoResizeColumn(listViewSearchBook, 4);
            }

            if (checkBoxBookPriceSearchBook.Checked)
            {
                AutoResizeColumn(listViewSearchBook, 5);
            }

            if (checkBoxQuantitySearchBook.Checked)
            {
                AutoResizeColumn(listViewSearchBook, 6);
            }
        }

        private void HideShow(ListView listView, CheckBox checkBox, int columnIndex)
        {
            ColumnHeader column = listView.Columns[columnIndex];

            if (checkBox.Checked)
            {
                AutoResizeColumn(listView, columnIndex);
            }
            else
            {
                column.Width = 0;
            }
        }

        private void AutoResizeColumn(ListView listView, int columnIndex)
        {
            int maxContentWidth = MaxContentWidth(listView, columnIndex);
            int headerWidth = TextRenderer.MeasureText(listView.Columns[columnIndex].Text, listView.Font).Width;

            if (maxContentWidth > headerWidth)
            {
                listView.AutoResizeColumn(columnIndex, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else if (maxContentWidth < headerWidth)
            {
                listView.AutoResizeColumn(columnIndex, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private int MaxContentWidth(ListView listView, int columnIndex)
        {
            int maxWidth = 0;

            foreach (ListViewItem item in listView.Items)
            {
                string content = item.SubItems[columnIndex].Text;
                int contentWidth = TextRenderer.MeasureText(content, listView.Font).Width;

                if (contentWidth > maxWidth)
                {
                    maxWidth = contentWidth;
                }
            }

            return maxWidth;
        }

        private void checkBoxBookNameSearchBook_CheckedChanged(object sender, EventArgs e)
        {
            HideShow(listViewSearchBook, checkBoxBookNameSearchBook, 1);
        }

        private void checkBoxBookAuthorSearchBook_CheckedChanged(object sender, EventArgs e)
        {
            HideShow(listViewSearchBook, checkBoxBookAuthorSearchBook, 2);
        }

        private void checkBoxBookPublicationSearchBook_CheckedChanged(object sender, EventArgs e)
        {
            HideShow(listViewSearchBook, checkBoxBookPublicationSearchBook, 3);
        }

        private void checkBoxBookReleaseSearchBook_CheckedChanged(object sender, EventArgs e)
        {
            HideShow(listViewSearchBook, checkBoxBookReleaseSearchBook, 4);
        }

        private void checkBoxBookPriceSearchBook_CheckedChanged(object sender, EventArgs e)
        {
            HideShow(listViewSearchBook, checkBoxBookPriceSearchBook, 5);
        }

        private void checkBoxQuantitySearchBook_CheckedChanged(object sender, EventArgs e)
        {

            HideShow(listViewSearchBook, checkBoxQuantitySearchBook, 6);
        }

        private void BookSearch(string searchedValue, string columnName, string table)
        {
            string query = "SELECT BOOKNAME, BOOKAUTHOR, BOOKPUBLICATION, BOOKRELEASEDATE, BOOKPRICE, BOOKQUANTITY " +
                     $"FROM {table} " +
                     $"WHERE {columnName} LIKE '%{searchedValue}%'";

            DisplayData_SearchMenu(query);
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            const string table = "tbl_BOOKDATA";
            if (string.IsNullOrEmpty(textBoxSearchBook.Text))
            {
                listViewSearchBook.Items.Clear();
                DisplayData_SearchMenu("SELECT * FROM tbl_BOOKDATA");
                return;
            }

            listViewSearchBook.Items.Clear();

            if (comboBoxSearchBook.SelectedIndex == 0 && checkBoxBookNameSearchBook.Checked)
            {
                comboBoxSearchBook.ValueMember = "BOOKNAME";
                BookSearch(textBoxSearchBook.Text, comboBoxSearchBook.ValueMember, table);
                return;
            }

            if (comboBoxSearchBook.SelectedIndex == 1 && checkBoxBookNameSearchBook.Checked)
            {
                comboBoxSearchBook.ValueMember = "BOOKAUTHOR";
                BookSearch(textBoxSearchBook.Text, comboBoxSearchBook.ValueMember, table);
                return;
            }

            if (comboBoxSearchBook.SelectedIndex == 2 && checkBoxBookNameSearchBook.Checked)
            {
                comboBoxSearchBook.ValueMember = "BOOKPUBLICATION";
                BookSearch(textBoxSearchBook.Text, comboBoxSearchBook.ValueMember, table);
                return;
            }

            if (comboBoxSearchBook.SelectedIndex == 3 && checkBoxBookNameSearchBook.Checked)
            {
                comboBoxSearchBook.ValueMember = "BOOKPURCHASEDATE";
                BookSearch(textBoxSearchBook.Text, comboBoxSearchBook.ValueMember, table);
                return;
            }

            if (comboBoxSearchBook.SelectedIndex == 4 && checkBoxBookNameSearchBook.Checked)
            {
                comboBoxSearchBook.ValueMember = "BOOKPRICE";
                BookSearch(textBoxSearchBook.Text, comboBoxSearchBook.ValueMember, table);
                return;
            }

            if (comboBoxSearchBook.SelectedIndex == 5 && checkBoxBookNameSearchBook.Checked)
            {
                comboBoxSearchBook.ValueMember = "BOOKQUANTITY";
                BookSearch(textBoxSearchBook.Text, comboBoxSearchBook.ValueMember, table);
                return;
            }
        }


        private string[,] bookInfo = new string[3, 4];

        private void DisplayData_BorrowMenu()
        {
            listViewBorrowBook.Items.Clear();

            string connectionString = "Data Source = DESKTOP-L30S7MD; Initial Catalog = LMS; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT B.BOOKNAME, B.BOOKAUTHOR, B.BOOKPUBLICATION, B.BOOKPRICE, BB.BORROWDATE, BB.RETURNDUE, BB.EXTENDED ,BB.BOOKID " +
                    "FROM tbl_BOOKBORROWDATA BB " +
                    "JOIN tbl_BOOKDATA B ON BB.BOOKID = B.BOOKID " +
                    "JOIN tbl_USERDATA U ON BB.USERID = U.USERID " +
                    $"WHERE U.USERID = '{userId}';";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            int index = 1;
            while (reader.Read())
            {
                string column1Value = reader["BOOKNAME"].ToString();
                string column2Value = reader["BOOKAUTHOR"].ToString();
                string column3Value = reader["BOOKPUBLICATION"].ToString();
                string column4Value = reader["BOOKPRICE"].ToString();
                string[] row = { Convert.ToString(index), column1Value, column2Value, column3Value, column4Value + " $" };
                listViewBorrowBook.Items.Add(new ListViewItem(row));

                DateTime purchaseDate = (DateTime)reader["BORROWDATE"];
                string column5Value = purchaseDate.ToShortDateString();
                purchaseDate = (DateTime)reader["RETURNDUE"];
                string column6Value = purchaseDate.ToShortDateString();
                string column7Value = reader["EXTENDED"].ToString();
                string column8Value = reader["BOOKID"].ToString();
                bookInfo[index - 1, 0] = column5Value;
                bookInfo[index - 1, 1] = column6Value;
                bookInfo[index - 1, 2] = column7Value;
                bookInfo[index - 1, 3] = column8Value;
                index++;
            }

            for (int i = listViewBorrowBook.Columns.Count - 1; i >= 0; i--)
            {
                AutoResizeColumn(listViewBorrowBook, i);
            }

            connection.Close();
        }

        private void listViewBorrowBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBorrowBook.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewBorrowBook.SelectedIndices[0];
                if (selectedIndex >= 0)
                {
                    labelBorrowBookBorrowDate.Text = bookInfo[selectedIndex, 0];
                    labelBorrowBookReturnDate.Text = bookInfo[selectedIndex, 1];
                    if (Convert.ToBoolean(bookInfo[selectedIndex, 2]) == true)
                    {
                        labelBorrowBookExtendedInfo.Visible = true;
                        labelBorrowBookReturnDate.ForeColor = Color.Red;
                    }
                    else
                    {
                        labelBorrowBookExtendedInfo.Visible = false;
                        labelBorrowBookReturnDate.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void panelExtendBook_Click(object sender, EventArgs e)
        {
            string message = "Do you want to extend the selected book by 7 days?";
            string caption = "Message";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            if (listViewBorrowBook.SelectedIndices.Count > 0)
            {
                DialogResult result = MessageBox.Show(this, message, caption, buttons, icon);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = listViewBorrowBook.SelectedIndices[0];

                    if (selectedIndex >= 0 &&
                        Convert.ToBoolean(bookInfo[selectedIndex, 2]) != true)
                    {
                        AddDays();
                        listViewBorrowBook.Items.Clear();
                        DisplayData_BorrowMenu();
                        return;
                    }
                    else
                    {
                        MessageBox.Show(this, "You cannot extend the book twice.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }


            MessageBox.Show(this, "Select the book you want to extend.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddDays()
        {
            string connectionString = "Data Source = DESKTOP-L30S7MD; Initial Catalog = LMS; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);
            int bookId = Convert.ToInt32(bookInfo[listViewBorrowBook.SelectedIndices[0], 3]);
            int userId = 1;

            string query = "UPDATE tbl_BOOKBORROWDATA SET RETURNDUE = DATEADD(day, 7, RETURNDUE), " +
                "EXTENDED = CASE WHEN EXTENDED = 'false' THEN 'true' ELSE EXTENDED END " +
                $"WHERE BOOKID = '{bookId}' AND USERID = '{userId}'";

            connection.Open();
            using SqlCommand command = new SqlCommand(query, connection);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("You have successfully extended the book!");
            }

            connection.Close();
        }

        private void panelUserSettingsMenu_LoadMenu()
        {
            string connectionString = "Data Source = DESKTOP-L30S7MD; Initial Catalog = LMS; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT FIRSTNAME, LASTNAME, PHONENUMBER, ADRESS, CITY, ZIPCODE " +
                    "FROM tbl_USERDATA " +
                    $"WHERE USERID = '{userId}';";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBoxUserSettingsFirstName.Text = reader["FIRSTNAME"].ToString();
                textBoxUserSettingsLastName.Text = reader["LASTNAME"].ToString();
                textBoxUserSettingsPhoneNumber.Text = reader["PHONENUMBER"].ToString();
                textBoxUserSettingsAdress.Text = reader["ADRESS"].ToString();
                textBoxUserSettingsCity.Text = reader["CITY"].ToString();
                textBoxUserSettingsZipCode.Text = reader["ZIPCODE"].ToString();
            }

            connection.Close();
        }

        private void panelUserSettingsMenu_UpdateMenu()
        {
            if (textBoxUserSettingsOldPassword.Text != "Type your old password" ||
                textBoxUserSettingsPassword.Text != textBoxUserSettingsPasswordConfirm.Text)
            {
                MessageBox.Show("The old password does not match or the new password does not match the confirmation.");
                textBoxUserSettingsOldPassword.Text = "Type your old password";
                textBoxUserSettingsPassword.Text = textBoxUserSettingsPasswordConfirm.Text = string.Empty;
                textBoxUserSettingsOldEmail.Text = "Type your old email";
                textBoxUserSettingsEmail.Text = textBoxUserSettingsEmailConfirm.Text = string.Empty;
                return;
            }

            if (textBoxUserSettingsOldEmail.Text != "Type your old email" ||
                textBoxUserSettingsEmail.Text != textBoxUserSettingsEmailConfirm.Text)
            {
                MessageBox.Show("The old email does not match or the new mail does not match the confirmation.");
                textBoxUserSettingsOldPassword.Text = "Type your old password";
                textBoxUserSettingsPassword.Text = textBoxUserSettingsPasswordConfirm.Text = string.Empty;
                textBoxUserSettingsOldEmail.Text = "Type your old email";
                textBoxUserSettingsEmail.Text = textBoxUserSettingsEmailConfirm.Text = string.Empty;
                return;
            }

            string connectionString = "Data Source = DESKTOP-L30S7MD; Initial Catalog = LMS; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command;
            string query;

            if (textBoxUserSettingsPassword.Text == textBoxUserSettingsPasswordConfirm.Text &&
                textBoxUserSettingsOldPassword.Text == GetOldPassword())
            {
                query = "UPDATE tbl_USERDATA " +
                    "SET FIRSTNAME = @FirstName, " +
                    "LASTNAME = @LastName, " +
                    "PHONENUMBER = @PhoneNumber, " +
                    "ADRESS = @Address, " +
                    "CITY = @City, " +
                    "ZIPCODE = @ZipCode, " +
                    "PASSWORD = @Password " +
                    $"WHERE USERID = '{userId}';";

                using (command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", textBoxUserSettingsFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", textBoxUserSettingsLastName.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", textBoxUserSettingsPhoneNumber.Text);
                    command.Parameters.AddWithValue("@Address", textBoxUserSettingsAdress.Text);
                    command.Parameters.AddWithValue("@City", textBoxUserSettingsCity.Text);
                    command.Parameters.AddWithValue("@ZipCode", textBoxUserSettingsZipCode.Text);
                    command.Parameters.AddWithValue("@Password", textBoxUserSettingsPassword.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("You have successfully updated the password adn user informations.");
                    }
                }

                connection.Close();
                return;
            }


            if (textBoxUserSettingsEmail.Text == textBoxUserSettingsEmailConfirm.Text &&
                textBoxUserSettingsOldEmail.Text == GetOldMail())
            {
                query = "UPDATE tbl_USERDATA " +
                    "SET FIRSTNAME = @FirstName, " +
                    "LASTNAME = @LastName, " +
                    "PHONENUMBER = @PhoneNumber, " +
                    "ADRESS = @Address, " +
                    "CITY = @City, " +
                    "ZIPCODE = @ZipCode, " +
                    "MAIL = @Email " +
                    $"WHERE USERID = '{userId}';";

                using (command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", textBoxUserSettingsFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", textBoxUserSettingsLastName.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", textBoxUserSettingsPhoneNumber.Text);
                    command.Parameters.AddWithValue("@Address", textBoxUserSettingsAdress.Text);
                    command.Parameters.AddWithValue("@City", textBoxUserSettingsCity.Text);
                    command.Parameters.AddWithValue("@ZipCode", textBoxUserSettingsZipCode.Text);
                    command.Parameters.AddWithValue("@Email", textBoxUserSettingsEmail.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("You have successfully updated the mail and user informations.");
                    }
                }

                connection.Close();
                return;
            }

            if ((textBoxUserSettingsPassword.Text == textBoxUserSettingsPasswordConfirm.Text &&
                textBoxUserSettingsOldPassword.Text == GetOldPassword()) &&
                (textBoxUserSettingsEmail.Text == textBoxUserSettingsEmailConfirm.Text &&
                textBoxUserSettingsOldEmail.Text == GetOldMail()))
            {
                query = "UPDATE tbl_USERDATA " +
                    "SET FIRSTNAME = @FirstName, " +
                    "LASTNAME = @LastName, " +
                    "PHONENUMBER = @PhoneNumber, " +
                    "ADRESS = @Address, " +
                    "CITY = @City, " +
                    "ZIPCODE = @ZipCode, " +
                    "PASSWORD = @Password, " +
                    "MAIL = @Email " +
                    $"WHERE USERID = '{userId}';";

                using (command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", textBoxUserSettingsFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", textBoxUserSettingsLastName.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", textBoxUserSettingsPhoneNumber.Text);
                    command.Parameters.AddWithValue("@Address", textBoxUserSettingsAdress.Text);
                    command.Parameters.AddWithValue("@City", textBoxUserSettingsCity.Text);
                    command.Parameters.AddWithValue("@ZipCode", textBoxUserSettingsZipCode.Text);
                    command.Parameters.AddWithValue("@Password", textBoxUserSettingsPassword.Text);
                    command.Parameters.AddWithValue("@Email", textBoxUserSettingsEmail.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("You have successfully updated the password , mail and user informations.");
                    }
                }

                connection.Close();
                return;
            }

            query = "UPDATE tbl_USERDATA " +
                "SET FIRSTNAME = @FirstName, " +
                "LASTNAME = @LastName, " +
                "PHONENUMBER = @PhoneNumber, " +
                "ADRESS = @Address, " +
                "CITY = @City, " +
                "ZIPCODE = @ZipCode " +
                $"WHERE USERID = '{userId}';";

            using (command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", textBoxUserSettingsFirstName.Text);
                command.Parameters.AddWithValue("@LastName", textBoxUserSettingsLastName.Text);
                command.Parameters.AddWithValue("@PhoneNumber", textBoxUserSettingsPhoneNumber.Text);
                command.Parameters.AddWithValue("@Address", textBoxUserSettingsAdress.Text);
                command.Parameters.AddWithValue("@City", textBoxUserSettingsCity.Text);
                command.Parameters.AddWithValue("@ZipCode", textBoxUserSettingsZipCode.Text);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("You have successfully updated the user informations.");
                }
            }

            connection.Close();
            return;
        }

        private string GetOldPassword()
        {
            string connectionString = "Data Source = DESKTOP-L30S7MD; Initial Catalog = LMS; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT PASSWORD " +
                    "FROM tbl_USERDATA " +
                    $"WHERE USERID = '{userId}';";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return reader["PASSWORD"].ToString();
            }

            return string.Empty;
        }

        private string GetOldMail()
        {
            string connectionString = "Data Source = DESKTOP-L30S7MD; Initial Catalog = LMS; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT MAIL " +
                    "FROM tbl_USERDATA " +
                    $"WHERE USERID = '{userId}';";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return reader["MAIL"].ToString();
            }

            return string.Empty;
        }

        private void panelUserSettingsUpdate_Click(object sender, EventArgs e)
        {
            panelUserSettingsMenu_UpdateMenu();
            panelUserSettingsMenu_LoadMenu();
        }

        private void pictureBoxVisiblePassword_Click(object sender, EventArgs e)
        {

            if (textBoxUserSettingsOldPassword.UseSystemPasswordChar == false)
            {
                textBoxUserSettingsOldPassword.UseSystemPasswordChar = true;
                textBoxUserSettingsPassword.UseSystemPasswordChar = true;
                textBoxUserSettingsPasswordConfirm.UseSystemPasswordChar = true;
                pictureBoxVisiblePassword.Image = Properties.Resources.icons8_eye_64;
            }
            else
            {
                textBoxUserSettingsOldPassword.UseSystemPasswordChar = false;
                textBoxUserSettingsPassword.UseSystemPasswordChar = false;
                textBoxUserSettingsPasswordConfirm.UseSystemPasswordChar = false;
                pictureBoxVisiblePassword.Image = Properties.Resources.icons8_invisible_64;
            }

        }

        private void textBoxUserSettingsOldEmail_Click(object sender, EventArgs e)
        {
            if (textBoxUserSettingsOldEmail.Text == "Type your old email")
            {
                textBoxUserSettingsOldEmail.Text = string.Empty;
            }
        }

        private void textBoxUserSettingsOldEmail_LostFocus(object sender, EventArgs e)
        {
            if (textBoxUserSettingsOldEmail.Text == string.Empty)
            {
                textBoxUserSettingsOldEmail.Text = "Type your old email";
            }
        }

        private void textBoxUserSettingsOldPassword_Click(object sender, EventArgs e)
        {
            if (textBoxUserSettingsOldPassword.Text == "Type your old password")
            {
                textBoxUserSettingsOldPassword.Text = string.Empty;
            }
        }

        private void textBoxUserSettingsOldPassword_LostFocus(object sender, EventArgs e)
        {
            if (textBoxUserSettingsOldPassword.Text == string.Empty)
            {
                textBoxUserSettingsOldPassword.Text = "Type your old password";
            }
        }

        public void GetAdminMenu()
        {
            if (!panelAdminMenu.Visible)
            {
                panelAdminMenu.Show();
                panelAdminMenu.SendToBack();
            }
        }

        public void HideAdminMenu()
        {
            panelAdminMenu.Hide();
        }

        private void panelReturnBookAdmin_Click(object sender, EventArgs e)
        {
            HideMenus();
            if (!panelRetunBookSearchUserMenu.Visible)
            {
                string query = "SELECT U.FIRSTNAME, U.LASTNAME, COUNT(B.USERID) AS BOOKCOUNT " +
                    "FROM tbl_USERDATA U " +
                    "LEFT JOIN tbl_BOOKBORROWDATA B ON U.USERID = B.USERID " +
                    "GROUP BY U.USERID, U.FIRSTNAME, U.LASTNAME;";
                DisplayUsers_RetunBookSearchUser(query);
                panelRetunBookSearchUserMenu.Show();
                panelRetunBookSearchUserMenu.BringToFront();
                pictureBoxSecondHalfOfLibrary.Hide();
            }
        }

        private void DisplayUsers_RetunBookSearchUser(string query)
        {
            listViewReturnBooksUserSearch.Items.Clear();

            string connectionString = "Data Source = DESKTOP-L30S7MD; Initial Catalog = LMS; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            int index = 1;
            while (reader.Read())
            {
                string column1Value = reader["FIRSTNAME"].ToString();
                string column2Value = reader["LASTNAME"].ToString();
                string column3Value = reader["BOOKCOUNT"].ToString();
                string[] row = { Convert.ToString(index), column1Value, column2Value, column3Value };
                listViewReturnBooksUserSearch.Items.Add(new ListViewItem(row));
                index++;
            }

            for (int i = listViewReturnBooksUserSearch.Columns.Count - 1; i >= 0; i--)
            {
                AutoResizeColumn(listViewReturnBooksUserSearch, i);
            }

            connection.Close();
        }

        private void UserSearch_RetunBookSearchUser(string searchedValue)
        {
            string query = "SELECT U.FIRSTNAME, U.LASTNAME, COUNT(B.USERID) AS BOOKCOUNT " +
                "FROM tbl_USERDATA U " +
                "LEFT JOIN tbl_BOOKBORROWDATA B ON U.USERID = B.USERID " +
                $"WHERE U.FIRSTNAME LIKE '%{searchedValue}%' " +
                "GROUP BY U.USERID, U.FIRSTNAME, U.LASTNAME;";

            DisplayUsers_RetunBookSearchUser(query);
        }

        private void panelReturnBooksUserSearch_Click(object sender, EventArgs e)
        {
            if(listViewReturnBooksUserSearch.SelectedIndices.Count == 0)
            {

                MessageBox.Show("Please select a user from the list.");
                return;
            }

            HideMenus();
            if (!panelReturnBookMenuAdmin.Visible)
            {
                // display books who user borrowed
                panelReturnBookMenuAdmin.Show();
                panelReturnBookMenuAdmin.BringToFront();
                pictureBoxSecondHalfOfLibrary.Hide();
            }
        }

        private void buttonReturnBooksUserSearch_Click(object sender, EventArgs e)
        {
            if(textBoxReturnBooksUserSearch.Text == "Type First Name")
            {
                panelReturnBookAdmin_Click(sender, e);
                return;
            }

            UserSearch_RetunBookSearchUser(textBoxReturnBooksUserSearch.Text);
        }

        private void textBoxReturnBooksUserSearch_Click(object sender, EventArgs e)
        {
            if (textBoxReturnBooksUserSearch.Text == "Type First Name")
            {
                textBoxReturnBooksUserSearch.Text = string.Empty;
            }
        }

        private void textBoxReturnBooksUserSearch_LostFocus(object sender, EventArgs e)
        {
            if (textBoxReturnBooksUserSearch.Text == string.Empty)
            {
                textBoxReturnBooksUserSearch.Text = "Type First Name";
            }
        }
    }
}