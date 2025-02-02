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
        public Form2()
        {
            InitializeComponent();
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

            panel5.Visible = true;
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
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
