using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger_Desktop_Application
{
    public partial class Form4 : Form
    {
        private string currentUser;
        public Form4(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private string[] searchForUser(string input)
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Accounts.txt");

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(','); // Split line into an array

                    if (data.Length >= 8) // Ensure all fields exist
                    {
                        string firstName = data[0].Trim();
                        string lastName = data[1].Trim();
                        string email = data[2].Trim();
                        string password = data[3].Trim(); // Password (will be masked)
                        string birthMonth = data[4].Trim();
                        string birthDate = data[5].Trim();
                        string birthYear = data[6].Trim();
                        string gender = data[7].Trim();

                        string birthdate = $"{birthMonth} {birthDate}, {birthYear}"; // Format birthdate

                        // Check if input matches first name or last name
                        if (firstName.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                            lastName.Equals(input, StringComparison.OrdinalIgnoreCase))
                        {
                            return new string[] { firstName, lastName, email, password, birthdate, gender };
                        }
                    }
                }
            }
            return null; // No match found
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            string[] userInfo = searchForUser(currentUser);

            if (userInfo != null)
            {
                lblFullName.Text = $"{userInfo[0]} {userInfo[1]}"; // FirstName LastName
                lblEmail.Text = userInfo[2]; // Email
                lblGender.Text = userInfo[5]; // Gender
                lblBirthdate.Text = userInfo[4]; // Formatted Birthdate
                lblPassword.Text = new string('*', userInfo[3].Length); // Mask Password
            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }


}
