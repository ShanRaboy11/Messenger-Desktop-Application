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

            if (searchCredentials(tbxUsername.Text, tbxPassword.Text) == 1)
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 messenger = new Form2(tbxUsername.Text);
                messenger.Show();
                this.Hide();
            }
            else if (tbxUsername.Text == "" && tbxPassword.Text == "")
            {
                MessageBox.Show("Fill in all required fields to login.\nPlease try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public int searchCredentials(string username, string password)
        {
            string filePath = AppContext.BaseDirectory + "Accounts.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null) 
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 4)
                    {
                        string storedUsername = data[2].Trim(); 
                        string storedPassword = data[3].Trim();

                        if (storedUsername == username && storedPassword == password)
                        {
                            return 1; 
                        }
                    }
                }
            }
            return 0;
        }

        private void CopyText(object sender, EventArgs e)
        {
            if (tbxUsername.SelectedText.Length > 0)
            {
                Clipboard.SetText(tbxUsername.SelectedText);
            }
        }

        private void CutText(object sender, EventArgs e)
        {
            if (tbxUsername.SelectedText.Length > 0)
            {
                Clipboard.SetText(tbxUsername.SelectedText);
                tbxUsername.SelectedText = "";
            }
        }

        private void PasteText(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                int selectionStart = tbxUsername.SelectionStart;
                tbxUsername.Text = tbxUsername.Text.Insert(selectionStart, Clipboard.GetText());
                tbxUsername.SelectionStart = selectionStart + Clipboard.GetText().Length;
            }
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            tbxUsername.SelectAll();
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                btnLogin(this, EventArgs.Empty);
            }
        }
    }
}