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
            pan_rep = new Panel();
            ico_rep = new FontAwesome.Sharp.IconPictureBox();
            lbl_report = new Label();
            panel6 = new Panel();
            pan_master = new Panel();
            ico_master = new FontAwesome.Sharp.IconPictureBox();
            lbl_master = new Label();
            pan_line_master = new Panel();
            pan_line_home = new Panel();
            radioButton1 = new RadioButton();
            pan_home = new Panel();
            ico_home = new FontAwesome.Sharp.IconPictureBox();
            lbl_Home = new Label();
            panel3 = new Panel();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
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
            reportToolStripMenuItem = new ToolStripMenuItem();
            closingStockToolStripMenuItem = new ToolStripMenuItem();
            mainpanel = new Panel();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            pan_rep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ico_rep).BeginInit();
            pan_master.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ico_master).BeginInit();
            pan_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ico_home).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
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
            panel2.Controls.Add(pan_rep);
            panel2.Controls.Add(pan_master);
            panel2.Controls.Add(pan_line_home);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(pan_home);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1443, 80);
            panel2.TabIndex = 2;
            // 
            // pan_rep
            // 
            pan_rep.Controls.Add(ico_rep);
            pan_rep.Controls.Add(lbl_report);
            pan_rep.Controls.Add(panel6);
            pan_rep.Location = new Point(524, 12);
            pan_rep.Name = "pan_rep";
            pan_rep.Size = new Size(122, 54);
            pan_rep.TabIndex = 31;
            // 
            // ico_rep
            // 
            ico_rep.BackColor = Color.FromArgb(24, 47, 81);
            ico_rep.ForeColor = Color.FromArgb(167, 167, 167);
            ico_rep.IconChar = FontAwesome.Sharp.IconChar.File;
            ico_rep.IconColor = Color.FromArgb(167, 167, 167);
            ico_rep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ico_rep.IconSize = 28;
            ico_rep.Location = new Point(12, 9);
            ico_rep.Name = "ico_rep";
            ico_rep.Size = new Size(28, 29);
            ico_rep.TabIndex = 28;
            ico_rep.TabStop = false;
            // 
            // lbl_report
            // 
            lbl_report.AutoSize = true;
            lbl_report.BackColor = Color.Transparent;
            lbl_report.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_report.ForeColor = Color.FromArgb(167, 167, 167);
            lbl_report.Location = new Point(42, 9);
            lbl_report.Name = "lbl_report";
            lbl_report.Size = new Size(47, 22);
            lbl_report.TabIndex = 21;
            lbl_report.Text = "Report";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(167, 167, 167);
            panel6.Location = new Point(8, 45);
            panel6.Name = "panel6";
            panel6.Size = new Size(110, 3);
            panel6.TabIndex = 24;
            panel6.Visible = false;
            // 
            // pan_master
            // 
            pan_master.Controls.Add(ico_master);
            pan_master.Controls.Add(lbl_master);
            pan_master.Controls.Add(pan_line_master);
            pan_master.Location = new Point(399, 12);
            pan_master.Name = "pan_master";
            pan_master.Size = new Size(118, 54);
            pan_master.TabIndex = 30;
            pan_master.Click += pan_master_Click;
            // 
            // ico_master
            // 
            ico_master.BackColor = Color.FromArgb(24, 47, 81);
            ico_master.ForeColor = Color.FromArgb(167, 167, 167);
            ico_master.IconChar = FontAwesome.Sharp.IconChar.Database;
            ico_master.IconColor = Color.FromArgb(167, 167, 167);
            ico_master.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ico_master.IconSize = 27;
            ico_master.Location = new Point(8, 9);
            ico_master.Name = "ico_master";
            ico_master.Size = new Size(35, 27);
            ico_master.TabIndex = 27;
            ico_master.TabStop = false;
            // 
            // lbl_master
            // 
            lbl_master.AutoSize = true;
            lbl_master.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_master.ForeColor = Color.FromArgb(167, 167, 167);
            lbl_master.Location = new Point(39, 10);
            lbl_master.Name = "lbl_master";
            lbl_master.Size = new Size(76, 22);
            lbl_master.TabIndex = 20;
            lbl_master.Text = "Data Master";
            lbl_master.Click += lbl_master_Click;
            // 
            // pan_line_master
            // 
            pan_line_master.BackColor = Color.FromArgb(167, 167, 167);
            pan_line_master.Location = new Point(8, 44);
            pan_line_master.Name = "pan_line_master";
            pan_line_master.Size = new Size(110, 3);
            pan_line_master.TabIndex = 23;
            pan_line_master.Visible = false;
            // 
            // pan_line_home
            // 
            pan_line_home.BackColor = Color.White;
            pan_line_home.ForeColor = Color.White;
            pan_line_home.Location = new Point(290, 56);
            pan_line_home.Name = "pan_line_home";
            pan_line_home.Size = new Size(104, 3);
            pan_line_home.TabIndex = 24;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.White;
            radioButton1.Image = (Image)resources.GetObject("radioButton1.Image");
            radioButton1.Location = new Point(1157, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(38, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // pan_home
            // 
            pan_home.Controls.Add(ico_home);
            pan_home.Controls.Add(lbl_Home);
            pan_home.Location = new Point(290, 12);
            pan_home.Name = "pan_home";
            pan_home.Size = new Size(103, 54);
            pan_home.TabIndex = 29;
            pan_home.Click += pan_home_Click;
            // 
            // ico_home
            // 
            ico_home.BackColor = Color.FromArgb(24, 47, 81);
            ico_home.ForeColor = SystemColors.ButtonHighlight;
            ico_home.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            ico_home.IconColor = SystemColors.ButtonHighlight;
            ico_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ico_home.IconSize = 28;
            ico_home.Location = new Point(13, 9);
            ico_home.Name = "ico_home";
            ico_home.Size = new Size(32, 28);
            ico_home.TabIndex = 26;
            ico_home.TabStop = false;
            // 
            // lbl_Home
            // 
            lbl_Home.AutoSize = true;
            lbl_Home.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Home.ForeColor = Color.White;
            lbl_Home.Location = new Point(48, 10);
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
            panel3.Controls.Add(iconPictureBox5);
            panel3.Controls.Add(iconPictureBox1);
            panel3.Controls.Add(lbl_username);
            panel3.Dock = DockStyle.Right;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(1242, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 80);
            panel3.TabIndex = 16;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.FromArgb(24, 47, 81);
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox5.IconColor = Color.White;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 27;
            iconPictureBox5.Location = new Point(73, 3);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(28, 27);
            iconPictureBox5.TabIndex = 29;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(24, 47, 81);
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 31;
            iconPictureBox1.Location = new Point(152, 16);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 31);
            iconPictureBox1.TabIndex = 17;
            iconPictureBox1.TabStop = false;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.White;
            lbl_username.Location = new Point(46, 33);
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
            radioButton2.Location = new Point(1107, 24);
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
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1443, 41);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.Transparent;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { goldToolStripMenuItem1, whiteGoldToolStripMenuItem1, gemDiamondToolStripMenuItem, cashierToolStripMenuItem, reportToolStripMenuItem });
            menuStrip2.Location = new Point(8, 2);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(354, 30);
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
            registerToolStripMenuItem.Size = new Size(171, 26);
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
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closingStockToolStripMenuItem });
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(59, 26);
            reportToolStripMenuItem.Text = "Report";
            // 
            // closingStockToolStripMenuItem
            // 
            closingStockToolStripMenuItem.Name = "closingStockToolStripMenuItem";
            closingStockToolStripMenuItem.Size = new Size(153, 26);
            closingStockToolStripMenuItem.Text = "Closing Stock";
            closingStockToolStripMenuItem.Click += closingStockToolStripMenuItem_Click;
            // 
            // mainpanel
            // 
            mainpanel.AutoScroll = true;
            mainpanel.AutoSize = true;
            mainpanel.BackColor = Color.White;
            mainpanel.Controls.Add(pictureBox2);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 121);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1443, 618);
            mainpanel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(180, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(472, 310);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1443, 739);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form2";
            WindowState = FormWindowState.Maximized;
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pan_rep.ResumeLayout(false);
            pan_rep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ico_rep).EndInit();
            pan_master.ResumeLayout(false);
            pan_master.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ico_master).EndInit();
            pan_home.ResumeLayout(false);
            pan_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ico_home).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lbl_username;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lbl_Home;
        private Label lbl_report;
        private Label lbl_master;
        private Panel panel6;
        private Panel pan_line_home;
        private Panel pan_line_master;
        private FontAwesome.Sharp.IconPictureBox ico_home;
        private FontAwesome.Sharp.IconPictureBox ico_rep;
        private FontAwesome.Sharp.IconPictureBox ico_master;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Panel pan_home;
        private Panel pan_rep;
        private Panel pan_master;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem closingStockToolStripMenuItem;
    }
}