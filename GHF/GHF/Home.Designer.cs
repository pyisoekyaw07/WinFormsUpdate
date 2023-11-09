namespace GHF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel2 = new Panel();
            panel6 = new Panel();
            pan_line_home = new Panel();
            pan_line_master = new Panel();
            lbl_report = new Label();
            lbl_master = new Label();
            lbl_Home = new Label();
            panel3 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            pictureBox3 = new PictureBox();
            radioButton1 = new RadioButton();
            lbl_username = new Label();
            radioButton2 = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            menuStrip2 = new MenuStrip();
            goldToolStripMenuItem1 = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            whiteGoldToolStripMenuItem1 = new ToolStripMenuItem();
            registerToolStripMenuItem1 = new ToolStripMenuItem();
            test1ToolStripMenuItem = new ToolStripMenuItem();
            test2ToolStripMenuItem = new ToolStripMenuItem();
            gemDiamondToolStripMenuItem = new ToolStripMenuItem();
            cashierToolStripMenuItem = new ToolStripMenuItem();
            mainpanel = new Panel();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuStrip2.SuspendLayout();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 47, 81);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(pan_line_home);
            panel2.Controls.Add(pan_line_master);
            panel2.Controls.Add(lbl_report);
            panel2.Controls.Add(lbl_master);
            panel2.Controls.Add(lbl_Home);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1478, 63);
            panel2.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(167, 167, 167);
            panel6.Location = new Point(535, 47);
            panel6.Name = "panel6";
            panel6.Size = new Size(80, 5);
            panel6.TabIndex = 24;
            panel6.Visible = false;
            // 
            // pan_line_home
            // 
            pan_line_home.BackColor = Color.White;
            pan_line_home.ForeColor = Color.White;
            pan_line_home.Location = new Point(359, 47);
            pan_line_home.Name = "pan_line_home";
            pan_line_home.Size = new Size(80, 5);
            pan_line_home.TabIndex = 24;
            // 
            // pan_line_master
            // 
            pan_line_master.BackColor = Color.FromArgb(167, 167, 167);
            pan_line_master.Location = new Point(447, 47);
            pan_line_master.Name = "pan_line_master";
            pan_line_master.Size = new Size(80, 5);
            pan_line_master.TabIndex = 23;
            pan_line_master.Visible = false;
            // 
            // lbl_report
            // 
            lbl_report.AutoSize = true;
            lbl_report.BackColor = Color.Transparent;
            lbl_report.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_report.ForeColor = Color.FromArgb(167, 167, 167);
            lbl_report.Location = new Point(549, 23);
            lbl_report.Name = "lbl_report";
            lbl_report.Size = new Size(47, 22);
            lbl_report.TabIndex = 21;
            lbl_report.Text = "Report";
            // 
            // lbl_master
            // 
            lbl_master.AutoSize = true;
            lbl_master.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_master.ForeColor = Color.FromArgb(167, 167, 167);
            lbl_master.Location = new Point(449, 23);
            lbl_master.Name = "lbl_master";
            lbl_master.Size = new Size(76, 22);
            lbl_master.TabIndex = 20;
            lbl_master.Text = "Data Master";
            lbl_master.Click += lbl_master_Click;
            // 
            // lbl_Home
            // 
            lbl_Home.AutoSize = true;
            lbl_Home.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Home.ForeColor = Color.White;
            lbl_Home.Location = new Point(379, 23);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(42, 22);
            lbl_Home.TabIndex = 0;
            lbl_Home.Text = "Home";
            lbl_Home.Click += lbl_Home_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(iconPictureBox1);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(radioButton1);
            panel3.Controls.Add(lbl_username);
            panel3.Controls.Add(radioButton2);
            panel3.Dock = DockStyle.Right;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(1186, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(292, 63);
            panel3.TabIndex = 16;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(24, 47, 81);
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(255, 16);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 17;
            iconPictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(210, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.White;
            radioButton1.Image = (Image)resources.GetObject("radioButton1.Image");
            radioButton1.Location = new Point(76, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(38, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.White;
            lbl_username.Location = new Point(124, 23);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(84, 22);
            lbl_username.TabIndex = 13;
            lbl_username.Text = "Pyi Soe Kyaw";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.White;
            radioButton2.Image = (Image)resources.GetObject("radioButton2.Image");
            radioButton2.ImageAlign = ContentAlignment.MiddleRight;
            radioButton2.Location = new Point(28, 23);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(38, 24);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(141, 30);
            label2.Name = "label2";
            label2.Size = new Size(30, 17);
            label2.TabIndex = 2;
            label2.Text = "pos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pyidaungsu", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 4);
            label1.Name = "label1";
            label1.Size = new Size(92, 63);
            label1.TabIndex = 0;
            label1.Text = "GHF";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(menuStrip2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(1478, 33);
            panel1.TabIndex = 3;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.Transparent;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip2.Items.AddRange(new ToolStripItem[] { goldToolStripMenuItem1, whiteGoldToolStripMenuItem1, gemDiamondToolStripMenuItem, cashierToolStripMenuItem });
            menuStrip2.Location = new Point(8, 2);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(295, 30);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // goldToolStripMenuItem1
            // 
            goldToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem });
            goldToolStripMenuItem1.Name = "goldToolStripMenuItem1";
            goldToolStripMenuItem1.Size = new Size(47, 26);
            goldToolStripMenuItem1.Text = "Gold";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Image = (Image)resources.GetObject("registerToolStripMenuItem.Image");
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            registerToolStripMenuItem.Size = new Size(167, 26);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // whiteGoldToolStripMenuItem1
            // 
            whiteGoldToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem1 });
            whiteGoldToolStripMenuItem1.Name = "whiteGoldToolStripMenuItem1";
            whiteGoldToolStripMenuItem1.Size = new Size(77, 26);
            whiteGoldToolStripMenuItem1.Text = "WhiteGold";
            // 
            // registerToolStripMenuItem1
            // 
            registerToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { test1ToolStripMenuItem, test2ToolStripMenuItem });
            registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            registerToolStripMenuItem1.Size = new Size(124, 26);
            registerToolStripMenuItem1.Text = "Register";
            // 
            // test1ToolStripMenuItem
            // 
            test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            test1ToolStripMenuItem.Size = new Size(112, 26);
            test1ToolStripMenuItem.Text = "Test 1";
            // 
            // test2ToolStripMenuItem
            // 
            test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            test2ToolStripMenuItem.Size = new Size(112, 26);
            test2ToolStripMenuItem.Text = "Test 2";
            // 
            // gemDiamondToolStripMenuItem
            // 
            gemDiamondToolStripMenuItem.Name = "gemDiamondToolStripMenuItem";
            gemDiamondToolStripMenuItem.Size = new Size(101, 26);
            gemDiamondToolStripMenuItem.Text = "Gem Diamond";
            // 
            // cashierToolStripMenuItem
            // 
            cashierToolStripMenuItem.Name = "cashierToolStripMenuItem";
            cashierToolStripMenuItem.Size = new Size(62, 26);
            cashierToolStripMenuItem.Text = "Cashier";
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.White;
            mainpanel.Controls.Add(pictureBox2);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 96);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1478, 643);
            mainpanel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1478, 643);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 739);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem goldToolStripMenuItem1;
        private ToolStripMenuItem whiteGoldToolStripMenuItem1;
        private ToolStripMenuItem registerToolStripMenuItem1;
        private ToolStripMenuItem test1ToolStripMenuItem;
        private ToolStripMenuItem test2ToolStripMenuItem;
        private ToolStripMenuItem gemDiamondToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem cashierToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private Panel mainpanel;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbl_username;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lbl_Home;
        private Label lbl_report;
        private Label lbl_master;
        private Panel panel6;
        private Panel pan_line_home;
        private Panel pan_line_master;
    }
}