using Messenger_Desktop_Application.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Messenger_Desktop_Application
{
    public partial class Form4 : Form
    {
        private string currentUser;

        public Form4(string userEmail) 
        {
            InitializeComponent();
            currentUser = userEmail;

            string[] userInfo = searchForUser(currentUser);

            if (userInfo != null)
            {
                lblFullName.Text = $"{userInfo[0]} {userInfo[1]}"; 
                lblEmail.Text = userInfo[2]; 
                lblGender.Text = userInfo[5]; 
                if (userInfo[5] == "Male")
                {
                    pbProfileImage.Image = Resources.bigmale_profile;
                }
                else if (userInfo[6] == "Female")
                {
                    pbProfileImage.Image = Resources.bigfemale_profile;
                }
                else
                    pbProfileImage.Image = Resources.biguser_profile;
                lblBirthdate.Text = userInfo[4]; // Birthdate (formatted)
                lblPassword.Text = new string('*', userInfo[3].Length); // Masked password
                lblPrivacy.Text = userInfo[6];
            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximize(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized) ?
                               FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private string[] searchForUser(string emailToFind)
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Accounts.txt");

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 8)
                    {
                        string firstName = data[0].Trim();
                        string lastName = data[1].Trim();
                        string email = data[2].Trim();
                        string password = data[3].Trim();
                        string birthMonth = data[4].Trim();
                        string birthDate = data[5].Trim();
                        string birthYear = data[6].Trim();
                        string gender = data[7].Trim();
                        string privacy = data[8].Trim();
                        string birthdate = $"{birthMonth} {birthDate}, {birthYear}";

                        // ✅ Fix: Now checking if the email matches
                        if (email.Equals(emailToFind, StringComparison.OrdinalIgnoreCase))
                        {
                            return new string[] { firstName, lastName, email, password, birthdate, gender,privacy };
                        }
                    }
                }
            }
            return null; // No match found
        }
    }
}
