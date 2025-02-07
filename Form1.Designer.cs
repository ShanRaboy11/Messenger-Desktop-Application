namespace Messenger_Desktop_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            userPass = new Label();
            userName = new Label();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button6 = new Button();
            richTextBoxEdit1 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            tbxPassword = new TextBox();
            contextShortcut = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            richTextBoxEdit3 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            contextForms1 = new ContextMenuStrip(components);
            closeToolStripMenuItem = new ToolStripMenuItem();
            maxmizeToolStripMenuItem = new ToolStripMenuItem();
            minimizeToolStripMenuItem = new ToolStripMenuItem();
            tbxUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            contextShortcut.SuspendLayout();
            contextForms1.SuspendLayout();
            SuspendLayout();
            // 
            // userPass
            // 
            userPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userPass.AutoSize = true;
            userPass.BackColor = SystemColors.Control;
            userPass.Cursor = Cursors.IBeam;
            userPass.Font = new Font("Helvetica Neue", 10.999999F);
            userPass.ForeColor = Color.DimGray;
            userPass.Location = new Point(40, 219);
            userPass.Name = "userPass";
            userPass.Size = new Size(72, 17);
            userPass.TabIndex = 37;
            userPass.Text = "Password";
            userPass.Click += loginPass;
            // 
            // userName
            // 
            userName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userName.AutoSize = true;
            userName.BackColor = SystemColors.Control;
            userName.Cursor = Cursors.IBeam;
            userName.Font = new Font("Helvetica Neue", 10.999999F);
            userName.ForeColor = Color.DimGray;
            userName.Location = new Point(40, 155);
            userName.Name = "userName";
            userName.Size = new Size(160, 17);
            userName.TabIndex = 36;
            userName.Text = "Mobile number or email";
            userName.Click += loginUser;
            // 
            // cyberButton2
            // 
            cyberButton2.Alpha = 20;
            cyberButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cyberButton2.BackColor = Color.Transparent;
            cyberButton2.Background = true;
            cyberButton2.Background_WidthPen = 4F;
            cyberButton2.BackgroundPen = true;
            cyberButton2.ColorBackground = Color.FromArgb(0, 106, 255);
            cyberButton2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.ColorBackground_Pen = Color.FromArgb(0, 106, 255);
            cyberButton2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.Cursor = Cursors.Hand;
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.White;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Font = new Font("Helvetica Neue", 10.25F);
            cyberButton2.ForeColor = Color.White;
            cyberButton2.Lighting = false;
            cyberButton2.LinearGradient_Background = false;
            cyberButton2.LinearGradientPen = false;
            cyberButton2.Location = new Point(27, 260);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(334, 38);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 34;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "Login";
            cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            cyberButton2.Click += btnLogin;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.White;
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(0, 106, 255);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.Cursor = Cursors.Hand;
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cyberButton1.ForeColor = Color.FromArgb(0, 106, 255);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(28, 361);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(334, 50);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 33;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Create new account";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += createAcc;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(167, 433);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 23);
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica Neue", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(192, 436);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 31;
            label2.Text = "Meta";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica Neue", 10.749999F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(144, 303);
            label1.Name = "label1";
            label1.Size = new Size(125, 17);
            label1.TabIndex = 30;
            label1.Text = "Forgot password?";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 62);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 30);
            panel1.TabIndex = 27;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ControlLight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(28, 2);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(25, 23);
            button4.TabIndex = 40;
            button4.TabStop = false;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Minimize;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ControlLight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(53, 2);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(26, 23);
            button5.TabIndex = 39;
            button5.TabStop = false;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += Maximize;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(27, 5);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(25, 23);
            button3.TabIndex = 4;
            button3.TabStop = false;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(52, 5);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(26, 23);
            button2.TabIndex = 3;
            button2.TabStop = false;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLight;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ControlLight;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(3, 2);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(26, 22);
            button6.TabIndex = 38;
            button6.TabStop = false;
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += Close;
            // 
            // richTextBoxEdit1
            // 
            richTextBoxEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxEdit1.AutoWordSelection = false;
            richTextBoxEdit1.BackColor = Color.White;
            richTextBoxEdit1.BackgroundImageLayout = ImageLayout.Center;
            richTextBoxEdit1.BaseColor = Color.White;
            richTextBoxEdit1.BorderColor = Color.FromArgb(180, 180, 180);
            richTextBoxEdit1.EdgeColor = Color.White;
            richTextBoxEdit1.Enabled = false;
            richTextBoxEdit1.Font = new Font("Helvetica Neue", 10.749999F);
            richTextBoxEdit1.ForeColor = Color.DimGray;
            richTextBoxEdit1.Location = new Point(28, 140);
            richTextBoxEdit1.Margin = new Padding(10, 9, 10, 9);
            richTextBoxEdit1.Name = "richTextBoxEdit1";
            richTextBoxEdit1.ReadOnly = false;
            richTextBoxEdit1.Size = new Size(334, 48);
            richTextBoxEdit1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit1.TabIndex = 39;
            richTextBoxEdit1.TextBackColor = Color.White;
            richTextBoxEdit1.TextBorderStyle = BorderStyle.None;
            richTextBoxEdit1.TextFont = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEdit1.WordWrap = true;
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxPassword.BackColor = SystemColors.Control;
            tbxPassword.BorderStyle = BorderStyle.None;
            tbxPassword.ContextMenuStrip = contextShortcut;
            tbxPassword.Font = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbxPassword.ForeColor = Color.Black;
            tbxPassword.Location = new Point(42, 219);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(306, 17);
            tbxPassword.TabIndex = 40;
            tbxPassword.UseSystemPasswordChar = true;
            tbxPassword.Click += loginPass;
            tbxPassword.KeyDown += tbxPassword_KeyDown;
            // 
            // contextShortcut
            // 
            contextShortcut.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem, cutToolStripMenuItem, selectAllToolStripMenuItem, pasteToolStripMenuItem });
            contextShortcut.Name = "contextMenuStrip1";
            contextShortcut.Size = new Size(167, 92);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Font = new Font("Helvetica Neue", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(166, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += CopyText;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(166, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += CutText;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(166, 22);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += SelectAllText;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(166, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += PasteText;
            // 
            // richTextBoxEdit3
            // 
            richTextBoxEdit3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxEdit3.AutoWordSelection = false;
            richTextBoxEdit3.BackColor = Color.Transparent;
            richTextBoxEdit3.BackgroundImageLayout = ImageLayout.Center;
            richTextBoxEdit3.BaseColor = Color.Transparent;
            richTextBoxEdit3.BorderColor = Color.FromArgb(180, 180, 180);
            richTextBoxEdit3.EdgeColor = Color.White;
            richTextBoxEdit3.Enabled = false;
            richTextBoxEdit3.Font = new Font("Helvetica Neue", 10.749999F);
            richTextBoxEdit3.ForeColor = Color.DimGray;
            richTextBoxEdit3.Location = new Point(28, 203);
            richTextBoxEdit3.Margin = new Padding(10, 9, 10, 9);
            richTextBoxEdit3.Name = "richTextBoxEdit3";
            richTextBoxEdit3.ReadOnly = false;
            richTextBoxEdit3.Size = new Size(334, 48);
            richTextBoxEdit3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit3.TabIndex = 41;
            richTextBoxEdit3.TextBackColor = Color.White;
            richTextBoxEdit3.TextBorderStyle = BorderStyle.None;
            richTextBoxEdit3.TextFont = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEdit3.WordWrap = true;
            // 
            // contextForms1
            // 
            contextForms1.Items.AddRange(new ToolStripItem[] { closeToolStripMenuItem, maxmizeToolStripMenuItem, minimizeToolStripMenuItem });
            contextForms1.Name = "contextMenuStrip1";
            contextForms1.Size = new Size(125, 70);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeToolStripMenuItem.Image = (Image)resources.GetObject("closeToolStripMenuItem.Image");
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(124, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += Close;
            // 
            // maxmizeToolStripMenuItem
            // 
            maxmizeToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maxmizeToolStripMenuItem.Image = Properties.Resources.maximise;
            maxmizeToolStripMenuItem.Name = "maxmizeToolStripMenuItem";
            maxmizeToolStripMenuItem.Size = new Size(124, 22);
            maxmizeToolStripMenuItem.Text = "Maxmize";
            maxmizeToolStripMenuItem.Click += Maximize;
            // 
            // minimizeToolStripMenuItem
            // 
            minimizeToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minimizeToolStripMenuItem.Image = Properties.Resources.window_minimize;
            minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            minimizeToolStripMenuItem.Size = new Size(124, 22);
            minimizeToolStripMenuItem.Text = "Minimize";
            minimizeToolStripMenuItem.Click += Minimize;
            // 
            // tbxUsername
            // 
            tbxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxUsername.BackColor = SystemColors.Control;
            tbxUsername.BorderStyle = BorderStyle.None;
            tbxUsername.ContextMenuStrip = contextShortcut;
            tbxUsername.Font = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbxUsername.ForeColor = Color.Black;
            tbxUsername.Location = new Point(40, 156);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(306, 17);
            tbxUsername.TabIndex = 43;
            tbxUsername.Click += loginUser;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(396, 479);
            ContextMenuStrip = contextForms1;
            Controls.Add(userName);
            Controls.Add(tbxUsername);
            Controls.Add(userPass);
            Controls.Add(tbxPassword);
            Controls.Add(cyberButton2);
            Controls.Add(cyberButton1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(richTextBoxEdit1);
            Controls.Add(richTextBoxEdit3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messenger";
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            contextShortcut.ResumeLayout(false);
            contextForms1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userPass;
        private Label userName;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit1;
        private TextBox tbxPassword;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit3;
        private ContextMenuStrip contextForms1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem maxmizeToolStripMenuItem;
        private ContextMenuStrip contextShortcut;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private TextBox tbxUsername;
    }
}
