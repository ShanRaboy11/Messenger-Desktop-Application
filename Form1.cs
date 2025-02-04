using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Transactions;

namespace Messenger_Desktop_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> credentials = new List<string>();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
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

        private void loginUser(object sender, EventArgs e)
        {
            userName.Text = "";
        }

        private void loginPass(object sender, EventArgs e)
        {
            userPass.Text = "";
        }

        private void createAcc(object sender, EventArgs e)
        {
            Form3 signup = new Form3();
            signup.FormClosed += (s, args) => this.Show();
            signup.Owner = this;
            signup.Show();
            this.Hide();
        }

        private void btnLogin(object sender, EventArgs e)
        {

            if (searchCredentials(tbxUserName.Text, tbxPassword.Text) == 1)
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 messenger = new Form2(tbxUserName.Text);
                messenger.Show();
                this.Hide();
            }
            else if(tbxUserName.Text == "" && tbxPassword.Text == "")
            {
                MessageBox.Show("Fill in all required fields to login.\nPlease try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed" , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public int searchCredentials(string username, string password)
        {
            string filePath = AppContext.BaseDirectory + "Accounts.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null) // Read file line by line
                {
                    string[] data = line.Split(','); // Assume CSV format: username,password,...

                    // Ensure the line has at least two values (username & password)
                    if (data.Length >= 4)
                    {
                        string storedUsername = data[2].Trim(); // First column: username
                        string storedPassword = data[3].Trim(); // Second column: password

                        // Check if the credentials match
                        if (storedUsername == username && storedPassword == password)
                        {
                            return 1; // Match found, return success
                        }
                    }
                }
            }
            return 0; // No match found
        }
    }
}
