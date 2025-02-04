﻿namespace Messenger_Desktop_Application
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
            flpChatMessages = new Panel();
            panel2 = new Panel();
            lblNotFound = new Label();
            lblSearch = new Label();
            tbxSUser = new TextBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            contextOut = new ContextMenuStrip(components);
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pnlUserProfile = new Panel();
            pbProfilePic = new PictureBox();
            contextUser = new ContextMenuStrip(components);
            addFriendToolStripMenuItem = new ToolStripMenuItem();
            messageToolStripMenuItem = new ToolStripMenuItem();
            lblFullName = new Label();
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
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem2 = new ToolStripMenuItem();
            notificationsToolStripMenuItem = new ToolStripMenuItem();
            friendsToolStripMenuItem = new ToolStripMenuItem();
            pbMessagePic = new PictureBox();
            lblUserMessage = new Label();
            separator1 = new ReaLTaiizor.Controls.Separator();
            separator2 = new ReaLTaiizor.Controls.Separator();
            label3 = new Label();
            tbxUserMessage = new TextBox();
            richTextBoxEdit2 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            pbGIF = new PictureBox();
            pbSticker = new PictureBox();
            pbImages = new PictureBox();
            pbPlus = new PictureBox();
            pbLike = new PictureBox();
            flipChatMessages = new FlowLayoutPanel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contextOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlUserProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).BeginInit();
            contextUser.SuspendLayout();
            panel1.SuspendLayout();
            contextForm2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMessagePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGIF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSticker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLike).BeginInit();
            SuspendLayout();
            // 
            // flpChatMessages
            // 
            flpChatMessages.AutoScroll = true;
            flpChatMessages.BorderStyle = BorderStyle.FixedSingle;
            flpChatMessages.Location = new Point(864, -12);
            flpChatMessages.Name = "flpChatMessages";
            flpChatMessages.Size = new Size(290, 774);
            flpChatMessages.TabIndex = 6;
            flpChatMessages.Visible = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblNotFound);
            panel2.Controls.Add(lblSearch);
            panel2.Controls.Add(tbxSUser);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pnlUserProfile);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(richTextBoxEdit1);
            panel2.Location = new Point(-8, -3);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 765);
            panel2.TabIndex = 5;
            // 
            // lblNotFound
            // 
            lblNotFound.AutoSize = true;
            lblNotFound.Font = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNotFound.Location = new Point(97, 381);
            lblNotFound.Name = "lblNotFound";
            lblNotFound.Size = new Size(103, 17);
            lblNotFound.TabIndex = 9;
            lblNotFound.Text = "User not found";
            lblNotFound.Visible = false;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.White;
            lblSearch.Cursor = Cursors.IBeam;
            lblSearch.Font = new Font("Helvetica Neue", 9.999999F);
            lblSearch.ForeColor = Color.DimGray;
            lblSearch.Location = new Point(65, 105);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(120, 16);
            lblSearch.TabIndex = 27;
            lblSearch.Text = "Search Messenger";
            lblSearch.Click += tbxSearch;
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
            tbxSUser.Click += tbxSearch;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica Neue", 13F, FontStyle.Bold);
            label2.Location = new Point(15, 143);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 13;
            label2.Text = "Inbox";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(39, 103);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += searchUser;
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
            logoutToolStripMenuItem1.Click += userLogout;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitToolStripMenuItem1.Image = Properties.Resources.close_window;
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(113, 22);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += Close;
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
            // pnlUserProfile
            // 
            pnlUserProfile.Controls.Add(pbProfilePic);
            pnlUserProfile.Controls.Add(lblFullName);
            pnlUserProfile.Location = new Point(7, 172);
            pnlUserProfile.Name = "pnlUserProfile";
            pnlUserProfile.Size = new Size(294, 75);
            pnlUserProfile.TabIndex = 7;
            // 
            // pbProfilePic
            // 
            pbProfilePic.ContextMenuStrip = contextUser;
            pbProfilePic.Location = new Point(32, 12);
            pbProfilePic.Name = "pbProfilePic";
            pbProfilePic.Size = new Size(57, 50);
            pbProfilePic.SizeMode = PictureBoxSizeMode.CenterImage;
            pbProfilePic.TabIndex = 8;
            pbProfilePic.TabStop = false;
            pbProfilePic.Click += userMessage;
            // 
            // contextUser
            // 
            contextUser.Items.AddRange(new ToolStripItem[] { addFriendToolStripMenuItem, messageToolStripMenuItem });
            contextUser.Name = "contextUser";
            contextUser.Size = new Size(131, 48);
            // 
            // addFriendToolStripMenuItem
            // 
            addFriendToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addFriendToolStripMenuItem.Image = (Image)resources.GetObject("addFriendToolStripMenuItem.Image");
            addFriendToolStripMenuItem.Name = "addFriendToolStripMenuItem";
            addFriendToolStripMenuItem.Size = new Size(130, 22);
            addFriendToolStripMenuItem.Text = "Add friend";
            // 
            // messageToolStripMenuItem
            // 
            messageToolStripMenuItem.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            messageToolStripMenuItem.Image = (Image)resources.GetObject("messageToolStripMenuItem.Image");
            messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            messageToolStripMenuItem.Size = new Size(130, 22);
            messageToolStripMenuItem.Text = "Message";
            messageToolStripMenuItem.Click += userMessage;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.ContextMenuStrip = contextUser;
            lblFullName.Font = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFullName.Location = new Point(105, 27);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(0, 17);
            lblFullName.TabIndex = 0;
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
            closeToolStripMenuItem1.Click += Close;
            // 
            // maximizeToolStripMenuItem1
            // 
            maximizeToolStripMenuItem1.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maximizeToolStripMenuItem1.Image = Properties.Resources.maximise;
            maximizeToolStripMenuItem1.Name = "maximizeToolStripMenuItem1";
            maximizeToolStripMenuItem1.Size = new Size(126, 22);
            maximizeToolStripMenuItem1.Text = "Maximize";
            maximizeToolStripMenuItem1.Click += Maximize;
            // 
            // minimizeToolStripMenuItem1
            // 
            minimizeToolStripMenuItem1.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minimizeToolStripMenuItem1.Image = Properties.Resources.window_minimize;
            minimizeToolStripMenuItem1.Name = "minimizeToolStripMenuItem1";
            minimizeToolStripMenuItem1.Size = new Size(126, 22);
            minimizeToolStripMenuItem1.Text = "Minimize";
            minimizeToolStripMenuItem1.Click += Minimize;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, notificationsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 615);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1148, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem2 });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(53, 20);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // logoutToolStripMenuItem2
            // 
            logoutToolStripMenuItem2.Name = "logoutToolStripMenuItem2";
            logoutToolStripMenuItem2.Size = new Size(117, 22);
            logoutToolStripMenuItem2.Text = "Logout";
            logoutToolStripMenuItem2.Click += userLogout;
            // 
            // notificationsToolStripMenuItem
            // 
            notificationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { friendsToolStripMenuItem });
            notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            notificationsToolStripMenuItem.Size = new Size(87, 20);
            notificationsToolStripMenuItem.Text = "Notifications";
            // 
            // friendsToolStripMenuItem
            // 
            friendsToolStripMenuItem.Name = "friendsToolStripMenuItem";
            friendsToolStripMenuItem.Size = new Size(118, 22);
            friendsToolStripMenuItem.Text = "Friends";
            // 
            // pbMessagePic
            // 
            pbMessagePic.ContextMenuStrip = contextUser;
            pbMessagePic.Location = new Point(308, 44);
            pbMessagePic.Name = "pbMessagePic";
            pbMessagePic.Size = new Size(57, 50);
            pbMessagePic.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMessagePic.TabIndex = 9;
            pbMessagePic.TabStop = false;
            // 
            // lblUserMessage
            // 
            lblUserMessage.AutoSize = true;
            lblUserMessage.Font = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUserMessage.Location = new Point(377, 58);
            lblUserMessage.Name = "lblUserMessage";
            lblUserMessage.Size = new Size(0, 17);
            lblUserMessage.TabIndex = 9;
            // 
            // separator1
            // 
            separator1.LineColor = Color.Gray;
            separator1.Location = new Point(286, 101);
            separator1.Name = "separator1";
            separator1.Size = new Size(581, 10);
            separator1.TabIndex = 10;
            separator1.Text = "separator1";
            separator1.Visible = false;
            // 
            // separator2
            // 
            separator2.LineColor = Color.Gray;
            separator2.Location = new Point(286, 561);
            separator2.Name = "separator2";
            separator2.Size = new Size(581, 10);
            separator2.TabIndex = 11;
            separator2.Text = "separator2";
            separator2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Cursor = Cursors.IBeam;
            label3.Font = new Font("Helvetica Neue", 9.999999F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(420, 584);
            label3.Name = "label3";
            label3.Size = new Size(120, 16);
            label3.TabIndex = 45;
            label3.Text = "Search Messenger";
            label3.Visible = false;
            label3.Click += lblMessage;
            // 
            // tbxUserMessage
            // 
            tbxUserMessage.BackColor = Color.White;
            tbxUserMessage.BorderStyle = BorderStyle.None;
            tbxUserMessage.Font = new Font("Helvetica Neue", 11F);
            tbxUserMessage.ForeColor = Color.Black;
            tbxUserMessage.Location = new Point(422, 583);
            tbxUserMessage.Name = "tbxUserMessage";
            tbxUserMessage.Size = new Size(386, 17);
            tbxUserMessage.TabIndex = 46;
            tbxUserMessage.Visible = false;
            tbxUserMessage.Click += lblMessage;
            // 
            // richTextBoxEdit2
            // 
            richTextBoxEdit2.AutoWordSelection = false;
            richTextBoxEdit2.BackColor = Color.Transparent;
            richTextBoxEdit2.BackgroundImageLayout = ImageLayout.Center;
            richTextBoxEdit2.BaseColor = Color.Transparent;
            richTextBoxEdit2.BorderColor = Color.FromArgb(180, 180, 180);
            richTextBoxEdit2.EdgeColor = Color.White;
            richTextBoxEdit2.Font = new Font("Helvetica Neue", 10.749999F);
            richTextBoxEdit2.ForeColor = Color.DimGray;
            richTextBoxEdit2.Location = new Point(415, 577);
            richTextBoxEdit2.Margin = new Padding(10, 9, 10, 9);
            richTextBoxEdit2.Name = "richTextBoxEdit2";
            richTextBoxEdit2.ReadOnly = false;
            richTextBoxEdit2.Size = new Size(407, 28);
            richTextBoxEdit2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit2.TabIndex = 44;
            richTextBoxEdit2.TextBackColor = Color.White;
            richTextBoxEdit2.TextBorderStyle = BorderStyle.None;
            richTextBoxEdit2.TextFont = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxEdit2.Visible = false;
            richTextBoxEdit2.WordWrap = true;
            // 
            // pbGIF
            // 
            pbGIF.Cursor = Cursors.Hand;
            pbGIF.Image = (Image)resources.GetObject("pbGIF.Image");
            pbGIF.Location = new Point(382, 579);
            pbGIF.Name = "pbGIF";
            pbGIF.Size = new Size(26, 24);
            pbGIF.TabIndex = 47;
            pbGIF.TabStop = false;
            pbGIF.Visible = false;
            // 
            // pbSticker
            // 
            pbSticker.Cursor = Cursors.Hand;
            pbSticker.Image = (Image)resources.GetObject("pbSticker.Image");
            pbSticker.Location = new Point(353, 579);
            pbSticker.Name = "pbSticker";
            pbSticker.Size = new Size(26, 24);
            pbSticker.TabIndex = 48;
            pbSticker.TabStop = false;
            pbSticker.Visible = false;
            // 
            // pbImages
            // 
            pbImages.Cursor = Cursors.Hand;
            pbImages.Image = (Image)resources.GetObject("pbImages.Image");
            pbImages.Location = new Point(324, 579);
            pbImages.Name = "pbImages";
            pbImages.Size = new Size(26, 24);
            pbImages.TabIndex = 49;
            pbImages.TabStop = false;
            pbImages.Visible = false;
            // 
            // pbPlus
            // 
            pbPlus.Cursor = Cursors.Hand;
            pbPlus.Image = (Image)resources.GetObject("pbPlus.Image");
            pbPlus.Location = new Point(298, 580);
            pbPlus.Name = "pbPlus";
            pbPlus.Size = new Size(22, 21);
            pbPlus.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlus.TabIndex = 50;
            pbPlus.TabStop = false;
            pbPlus.Visible = false;
            // 
            // pbLike
            // 
            pbLike.Cursor = Cursors.Hand;
            pbLike.Image = Properties.Resources.like__1_;
            pbLike.Location = new Point(830, 579);
            pbLike.Name = "pbLike";
            pbLike.Size = new Size(26, 24);
            pbLike.TabIndex = 51;
            pbLike.TabStop = false;
            pbLike.Visible = false;
            pbLike.Click += btnSendMessage_Click;
            // 
            // flipChatMessages
            // 
            flipChatMessages.AutoScroll = true;
            flipChatMessages.FlowDirection = FlowDirection.TopDown;
            flipChatMessages.Location = new Point(300, 116);
            flipChatMessages.Name = "flipChatMessages";
            flipChatMessages.Size = new Size(558, 443);
            flipChatMessages.TabIndex = 52;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 639);
            ContextMenuStrip = contextForm2;
            Controls.Add(flipChatMessages);
            Controls.Add(pbLike);
            Controls.Add(pbPlus);
            Controls.Add(pbImages);
            Controls.Add(pbSticker);
            Controls.Add(pbGIF);
            Controls.Add(label3);
            Controls.Add(lblUserMessage);
            Controls.Add(tbxUserMessage);
            Controls.Add(pbMessagePic);
            Controls.Add(richTextBoxEdit2);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(flpChatMessages);
            Controls.Add(separator1);
            Controls.Add(separator2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messenger";
            MouseDown += Form2_MouseDown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contextOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlUserProfile.ResumeLayout(false);
            pnlUserProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).EndInit();
            contextUser.ResumeLayout(false);
            panel1.ResumeLayout(false);
            contextForm2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMessagePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGIF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSticker).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImages).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPlus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLike).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel flpChatMessages;
        private Panel panel2;
        private Label lblSearch;
        public Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel pnlUserProfile;
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private PictureBox pbProfilePic;
        private Label lblFullName;
        private Label lblNotFound;
        private ContextMenuStrip contextUser;
        private ToolStripMenuItem addFriendToolStripMenuItem;
        private ToolStripMenuItem messageToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem2;
        private ToolStripMenuItem notificationsToolStripMenuItem;
        private ToolStripMenuItem friendsToolStripMenuItem;
        private Panel panel3;
        private PictureBox pbSticker;
        private PictureBox pbMessagePic;
        private Label lblUserMessage;
        private ReaLTaiizor.Controls.Separator separator1;
        private ReaLTaiizor.Controls.Separator separator2;
        private Label label3;
        private TextBox tbxUserMessage;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit2;
        private PictureBox pbGIF;
        private PictureBox pbImages;
        private PictureBox pbPlus;
        private PictureBox pbLike;
        private FlowLayoutPanel flipChatMessages;
        //private ContextMenuStrip contextForms2;
    }
}