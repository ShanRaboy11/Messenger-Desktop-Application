using Messenger_Desktop_Application.Properties;
using System;
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
        List <string> foundUser = new List<string>();
        private string currentUser;

        public Form2(string username)
        {
            InitializeComponent();
            currentUser = username; // Assign the logged-in user
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

        private const int WM_NCHITTEST = 0x84;
        private const int HTBOTTOMRIGHT = 17;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
            {
                // Get mouse position
                Point cursor = PointToClient(Cursor.Position);
                int gripSize = 10; // Resize corner sensitivity

                if (cursor.X >= this.ClientSize.Width - gripSize && cursor.Y >= this.ClientSize.Height - gripSize)
                {
                    m.Result = (IntPtr)HTBOTTOMRIGHT; // Resize from bottom-right corner
                }
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
                string gender = userInfo[2];

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
                        string gender = data[7].Trim();

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

            foundUser.Add(userInfo[0]);
            foundUser.Add(userInfo[1]);
            foundUser.Add(userInfo[2]);

            lblUserMessage.Text = foundUser[0] + " " + foundUser[1];
            string gender = foundUser[2];
            if (gender == "Male")
            {
                pbMessagePic.Image = Resources.male_profilepicture;
            }
            else if (gender == "Female")
            {
                pbMessagePic.Image = Resources.female_profilepicture;
            }
            else
                pbMessagePic.Image = Resources.notsay_profilepicture;

            flpChatMessages.Visible = true;
            separator1.Visible = true;
            separator2.Visible = true;
            pbLike.Visible = true;
            pbGIF.Visible = true;
            pbImages.Visible = true;
            pbPlus.Visible = true;
            pbSticker.Visible = true;
            label3.Visible = true;
            tbxUserMessage.Visible = true;
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

            SendMessage(senderName, receiverName, message);
            tbxUserMessage.Clear();
        }

        private void SendMessage(string sender, string receiver, string message)
        {
            string filePath = AppContext.BaseDirectory + "Messages.txt";
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{sender},{receiver},{timestamp},{message}");
            }

            // Update UI with new message
            DisplayMessage(sender, message, timestamp);
        }

        private void LoadMessages(string currentUser)
        {
            flpChatMessages.Controls.Clear();
            string filePath = AppContext.BaseDirectory + "Messages.txt";

            if (!File.Exists(filePath)) return;

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

                    if (sender == currentUser || receiver == currentUser)
                    {
                        DisplayMessage(sender, content, timestamp);
                    }
                }
            }
        }

        private void DisplayMessage(string sender, string message, string timestamp)
        {
            // Panel for message
            Panel pnlMessage = new Panel();
            pnlMessage.AutoSize = true;
            pnlMessage.Padding = new Padding(5);
            pnlMessage.Margin = new Padding(5);
            pnlMessage.MaximumSize = new Size(flpChatMessages.Width - 20, 0);
            pnlMessage.BackColor = sender == currentUser ? Color.LightBlue : Color.LightGray;

            // Label for text
            Label lblMessage = new Label();
            lblMessage.AutoSize = true;
            lblMessage.Padding = new Padding(10);
            lblMessage.MaximumSize = new Size(flpChatMessages.Width - 40, 0);
            lblMessage.Text = $"{sender} [{timestamp}]:\n{message}";
            lblMessage.ForeColor = Color.Black;
            lblMessage.BorderStyle = BorderStyle.None;

            // Align message based on sender
            if (sender == currentUser)
            {
                lblMessage.TextAlign = ContentAlignment.MiddleRight;
                pnlMessage.Dock = DockStyle.Right;
            }
            else
            {
                lblMessage.TextAlign = ContentAlignment.MiddleLeft;
                pnlMessage.Dock = DockStyle.Left;
            }

            // Add label to panel
            pnlMessage.Controls.Add(lblMessage);

            // Add panel to FlowLayoutPanel
            flpChatMessages.Controls.Add(pnlMessage);

            // Ensure latest message is visible
            flpChatMessages.ScrollControlIntoView(pnlMessage);
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
