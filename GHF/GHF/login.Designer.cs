namespace GHF
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            combo_shop = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            label1 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-36, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1011, 701);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(267, 204);
            button3.Name = "button3";
            button3.Size = new Size(27, 22);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(267, 204);
            button2.Name = "button2";
            button2.Size = new Size(27, 22);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 208);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 9;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 159);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 8;
            label5.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 108);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 7;
            label4.Text = "Shop";
            // 
            // combo_shop
            // 
            combo_shop.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_shop.FormattingEnabled = true;
            combo_shop.Location = new Point(112, 100);
            combo_shop.Name = "combo_shop";
            combo_shop.Size = new Size(67, 29);
            combo_shop.TabIndex = 1;
            combo_shop.SelectedIndexChanged += combo_shop_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 303);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 5;
            label3.Text = "If  You Don't  Have Account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Pyidaungsu", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(264, 303);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 5;
            label2.Text = "Sign Up";
            // 
            // button1
            // 
            button1.Location = new Point(111, 250);
            button1.Name = "button1";
            button1.Size = new Size(191, 37);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(112, 201);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '#';
            txt_password.Size = new Size(191, 28);
            txt_password.TabIndex = 3;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(112, 152);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(191, 28);
            txt_username.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pyidaungsu", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(125, 24);
            label1.Name = "label1";
            label1.Size = new Size(119, 60);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(combo_shop);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(981, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 374);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1386, 713);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            WindowState = FormWindowState.Maximized;
            FormClosed += login_FormClosed;
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox combo_shop;
        private System.Windows.Forms.Timer timer2;
        private Button button3;
        private Button button2;
        private GroupBox groupBox1;
    }
}