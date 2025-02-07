﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Messenger_Desktop_Application
{
    public partial class Form3 : Form
    {
        private List<string> personalInformation = new List<string>();
        public Form3()
        {
            InitializeComponent();
        }

        private void signedUpSuccessfully(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userCFirstName.Text) ||
                 string.IsNullOrWhiteSpace(userCLastName.Text) ||
                 string.IsNullOrWhiteSpace(userCEmail.Text) ||
                  string.IsNullOrWhiteSpace(userCPassword.Text) ||
                  string.IsNullOrWhiteSpace(birthMonth.Text) ||
                  string.IsNullOrWhiteSpace(birthDay.Text) ||
                  string.IsNullOrWhiteSpace(birthYear.Text) ||
                  (!rbtnFemale.Checked && !rbtnMale.Checked && !rbtnNotSay.Checked)) // Ensure a gender is selected
            {
                MessageBox.Show("Please fill in all required fields before signing up.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            personalInformation.Add(userCFirstName.Text);
            personalInformation.Add(userCLastName.Text);
            personalInformation.Add(userCEmail.Text);
            personalInformation.Add(userCPassword.Text);
            personalInformation.Add(birthMonth.Text);
            personalInformation.Add(birthDay.Text);
            personalInformation.Add(birthYear.Text);
            if (rbtnFemale.Checked)
            {
                personalInformation.Add(rbtnFemale.Text);
            }
            else if (rbtnMale.Checked)
            {
                personalInformation.Add(rbtnMale.Text);
            }
            else if (rbtnNotSay.Checked)
            {
                personalInformation.Add(rbtnNotSay.Text);
            }
            personalInformation.Add("Public");
            if (int.Parse(birthYear.Text) <= 2012)
            {
                MessageBox.Show("Signed up Successfully! \n\nWelcome to Messenger!",
                                                 "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                saveAccount(personalInformation);
                this.Close();
            }
            else
                MessageBox.Show("Age Restriction\n\nUser must be at least 13 years old to use Messenger.",
                                                 "Sign-up Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
    }

        private void userFirstName(object sender, EventArgs e)
        {
            lblFirst.Text = "";
        }

        private void userLastName(object sender, EventArgs e)
        {
            lblLast.Text = "";
        }

        private void userEmail(object sender, EventArgs e)
        {
            lblEmail.Text = "";
        }

        private void userPass(object sender, EventArgs e)
        {
            lblPass.Text = "";
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
            this.Close();
        }

        public void saveAccount(List<string> information)
        {
            string filePath = AppContext.BaseDirectory + "Accounts.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(string.Join(",", information));
            }
        }
    }
}
