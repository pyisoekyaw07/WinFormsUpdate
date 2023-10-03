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
            button3 = new Button();
            button2 = new Button();
            panel4 = new Panel();
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
            gold1 = new Gold();
            master1 = new Master();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 28);
            button1.Name = "button1";
            button1.Size = new Size(103, 35);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 47, 81);
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
            // button3
            // 
            button3.Location = new Point(523, 57);
            button3.Name = "button3";
            button3.Size = new Size(161, 31);
            button3.TabIndex = 6;
            button3.Text = "Report";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(356, 57);
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
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1321, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(157, 88);
            panel4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(87, 60);
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
            label1.Location = new Point(87, 31);
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
            menuStrip2.Size = new Size(404, 29);
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
            registerToolStripMenuItem1.Size = new Size(180, 26);
            registerToolStripMenuItem1.Text = "Register";
            // 
            // test1ToolStripMenuItem
            // 
            test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            test1ToolStripMenuItem.Size = new Size(180, 26);
            test1ToolStripMenuItem.Text = "Test 1";
        
            // 
            // test2ToolStripMenuItem
            // 
            test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            test2ToolStripMenuItem.Size = new Size(180, 26);
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
            // gold1
            // 
            gold1.AutoSize = true;
            gold1.Dock = DockStyle.Fill;
            gold1.Location = new Point(0, 138);
            gold1.Name = "gold1";
            gold1.Size = new Size(1478, 789);
            gold1.TabIndex = 4;
            // 
            // master1
            // 
            master1.Location = new Point(0, 144);
            master1.Name = "master1";
            master1.Size = new Size(1300, 477);
            master1.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 927);
            Controls.Add(master1);
            Controls.Add(gold1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form2";
            Text = "Home";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Gold gold1;
        private Button button2;
        private Master master1;
        private Button button3;
    }
}