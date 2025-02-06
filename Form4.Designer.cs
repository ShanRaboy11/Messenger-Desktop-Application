namespace Messenger_Desktop_Application
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            UserName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(416, 26);
            panel1.TabIndex = 28;
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
            button4.Size = new Size(25, 20);
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
            button5.Size = new Size(26, 20);
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
            button3.Location = new Point(27, 4);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(25, 20);
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
            button2.Location = new Point(52, 4);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(26, 20);
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
            button6.Size = new Size(26, 19);
            button6.TabIndex = 38;
            button6.TabStop = false;
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += Close;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bigmale_profile;
            pictureBox1.Location = new Point(158, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Helvetica Neue", 17.75F, FontStyle.Bold);
            UserName.Location = new Point(84, 132);
            UserName.Name = "UserName";
            UserName.Size = new Size(249, 27);
            UserName.TabIndex = 30;
            UserName.Text = "Shan Michael Raboy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica Neue", 11.9999981F);
            label1.Location = new Point(28, 193);
            label1.Name = "label1";
            label1.Size = new Size(58, 18);
            label1.TabIndex = 31;
            label1.Text = "E-mail: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica Neue", 11.9999981F);
            label2.Location = new Point(27, 231);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 32;
            label2.Text = "Gender: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica Neue", 11.9999981F);
            label3.Location = new Point(27, 269);
            label3.Name = "label3";
            label3.Size = new Size(79, 18);
            label3.TabIndex = 33;
            label3.Text = "Birthdate: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica Neue", 11.9999981F);
            label4.Location = new Point(28, 309);
            label4.Name = "label4";
            label4.Size = new Size(85, 18);
            label4.TabIndex = 34;
            label4.Text = "Password: ";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(166, 478);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 23);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica Neue", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(191, 481);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 35;
            label5.Text = "Meta";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 525);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UserName);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Helvetica Neue", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button6;
        private PictureBox pictureBox1;
        private Label UserName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
    }
}