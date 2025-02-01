namespace Messenger_Desktop_Application
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel5 = new Panel();
            panel2 = new Panel();
            lblSearch = new Label();
            tbxSUser = new TextBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            contextOut = new ContextMenuStrip(components);
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            richTextBoxEdit1 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            closeToolStripMenuItem = new ToolStripMenuItem();
            maximizeToolStripMenuItem = new ToolStripMenuItem();
            minimizeToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            contextForm2 = new ContextMenuStrip(components);
            closeToolStripMenuItem1 = new ToolStripMenuItem();
            maximizeToolStripMenuItem1 = new ToolStripMenuItem();
            minimizeToolStripMenuItem1 = new ToolStripMenuItem();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contextOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            contextForm2.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(864, -12);
            panel5.Name = "panel5";
            panel5.Size = new Size(290, 774);
            panel5.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblSearch);
            panel2.Controls.Add(tbxSUser);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(richTextBoxEdit1);
            panel2.Location = new Point(-8, -3);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 765);
            panel2.TabIndex = 5;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.White;
            lblSearch.Font = new Font("Helvetica Neue", 9.999999F);
            lblSearch.ForeColor = Color.DimGray;
            lblSearch.Location = new Point(65, 105);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(120, 16);
            lblSearch.TabIndex = 27;
            lblSearch.Text = "Search Messenger";
            // 
            // tbxSUser
            // 
            tbxSUser.BackColor = Color.White;
            tbxSUser.BorderStyle = BorderStyle.None;
            tbxSUser.Font = new Font("Helvetica Neue", 11F);
            tbxSUser.ForeColor = Color.Black;
            tbxSUser.Location = new Point(69, 105);
            tbxSUser.Name = "tbxSUser";
            tbxSUser.Size = new Size(206, 17);
            tbxSUser.TabIndex = 42;
            tbxSUser.Click += searchUser;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica Neue", 13F, FontStyle.Bold);
            label2.Location = new Point(29, 143);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 13;
            label2.Text = "Inbox";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(39, 103);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ContextMenuStrip = contextOut;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(208, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // contextOut
            // 
            contextOut.Items.AddRange(new ToolStripItem[] { logoutToolStripMenuItem1, exitToolStripMenuItem1 });
            contextOut.Name = "contextOut";
            contextOut.Size = new Size(114, 48);
            // 
            // logoutToolStripMenuItem1
            // 
            logoutToolStripMenuItem1.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logoutToolStripMenuItem1.Image = Properties.Resources._3005766_account_door_exit_logout_icon;
            logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            logoutToolStripMenuItem1.Size = new Size(113, 22);
            logoutToolStripMenuItem1.Text = "Logout";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitToolStripMenuItem1.Image = Properties.Resources.close_window;
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(113, 22);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(254, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(13, 172);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 75);
            panel3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica Neue", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(19, 46);
            label1.Name = "label1";
            label1.Size = new Size(80, 27);
            label1.TabIndex = 6;
            label1.Text = "Chats";
            // 
            // richTextBoxEdit1
            // 
            richTextBoxEdit1.AutoWordSelection = false;
            richTextBoxEdit1.BackColor = Color.Transparent;
            richTextBoxEdit1.BackgroundImageLayout = ImageLayout.Center;
            richTextBoxEdit1.BaseColor = Color.Transparent;
            richTextBoxEdit1.BorderColor = Color.FromArgb(180, 180, 180);
            richTextBoxEdit1.EdgeColor = Color.White;
            richTextBoxEdit1.Font = new Font("Helvetica Neue", 10.749999F);
            richTextBoxEdit1.ForeColor = Color.DimGray;
            richTextBoxEdit1.Location = new Point(25, 99);
            richTextBoxEdit1.Margin = new Padding(10, 9, 10, 9);
            richTextBoxEdit1.Name = "richTextBoxEdit1";
            richTextBoxEdit1.ReadOnly = false;
            richTextBoxEdit1.Size = new Size(261, 28);
            richTextBoxEdit1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit1.TabIndex = 15;
            richTextBoxEdit1.TextBackColor = Color.White;
            richTextBoxEdit1.TextBorderStyle = BorderStyle.None;
            richTextBoxEdit1.TextFont = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEdit1.WordWrap = true;
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
            panel1.Size = new Size(1148, 32);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(2, 3);
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
            button2.Location = new Point(52, 2);
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
            button3.Location = new Point(27, 2);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(25, 26);
            button3.TabIndex = 8;
            button3.TabStop = false;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Minimize;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeToolStripMenuItem.Image = Properties.Resources.close_window;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // maximizeToolStripMenuItem
            // 
            maximizeToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maximizeToolStripMenuItem.Image = Properties.Resources.maximise;
            maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            maximizeToolStripMenuItem.Size = new Size(180, 22);
            maximizeToolStripMenuItem.Text = "Maximize";
            // 
            // minimizeToolStripMenuItem
            // 
            minimizeToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minimizeToolStripMenuItem.Image = Properties.Resources.window_minimize;
            minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            minimizeToolStripMenuItem.Size = new Size(180, 22);
            minimizeToolStripMenuItem.Text = "Minimize";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Font = new Font("Helvetica Neue", 9.999999F);
            logoutToolStripMenuItem.Image = Properties.Resources._3005766_account_door_exit_logout_icon;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(118, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitToolStripMenuItem.Image = Properties.Resources.close_window;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(118, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // contextForm2
            // 
            contextForm2.Items.AddRange(new ToolStripItem[] { closeToolStripMenuItem1, maximizeToolStripMenuItem1, minimizeToolStripMenuItem1 });
            contextForm2.Name = "contextMenuStrip1";
            contextForm2.Size = new Size(127, 70);
            // 
            // closeToolStripMenuItem1
            // 
            closeToolStripMenuItem1.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeToolStripMenuItem1.Image = Properties.Resources.close_window;
            closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            closeToolStripMenuItem1.Size = new Size(126, 22);
            closeToolStripMenuItem1.Text = "Close";
            // 
            // maximizeToolStripMenuItem1
            // 
            maximizeToolStripMenuItem1.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maximizeToolStripMenuItem1.Image = Properties.Resources.maximise;
            maximizeToolStripMenuItem1.Name = "maximizeToolStripMenuItem1";
            maximizeToolStripMenuItem1.Size = new Size(126, 22);
            maximizeToolStripMenuItem1.Text = "Maximize";
            // 
            // minimizeToolStripMenuItem1
            // 
            minimizeToolStripMenuItem1.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minimizeToolStripMenuItem1.Image = Properties.Resources.window_minimize;
            minimizeToolStripMenuItem1.Name = "minimizeToolStripMenuItem1";
            minimizeToolStripMenuItem1.Size = new Size(126, 22);
            minimizeToolStripMenuItem1.Text = "Minimize";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 747);
            ContextMenuStrip = contextForm2;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            MouseDown += Form2_MouseDown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contextOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            contextForm2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel2;
        private Label lblSearch;
        public Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private ContextMenuStrip contextForms2;
        private ToolStripMenuItem maximizeToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem maxmizeToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ContextMenuStrip contextForm2;
        private ToolStripMenuItem closeToolStripMenuItem1;
        private ToolStripMenuItem maximizeToolStripMenuItem1;
        private ToolStripMenuItem minimizeToolStripMenuItem1;
        private ContextMenuStrip contextOut;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private TextBox tbxSUser;
        //private ContextMenuStrip contextForms2;
    }
}