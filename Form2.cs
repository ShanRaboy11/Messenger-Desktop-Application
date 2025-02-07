using Messenger_Desktop_Application.Properties;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger_Desktop_Application
{
    public partial class Form2 : Form
    {
        List<string> foundUser = new List<string>();
        private string currentUser, gender, receiver, privacy, searchedEmail;

        public Form2(string username)
        {
            InitializeComponent();
            currentUser = username;
            LoadMessages(currentUser, null);
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
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

        private void Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userLogout(object sender, EventArgs e)
        {
            Form1 login = new Form1();

            login.Show();
            this.Hide();
        }

        private void searchUser(object sender, EventArgs e)
        {
            string[] userInfo = searchForUser(tbxSUser.Text);

            if (userInfo != null)
            {
                lblFullName.Text = userInfo[0] + " " + userInfo[1];
                receiver = lblFullName.Text;
                gender = userInfo[2];

                if (gender == "Male")
                {
                    pbProfilePic.Image = Resources.male_profilepicture;

                }
                else if (gender == "Female")
                {
                    pbProfilePic.Image = Resources.female_profilepicture;
                }
                else
                    pbProfilePic.Image = Resources.notsay_profilepicture;
                lblNotFound.Visible = false;
            }
            else
            {
                lblFullName.Text = "";
                pbProfilePic.Image = null;
                lblNotFound.Visible = true;
            }
        }

        private string[] searchForUser(string input)
        {
            string filePath = AppContext.BaseDirectory + "Accounts.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(','); // Split line into array

                    if (data.Length >= 6) // Ensure there are enough fields
                    {
                        string firstName = data[0].Trim();
                        string lastName = data[1].Trim();
                        searchedEmail = data[2].Trim();
                        gender = data[7].Trim();

                        // Check if input matches username, first name, or last name
                        if (firstName.ToLower() == input.ToLower() || lastName.ToLower() == input.ToLower())
                        {
                            return new string[] { firstName, lastName, gender }; // Return user details
                        }
                    }
                }
            }
            return null; // No match found
        }

        private void tbxSearch(object sender, EventArgs e)
        {
            lblSearch.Text = "";
            lblNotFound.Visible = false;
        }

        private void userMessage(object sender, EventArgs e)
        {
            string[] userInfo = searchForUser(tbxSUser.Text);

            if (userInfo != null)
            {
                foundUser.Clear();
                foundUser.Add(userInfo[0]);
                foundUser.Add(userInfo[1]);
                foundUser.Add(userInfo[2]);

                lblUserMessage.Text = foundUser[0] + " " + foundUser[1];

                gender = foundUser[2];
                if (gender == "Male")
                {
                    pbMessagePic.Image = Resources.male_profilepicture;
                    pbBiggerPhoto.Image = Resources.bigmale_profile;
                }
                else if (gender == "Female")
                {
                    pbMessagePic.Image = Resources.female_profilepicture;
                    pbBiggerPhoto.Image = Resources.bigfemale_profile;
                }
                else
                {
                    pbMessagePic.Image = Resources.notsay_profilepicture;
                    pbBiggerPhoto.Image = Resources.biguser_profile;
                }

                // Make chat UI visible
                flipChatMessage.Visible = true;
                pnlSide.Visible = true;
                separator1.Visible = true;
                separator2.Visible = true;
                pbLike.Visible = true;
                pbGIF.Visible = true;
                pbImages.Visible = true;
                pbPlus.Visible = true;
                pbSticker.Visible = true;
                label3.Visible = true;
                tbxUserMessage.Visible = true;
                pbProfile.Visible = true;
                pbMute.Visible = true;
                pbSearch.Visible = true;
                pbBiggerPhoto.Visible = true;
                lblProfile.Visible = true;
                lblSearchConvo.Visible = true;
                lblMute.Visible = true;

                // Pass the foundUser to LoadMessages directly
                string selectedUsername = $"{foundUser[0]} {foundUser[1]}";
                LoadMessages(currentUser, selectedUsername);  // Pass the full name instead
            }
        }


        private void lblMessage(object sender, EventArgs e)
        {
            label3.Text = "";
            pbLike.Image = Resources.send_icon1;
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string message = tbxUserMessage.Text.Trim();
            if (string.IsNullOrEmpty(message)) return;

            string senderName = currentUser; // Retrieve from login session
            string receiverName = lblUserMessage.Text; // Selected user

            pbLike.Image = Resources.like__1_;
            SendMessage(senderName, receiverName, message);
            tbxUserMessage.Clear();
        }

        private void SendMessage(string sender, string receiver, string message, string imagePath = null)
        {
            string filePath = AppContext.BaseDirectory + "Messages.txt";
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            // Use a lock to prevent concurrent file access issues
            lock (filePath)
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{sender},{receiver},{timestamp},{message},{imagePath}");
                }
            }

            // Update UI with new message
            DisplayMessage(sender, message, timestamp, imagePath, insertAtTop: true);
        }


        private void LoadMessages(string currentUser, string selectedUser)
        {
            flipChatMessage.Controls.Clear(); // Clear previous messages
            string filePath = AppContext.BaseDirectory + "Messages.txt";

            if (!File.Exists(filePath)) return;

            List<string> messages = new List<string>(); // Store messages in a list

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data.Length < 4) continue;

                    string sender = data[0].Trim();
                    string receiver = data[1].Trim();
                    string timestamp = data[2].Trim();
                    string content = data[3].Trim();

                    // Check if message is between currentUser and selectedUser
                    if ((sender == currentUser && receiver == selectedUser) ||
                        (sender == selectedUser && receiver == currentUser))
                    {
                        // Store message
                        messages.Add($"{sender},{content},{timestamp}");
                    }
                }
            }

            // Display messages in reverse order (newest at the bottom)
            for (int i = messages.Count - 1; i >= 0; i--)
            {
                string[] data = messages[i].Split(',');
                string sender = data[0];
                string content = data[1];
                string timestamp = data[2];

                // Display each message correctly based on sender
                DisplayMessage(sender, content, timestamp, insertAtTop: false); // Show latest messages at bottom
            }
        }

        private void DisplayMessage(string sender, string message, string timestamp, string imagePath = null, bool insertAtTop = true)
        {
            FlowLayoutPanel messagePanel = new FlowLayoutPanel
            {
                AutoSize = true,
                WrapContents = false,
                Padding = new Padding(5),
                Margin = new Padding(5),
                MaximumSize = new Size(flipChatMessage.Width - 20, 0)
            };

            Label lblMessage = new Label
            {
                AutoSize = true,
                MaximumSize = new Size(flipChatMessage.Width - 80, 0),
                Padding = new Padding(10),
                ForeColor = Color.Black,
                BorderStyle = BorderStyle.None
            };

            if (sender == currentUser)
            {
                messagePanel.BackColor = Color.LightBlue;
                lblMessage.Text = $"You [{timestamp}]:\n{message}";
            }
            else
            {
                messagePanel.BackColor = Color.LightGray;
                lblMessage.Text = $"{sender} [{timestamp}]:\n{message}";
            }

            messagePanel.Controls.Add(lblMessage);

            // Add Image if exists
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                PictureBox pbMessageImage = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(150, 150),
                    Image = Image.FromFile(imagePath),
                    Margin = new Padding(5)
                };
                messagePanel.Controls.Add(pbMessageImage);
            }

            if (insertAtTop)
            {
                flipChatMessage.Controls.Add(messagePanel);
                flipChatMessage.Controls.SetChildIndex(messagePanel, 0);
            }
            else
            {
                flipChatMessage.Controls.Add(messagePanel);
            }

            flipChatMessage.ScrollControlIntoView(flipChatMessage.Controls[flipChatMessage.Controls.Count - 1]);
            flipChatMessage.PerformLayout();
        }


        private void pbImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    string senderName = currentUser;
                    string receiverName = lblUserMessage.Text;

                    SendMessage(senderName, receiverName, "", imagePath);
                }
            }
        }

        private void DarkMode(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
            pnlSide.BackColor = Color.Black;
            flipChatMessage.BackColor = Color.Black;
            pnlBackground.BackColor = Color.Black;
            lblUserMessage.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            lblFullName.ForeColor = Color.White;
            lblMute.ForeColor = Color.White;
            lblNotFound.ForeColor = Color.White;
            lblProfile.ForeColor = Color.White;
            lblSearchConvo.ForeColor = Color.White;
            lblUserMessage.Visible = false;
            lblNewName.Visible = true;
            lblNewName.Text = receiver;
            pictureBox1.Image = Resources.white_note1;
            pictureBox2.Image = Resources.white_threedots;
            pbMute.Image = Resources.white_bell;
            pbSearch.Image = Resources.white_big_search;
            pbProfile.Image = Resources.white_profile;
            pictureBox3.Image = Resources.white_small_search;
            separator1.Visible = false;

            if (gender == "Male")
            {
                pbBiggerPhoto.Image = Resources.big_male;
                pbMessagePic.Image = Resources.small_male;
                pbProfilePic.Image = Resources.small_male;
            }
            else if (gender == "Female")
            {
                pbBiggerPhoto.Image = Resources.white_female_big;
                pbMessagePic.Image = Resources.white_female_small;
                pbProfilePic.Image = Resources.white_female_small;
            }
            else
            {
                pbBiggerPhoto.Image = Resources.white_profile;
                pbMessagePic.Image = Resources.white_profile;
                pbProfilePic.Image = Resources.white_profile;
            }
            darkModeToolStripMenuItem.Image = Resources.check_icon;
            darkModeToolStripMenuItem.Enabled = false;
            lightModeToolStripMenuItem.Image = null;
            lightModeToolStripMenuItem.Enabled = true;
        }

        private void LightMode(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            pnlSide.BackColor = Color.White;
            flipChatMessage.BackColor = Color.White;
            pnlBackground.BackColor = Color.White;
            lblUserMessage.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            lblFullName.ForeColor = Color.Black;
            lblMute.ForeColor = Color.Black;
            lblNotFound.ForeColor = Color.Black;
            lblProfile.ForeColor = Color.Black;
            lblSearchConvo.ForeColor = Color.Black;
            lblUserMessage.Visible = true;
            lblNewName.Visible = false;
            pictureBox1.Image = Resources.notes;
            pictureBox2.Image = Resources.dots;
            pnlMessage.BackColor = Color.White;
            pbMute.Image = Resources.black_bell;
            pbSearch.Image = Resources.black_search;
            pbProfile.Image = Resources.profile_black;
            pictureBox3.Image = Resources.black_search;
            separator1.Visible = true;

            if (gender == "Male")
            {
                pbBiggerPhoto.Image = Resources.bigmale_profile;
                pbMessagePic.Image = Resources.male_profilepicture;
                pbProfilePic.Image = Resources.male_profilepicture;
            }
            else if (gender == "Female")
            {
                pbMessagePic.Image = Resources.female_profilepicture;
                pbBiggerPhoto.Image = Resources.bigfemale_profile;
                pbProfilePic.Image = Resources.female_profilepicture;
            }
            else
            {
                pbBiggerPhoto.Image = Resources.biguser_profile;
                pbMessagePic.Image = Resources.notsay_profilepicture;
                pbProfilePic.Image = Resources.notsay_profilepicture;
            }
            darkModeToolStripMenuItem.Image = Resources.check_icon;
            lightModeToolStripMenuItem.Enabled = false;
            darkModeToolStripMenuItem.Image = null;
            darkModeToolStripMenuItem.Enabled = true;
        }

        private void ViewProfile(object sender, EventArgs e)
        {
            Form4 profile = new Form4(currentUser);

            profile.Show();
        }

        private void SetToPublic(object sender, EventArgs e)
        {
            UpdatePrivacyStatus(currentUser, "Public");
            publicToolStripMenuItem.Image = Resources.check_icon;
            publicToolStripMenuItem.Enabled = false;
            privateToolStripMenuItem.Image = null;
            privateToolStripMenuItem.Enabled = true;
        }

        private void SetToPrivate(object sender, EventArgs e)
        {
            UpdatePrivacyStatus(currentUser, "Private");
            publicToolStripMenuItem.Image = null;
            publicToolStripMenuItem.Enabled = true;
            privateToolStripMenuItem.Image = Resources.check_icon;
            privateToolStripMenuItem.Enabled = false;
        }

        private void UpdatePrivacyStatus(string userEmail, string newPrivacy)
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Accounts.txt");

            List<string> lines = new List<string>();
            bool userFound = false;

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 9)
                    {
                        string email = data[2].Trim();

                        if (email.Equals(userEmail, StringComparison.OrdinalIgnoreCase))
                        {
                            data[8] = newPrivacy;
                            userFound = true;
                        }
                    }

                    lines.Add(string.Join(",", data));
                }
            }

            if (userFound)
            {
                File.WriteAllLines(filePath, lines);
                MessageBox.Show($"Your account is now set to {newPrivacy}!", "Privacy Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewUserProfile(object sender, EventArgs e)
        {
            Form4 profile = new Form4(searchedEmail);
            profile.Show();
        }

        private void tbxSUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the default "ding" sound
                searchUser(this, EventArgs.Empty); // Simulate clicking the Send button
            }
        }
    }
}