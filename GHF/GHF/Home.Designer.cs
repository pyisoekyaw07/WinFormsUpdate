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
            button1 = new Button();
            panel2 = new Panel();
            lbl_username = new Label();
            pictureBox3 = new PictureBox();
            button5 = new Button();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            panel4 = new Panel();
            radioButton1 = new RadioButton();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuStrip2.SuspendLayout();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 28);
            button1.Name = "button1";
            button1.Size = new Size(103, 31);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 47, 81);
            panel2.Controls.Add(lbl_username);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1478, 88);
            panel2.TabIndex = 2;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.ForeColor = Color.White;
            lbl_username.Location = new Point(1198, 33);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(41, 21);
            lbl_username.TabIndex = 13;
            lbl_username.Text = "label4";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1159, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(328, 28);
            button5.Name = "button5";
            button5.Size = new Size(161, 31);
            button5.TabIndex = 11;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(1159, 64);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 7;
            label3.Text = "Ver 1.1.0";
            // 
            // button3
            // 
            button3.Location = new Point(662, 28);
            button3.Name = "button3";
            button3.Size = new Size(161, 31);
            button3.TabIndex = 6;
            button3.Text = "Report";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(495, 28);
            button2.Name = "button2";
            button2.Size = new Size(161, 31);
            button2.TabIndex = 5;
            button2.Text = "Data Master";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(radioButton1);
            panel4.Controls.Add(radioButton2);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1321, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(157, 88);
            panel4.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(20, 60);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 25);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Myanmar";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(102, 60);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 25);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Eng";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(90, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 2;
            label2.Text = "Location";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 31);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "App Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 75);
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
            panel1.Location = new Point(0, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(1478, 50);
            panel1.TabIndex = 3;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.Transparent;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { goldToolStripMenuItem1, whiteGoldToolStripMenuItem1, gemDiamondToolStripMenuItem, cashierToolStripMenuItem });
            menuStrip2.Location = new Point(11, 13);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(284, 29);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // goldToolStripMenuItem1
            // 
            goldToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem });
            goldToolStripMenuItem1.Name = "goldToolStripMenuItem1";
            goldToolStripMenuItem1.Size = new Size(46, 25);
            goldToolStripMenuItem1.Text = "Gold";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(121, 26);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // whiteGoldToolStripMenuItem1
            // 
            whiteGoldToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem1 });
            whiteGoldToolStripMenuItem1.Name = "whiteGoldToolStripMenuItem1";
            whiteGoldToolStripMenuItem1.Size = new Size(75, 25);
            whiteGoldToolStripMenuItem1.Text = "WhiteGold";
            // 
            // registerToolStripMenuItem1
            // 
            registerToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { test1ToolStripMenuItem, test2ToolStripMenuItem });
            registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            registerToolStripMenuItem1.Size = new Size(121, 26);
            registerToolStripMenuItem1.Text = "Register";
            // 
            // test1ToolStripMenuItem
            // 
            test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            test1ToolStripMenuItem.Size = new Size(110, 26);
            test1ToolStripMenuItem.Text = "Test 1";
            // 
            // test2ToolStripMenuItem
            // 
            test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            test2ToolStripMenuItem.Size = new Size(110, 26);
            test2ToolStripMenuItem.Text = "Test 2";
            // 
            // gemDiamondToolStripMenuItem
            // 
            gemDiamondToolStripMenuItem.Name = "gemDiamondToolStripMenuItem";
            gemDiamondToolStripMenuItem.Size = new Size(95, 25);
            gemDiamondToolStripMenuItem.Text = "Gem Diamond";
            // 
            // cashierToolStripMenuItem
            // 
            cashierToolStripMenuItem.Name = "cashierToolStripMenuItem";
            cashierToolStripMenuItem.Size = new Size(60, 25);
            cashierToolStripMenuItem.Text = "Cashier";
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.White;
            mainpanel.Controls.Add(pictureBox2);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 138);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1478, 789);
            mainpanel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1478, 789);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 927);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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

        private Button button1;
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
        private Panel panel4;
        private ToolStripMenuItem cashierToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private Button button2;
        private Button button3;
        private Label label3;
        private Panel mainpanel;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbl_username;
    }
}