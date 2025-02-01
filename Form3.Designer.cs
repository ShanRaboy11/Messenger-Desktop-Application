namespace Messenger_Desktop_Application
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            separator1 = new ReaLTaiizor.Controls.Separator();
            lblFirst = new Label();
            userCFirstName = new TextBox();
            lblLast = new Label();
            userCLastName = new TextBox();
            lblPass = new Label();
            userCPassword = new TextBox();
            lblEmail = new Label();
            userCEmail = new TextBox();
            label5 = new Label();
            birthMonth = new ReaLTaiizor.Controls.AloneComboBox();
            birthDay = new ReaLTaiizor.Controls.AloneComboBox();
            birthYear = new ReaLTaiizor.Controls.AloneComboBox();
            label6 = new Label();
            rbtnFemale = new ReaLTaiizor.Controls.HopeRadioButton();
            rbtnMale = new ReaLTaiizor.Controls.HopeRadioButton();
            rbtnNotSay = new ReaLTaiizor.Controls.HopeRadioButton();
            label7 = new Label();
            button4 = new ReaLTaiizor.Controls.Button();
            richTextBoxEdit7 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            richTextBoxEdit1 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            richTextBoxEdit2 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            richTextBoxEdit3 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            richTextBoxEdit8 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            richTextBoxEdit4 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            richTextBoxEdit6 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            contextForms3 = new ContextMenuStrip(components);
            closeToolStripMenuItem = new ToolStripMenuItem();
            maximizeToolStripMenuItem = new ToolStripMenuItem();
            minimizeToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            contextForms3.SuspendLayout();
            SuspendLayout();
            // 
            // airButton1
            // 
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Segoe UI", 9F);
            airButton1.Image = null;
            airButton1.Location = new Point(485, 135);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(8, 8);
            airButton1.TabIndex = 0;
            airButton1.Text = "airButton1";
            airButton1.Transparent = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 29);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(2, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(26, 25);
            button1.TabIndex = 7;
            button1.TabStop = false;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Close;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(52, -1);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(26, 26);
            button2.TabIndex = 3;
            button2.TabStop = false;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Maximize;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ControlLight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(27, -1);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(25, 26);
            button3.TabIndex = 8;
            button3.TabStop = false;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Minimize;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica Neue", 20.75F, FontStyle.Bold);
            label1.Location = new Point(8, 45);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 6;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(13, 80);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 7;
            label2.Text = "It's quick and easy.";
            // 
            // separator1
            // 
            separator1.LineColor = Color.Gray;
            separator1.Location = new Point(11, 98);
            separator1.Name = "separator1";
            separator1.Size = new Size(506, 20);
            separator1.TabIndex = 9;
            separator1.Text = "separator1";
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.BackColor = Color.White;
            lblFirst.Font = new Font("Helvetica Neue", 10.999999F);
            lblFirst.ForeColor = Color.DimGray;
            lblFirst.Location = new Point(24, 136);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(78, 17);
            lblFirst.TabIndex = 40;
            lblFirst.Text = "First Name";
            // 
            // userCFirstName
            // 
            userCFirstName.BackColor = Color.White;
            userCFirstName.BorderStyle = BorderStyle.None;
            userCFirstName.Font = new Font("Helvetica Neue", 11F);
            userCFirstName.ForeColor = Color.Black;
            userCFirstName.Location = new Point(27, 137);
            userCFirstName.Name = "userCFirstName";
            userCFirstName.Size = new Size(258, 17);
            userCFirstName.TabIndex = 41;
            userCFirstName.Click += userFirstName;
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.BackColor = Color.White;
            lblLast.Font = new Font("Helvetica Neue", 10.999999F);
            lblLast.ForeColor = Color.DimGray;
            lblLast.Location = new Point(319, 137);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(78, 17);
            lblLast.TabIndex = 43;
            lblLast.Text = "Last Name";
            lblLast.Click += userLastName;
            // 
            // userCLastName
            // 
            userCLastName.BackColor = Color.White;
            userCLastName.BorderStyle = BorderStyle.None;
            userCLastName.Font = new Font("Helvetica Neue", 11F);
            userCLastName.ForeColor = Color.Black;
            userCLastName.Location = new Point(322, 135);
            userCLastName.Name = "userCLastName";
            userCLastName.Size = new Size(182, 17);
            userCLastName.TabIndex = 44;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.White;
            lblPass.Font = new Font("Helvetica Neue", 10.999999F);
            lblPass.ForeColor = Color.DimGray;
            lblPass.Location = new Point(23, 255);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(106, 17);
            lblPass.TabIndex = 47;
            lblPass.Text = "New password";
            // 
            // userCPassword
            // 
            userCPassword.BackColor = Color.White;
            userCPassword.BorderStyle = BorderStyle.None;
            userCPassword.Font = new Font("Helvetica Neue", 11F);
            userCPassword.ForeColor = Color.Black;
            userCPassword.Location = new Point(25, 255);
            userCPassword.Name = "userCPassword";
            userCPassword.PasswordChar = '*';
            userCPassword.Size = new Size(478, 17);
            userCPassword.TabIndex = 50;
            userCPassword.Leave += userPass;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.White;
            lblEmail.Font = new Font("Helvetica Neue", 10.999999F);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(23, 195);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(160, 17);
            lblEmail.TabIndex = 46;
            lblEmail.Text = "Mobile number or email";
            // 
            // userCEmail
            // 
            userCEmail.BackColor = Color.White;
            userCEmail.BorderStyle = BorderStyle.None;
            userCEmail.Font = new Font("Helvetica Neue", 11F);
            userCEmail.ForeColor = Color.Black;
            userCEmail.Location = new Point(23, 196);
            userCEmail.Name = "userCEmail";
            userCEmail.Size = new Size(478, 17);
            userCEmail.TabIndex = 48;
            userCEmail.Click += userEmail;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica Neue", 10.749999F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(11, 303);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 52;
            label5.Text = "Birthday";
            // 
            // birthMonth
            // 
            birthMonth.DrawMode = DrawMode.OwnerDrawFixed;
            birthMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            birthMonth.EnabledCalc = true;
            birthMonth.Font = new Font("Helvetica Neue", 11.749999F);
            birthMonth.FormattingEnabled = true;
            birthMonth.ItemHeight = 20;
            birthMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            birthMonth.Location = new Point(18, 329);
            birthMonth.Name = "birthMonth";
            birthMonth.Size = new Size(170, 26);
            birthMonth.TabIndex = 55;
            // 
            // birthDay
            // 
            birthDay.DrawMode = DrawMode.OwnerDrawFixed;
            birthDay.DropDownStyle = ComboBoxStyle.DropDownList;
            birthDay.EnabledCalc = true;
            birthDay.Font = new Font("Helvetica Neue", 11.749999F);
            birthDay.FormattingEnabled = true;
            birthDay.ItemHeight = 20;
            birthDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            birthDay.Location = new Point(213, 329);
            birthDay.Name = "birthDay";
            birthDay.Size = new Size(142, 26);
            birthDay.TabIndex = 56;
            // 
            // birthYear
            // 
            birthYear.DrawMode = DrawMode.OwnerDrawFixed;
            birthYear.DropDownStyle = ComboBoxStyle.DropDownList;
            birthYear.EnabledCalc = true;
            birthYear.Font = new Font("Helvetica Neue", 11.749999F);
            birthYear.FormattingEnabled = true;
            birthYear.ItemHeight = 20;
            birthYear.Items.AddRange(new object[] { "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            birthYear.Location = new Point(376, 329);
            birthYear.Name = "birthYear";
            birthYear.Size = new Size(134, 26);
            birthYear.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Helvetica Neue", 10.749999F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(13, 376);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 58;
            label6.Text = "Gender";
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.BackColor = Color.White;
            rbtnFemale.CheckedColor = Color.FromArgb(64, 158, 255);
            rbtnFemale.DisabledColor = Color.FromArgb(196, 198, 202);
            rbtnFemale.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rbtnFemale.Enable = true;
            rbtnFemale.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rbtnFemale.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rbtnFemale.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rbtnFemale.Font = new Font("Helvetica Neue", 10.749999F);
            rbtnFemale.ForeColor = Color.Black;
            rbtnFemale.Location = new Point(30, 413);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(80, 20);
            rbtnFemale.TabIndex = 59;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = false;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.BackColor = Color.White;
            rbtnMale.CheckedColor = Color.FromArgb(64, 158, 255);
            rbtnMale.DisabledColor = Color.FromArgb(196, 198, 202);
            rbtnMale.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rbtnMale.Enable = true;
            rbtnMale.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rbtnMale.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rbtnMale.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rbtnMale.Font = new Font("Helvetica Neue", 10.749999F);
            rbtnMale.ForeColor = Color.Black;
            rbtnMale.Location = new Point(198, 413);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(64, 20);
            rbtnMale.TabIndex = 61;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = false;
            // 
            // rbtnNotSay
            // 
            rbtnNotSay.AutoSize = true;
            rbtnNotSay.BackColor = Color.White;
            rbtnNotSay.CheckedColor = Color.FromArgb(64, 158, 255);
            rbtnNotSay.DisabledColor = Color.FromArgb(196, 198, 202);
            rbtnNotSay.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rbtnNotSay.Enable = true;
            rbtnNotSay.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rbtnNotSay.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rbtnNotSay.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rbtnNotSay.Font = new Font("Helvetica Neue", 10.749999F);
            rbtnNotSay.ForeColor = Color.Black;
            rbtnNotSay.Location = new Point(365, 413);
            rbtnNotSay.Name = "rbtnNotSay";
            rbtnNotSay.Size = new Size(138, 20);
            rbtnNotSay.TabIndex = 62;
            rbtnNotSay.TabStop = true;
            rbtnNotSay.Text = "Prefer not to say";
            rbtnNotSay.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(18, 469);
            label7.Name = "label7";
            label7.Size = new Size(445, 15);
            label7.TabIndex = 65;
            label7.Text = "By clicking Sing Up, you agreee to our Terms, Data Policy and Cookies Policy.";
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.BorderColor = Color.FromArgb(0, 165, 0);
            button4.EnteredBorderColor = Color.FromArgb(255, 192, 192);
            button4.EnteredColor = Color.FromArgb(0, 165, 0);
            button4.Font = new Font("Helvetica Neue", 13F, FontStyle.Bold);
            button4.Image = null;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.InactiveColor = Color.FromArgb(0, 165, 0);
            button4.Location = new Point(150, 495);
            button4.Name = "button4";
            button4.PressedBorderColor = Color.FromArgb(0, 106, 255);
            button4.PressedColor = Color.FromArgb(0, 106, 255);
            button4.Size = new Size(215, 40);
            button4.TabIndex = 67;
            button4.Text = "Sign Up";
            button4.TextAlignment = StringAlignment.Center;
            button4.Click += signedUpSuccessfully;
            // 
            // richTextBoxEdit7
            // 
            richTextBoxEdit7.AutoWordSelection = false;
            richTextBoxEdit7.BackColor = Color.Transparent;
            richTextBoxEdit7.BackgroundImageLayout = ImageLayout.Center;
            richTextBoxEdit7.BaseColor = Color.Transparent;
            richTextBoxEdit7.BorderColor = Color.FromArgb(180, 180, 180);
            richTextBoxEdit7.EdgeColor = Color.White;
            richTextBoxEdit7.Enabled = false;
            richTextBoxEdit7.Font = new Font("Helvetica Neue", 10.749999F);
            richTextBoxEdit7.ForeColor = Color.White;
            richTextBoxEdit7.Location = new Point(17, 120);
            richTextBoxEdit7.Margin = new Padding(10, 9, 10, 9);
            richTextBoxEdit7.Name = "richTextBoxEdit7";
            richTextBoxEdit7.ReadOnly = false;
            richTextBoxEdit7.Size = new Size(282, 48);
            richTextBoxEdit7.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit7.TabIndex = 77;
            richTextBoxEdit7.TextBackColor = Color.White;
            richTextBoxEdit7.TextBorderStyle = BorderStyle.None;
            richTextBoxEdit7.TextFont = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEdit7.WordWrap = true;
            // 
            // richTextBoxEdit1
            // 
            richTextBoxEdit1.AutoWordSelection = false;
            richTextBoxEdit1.BackColor = Color.Transparent;
            richTextBoxEdit1.BackgroundImageLayout = ImageLayout.Center;
            richTextBoxEdit1.BaseColor = Color.Transparent;
            richTextBoxEdit1.BorderColor = Color.FromArgb(180, 180, 180);
            richTextBoxEdit1.EdgeColor = Color.White;
            richTextBoxEdit1.Enabled = false;
            richTextBoxEdit1.Font = new Font("Helvetica Neue", 10.749999F);
            richTextBoxEdit1.ForeColor = Color.White;
            richTextBoxEdit1.Location = new Point(313, 120);
            richTextBoxEdit1.Margin = new Padding(10, 9, 10, 9);
            richTextBoxEdit1.Name = "richTextBoxEdit1";
            richTextBoxEdit1.ReadOnly = false;
            richTextBoxEdit1.Size = new Size(204, 48);
            richTextBoxEdit1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit1.TabIndex = 78;
            richTextBoxEdit1.TextBackColor = Color.White;
            richTextBoxEdit1.TextBorderStyle = BorderStyle.None;
            richTextBoxEdit1.TextFont = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEdit1.WordWrap = true;
            // 
            // richTextBoxEdit2
            // 
            richTextBoxEdit2.AutoWordSelection = false;
            richTextBoxEdit2.BackColor = Color.Transparent;
            richTextBoxEdit2.BackgroundImageLayout = ImageLayout.Center;
            richTextBoxEdit2.BaseColor = Color.Transparent;
            richTextBoxEdit2.BorderColor = Color.FromArgb(180, 180, 180);
            richTextBoxEdit2.EdgeColor = Color.White;
            richTextBoxEdit2.Enabled = false;
            richTextBoxEdit2.Font = new Font("Helvetica Neue", 10.749999F);
            richTextBoxEdit2.ForeColor = Color.White;
            richTextBoxEdit2.Location = new Point(16, 179);
            richTextBoxEdit2.Margin = new Padding(10, 9, 10, 9);
            richTextBoxEdit2.Name = "richTextBoxEdit2";
            richTextBoxEdit2.ReadOnly = false;
            richTextBoxEdit2.Size = new Size(501, 48);
            richTextBoxEdit2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit2.TabIndex = 79;
            richTextBoxEdit2.TextBackColor = Color.White;
            richTextBoxEdit2.TextBorderStyle = BorderStyle.None;
            richTextBoxEdit2.TextFont = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEdit2.WordWrap = true;
            // 
            // richTextBoxEdit3
            // 
            richTextBoxEdit3.AutoWordSelection = false;
            richTextBoxEdit3.BackColor = Color.Transparent;
            richTextBoxEdit3.BackgroundImageLayout = ImageLayout.Center;
            richTextBoxEdit3.BaseColor = Color.Transparent;
            richTextBoxEdit3.BorderColor = Color.FromArgb(180, 180, 180);
            richTextBoxEdit3.EdgeColor = Color.White;
            richTextBoxEdit3.Enabled = false;
            richTextBoxEdit3.Font = new Font("Helvetica Neue", 10.749999F);
            richTextBoxEdit3.ForeColor = Color.White;
            richTextBoxEdit3.Location = new Point(16, 240);
            richTextBoxEdit3.Margin = new Padding(10, 9, 10, 9);
            richTextBoxEdit3.Name = "richTextBoxEdit3";
            richTextBoxEdit3.ReadOnly = false;
            richTextBoxEdit3.Size = new Size(501, 48);
            richTextBoxEdit3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit3.TabIndex = 80;
            richTextBoxEdit3.TextBackColor = Color.White;
            richTextBoxEdit3.TextBorderStyle = BorderStyle.None;
            richTextBoxEdit3.TextFont = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEdit3.WordWrap = true;
            // 
            // richTextBoxEdit8
            // 
            richTextBoxEdit8.AutoWordSelection = false;
            richTextBoxEdit8.BackColor = Color.Transparent;
            richTextBoxEdit8.BackgroundImageLayout = ImageLayout.Center;
            richTextBoxEdit8.BaseColor = Color.Transparent;
            richTextBoxEdit8.BorderColor = Color.FromArgb(180, 180, 180);
            richTextBoxEdit8.EdgeColor = Color.White;
            richTextBoxEdit8.Enabled = false;
            richTextBoxEdit8.Font = new Font("Helvetica Neue", 10.749999F);
            richTextBoxEdit8.ForeColor = Color.White;
            richTextBoxEdit8.Location = new Point(18, 402);
            richTextBoxEdit8.Margin = new Padding(10, 9, 10, 9);
            richTextBoxEdit8.Name = "richTextBoxEdit8";
            richTextBoxEdit8.ReadOnly = false;
            richTextBoxEdit8.Size = new Size(157, 40);
            richTextBoxEdit8.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit8.TabIndex = 81;
            richTextBoxEdit8.TextBackColor = Color.White;
            richTextBoxEdit8.TextBorderStyle = BorderStyle.None;
            richTextBoxEdit8.TextFont = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEdit8.WordWrap = true;
            // 
            // richTextBoxEdit4
            // 
            richTextBoxEdit4.AutoWordSelection = false;
            richTextBoxEdit4.BackColor = Color.Transparent;
            richTextBoxEdit4.BackgroundImageLayout = ImageLayout.Center;
            richTextBoxEdit4.BaseColor = Color.Transparent;
            richTextBoxEdit4.BorderColor = Color.FromArgb(180, 180, 180);
            richTextBoxEdit4.EdgeColor = Color.White;
            richTextBoxEdit4.Enabled = false;
            richTextBoxEdit4.Font = new Font("Helvetica Neue", 10.749999F);
            richTextBoxEdit4.ForeColor = Color.White;
            richTextBoxEdit4.Location = new Point(185, 402);
            richTextBoxEdit4.Margin = new Padding(10, 9, 10, 9);
            richTextBoxEdit4.Name = "richTextBoxEdit4";
            richTextBoxEdit4.ReadOnly = false;
            richTextBoxEdit4.Size = new Size(157, 40);
            richTextBoxEdit4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit4.TabIndex = 82;
            richTextBoxEdit4.TextBackColor = Color.White;
            richTextBoxEdit4.TextBorderStyle = BorderStyle.None;
            richTextBoxEdit4.TextFont = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEdit4.WordWrap = true;
            // 
            // richTextBoxEdit6
            // 
            richTextBoxEdit6.AutoWordSelection = false;
            richTextBoxEdit6.BackColor = Color.Transparent;
            richTextBoxEdit6.BackgroundImageLayout = ImageLayout.Center;
            richTextBoxEdit6.BaseColor = Color.Transparent;
            richTextBoxEdit6.BorderColor = Color.FromArgb(180, 180, 180);
            richTextBoxEdit6.EdgeColor = Color.White;
            richTextBoxEdit6.Enabled = false;
            richTextBoxEdit6.Font = new Font("Helvetica Neue", 10.749999F);
            richTextBoxEdit6.ForeColor = Color.DimGray;
            richTextBoxEdit6.Location = new Point(352, 402);
            richTextBoxEdit6.Margin = new Padding(10, 9, 10, 9);
            richTextBoxEdit6.Name = "richTextBoxEdit6";
            richTextBoxEdit6.ReadOnly = false;
            richTextBoxEdit6.Size = new Size(167, 40);
            richTextBoxEdit6.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit6.TabIndex = 83;
            richTextBoxEdit6.TextBackColor = Color.White;
            richTextBoxEdit6.TextBorderStyle = BorderStyle.None;
            richTextBoxEdit6.TextFont = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEdit6.WordWrap = true;
            // 
            // contextForms3
            // 
            contextForms3.Items.AddRange(new ToolStripItem[] { closeToolStripMenuItem, maximizeToolStripMenuItem, minimizeToolStripMenuItem });
            contextForms3.Name = "contextMenuStrip1";
            contextForms3.Size = new Size(127, 70);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeToolStripMenuItem.Image = Properties.Resources.close_window;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(126, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += Close;
            // 
            // maximizeToolStripMenuItem
            // 
            maximizeToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maximizeToolStripMenuItem.Image = Properties.Resources.maximise;
            maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            maximizeToolStripMenuItem.Size = new Size(126, 22);
            maximizeToolStripMenuItem.Text = "Maximize";
            maximizeToolStripMenuItem.Click += Maximize;
            // 
            // minimizeToolStripMenuItem
            // 
            minimizeToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minimizeToolStripMenuItem.Image = Properties.Resources.window_minimize;
            minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            minimizeToolStripMenuItem.Size = new Size(126, 22);
            minimizeToolStripMenuItem.Text = "Minimize";
            minimizeToolStripMenuItem.Click += Minimize;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(554, 547);
            ContextMenuStrip = contextForms3;
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(rbtnNotSay);
            Controls.Add(rbtnMale);
            Controls.Add(rbtnFemale);
            Controls.Add(label6);
            Controls.Add(birthYear);
            Controls.Add(birthDay);
            Controls.Add(birthMonth);
            Controls.Add(label5);
            Controls.Add(lblPass);
            Controls.Add(userCPassword);
            Controls.Add(lblEmail);
            Controls.Add(userCEmail);
            Controls.Add(lblLast);
            Controls.Add(userCLastName);
            Controls.Add(lblFirst);
            Controls.Add(userCFirstName);
            Controls.Add(separator1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(airButton1);
            Controls.Add(richTextBoxEdit7);
            Controls.Add(richTextBoxEdit1);
            Controls.Add(richTextBoxEdit2);
            Controls.Add(richTextBoxEdit3);
            Controls.Add(richTextBoxEdit8);
            Controls.Add(richTextBoxEdit4);
            Controls.Add(richTextBoxEdit6);
            Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel1.ResumeLayout(false);
            contextForms3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.AirButton airButton1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.Separator separator1;
        private Label lblFirst;
        private TextBox userCFirstName;
        private Label lblLast;
        private TextBox userCLastName;
        private Label lblPass;
        private TextBox userCPassword;
        private Label lblEmail;
        private TextBox userCEmail;
        private Label label5;
        private ReaLTaiizor.Controls.AloneComboBox birthMonth;
        private ReaLTaiizor.Controls.AloneComboBox birthDay;
        private ReaLTaiizor.Controls.AloneComboBox birthYear;
        private Label label6;
        private ReaLTaiizor.Controls.HopeRadioButton rbtnFemale;
        private ReaLTaiizor.Controls.HopeRadioButton rbtnMale;
        private ReaLTaiizor.Controls.HopeRadioButton rbtnNotSay;
        private Label label7;
        private ReaLTaiizor.Controls.Button button4;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit7;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit1;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit2;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit3;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit8;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit4;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit6;
        private ContextMenuStrip contextForms3;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem maximizeToolStripMenuItem;
    }
}