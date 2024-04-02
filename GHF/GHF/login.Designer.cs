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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            pictureBox1 = new PictureBox();
            grp_login = new GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grp_login.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1459, 713);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grp_login
            // 
            grp_login.BackColor = SystemColors.Control;
            grp_login.Controls.Add(label6);
            grp_login.Controls.Add(label5);
            grp_login.Controls.Add(label4);
            grp_login.Controls.Add(combo_shop);
            grp_login.Controls.Add(label3);
            grp_login.Controls.Add(label2);
            grp_login.Controls.Add(button1);
            grp_login.Controls.Add(txt_password);
            grp_login.Controls.Add(txt_username);
            grp_login.Controls.Add(label1);
            grp_login.Location = new Point(1008, 169);
            grp_login.Name = "grp_login";
            grp_login.Size = new Size(397, 365);
            grp_login.TabIndex = 1;
            grp_login.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 208);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 9;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 159);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 8;
            label5.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 108);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 7;
            label4.Text = "Shop";
            // 
            // combo_shop
            // 
            combo_shop.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_shop.FormattingEnabled = true;
            combo_shop.Location = new Point(106, 100);
            combo_shop.Name = "combo_shop";
            combo_shop.Size = new Size(67, 29);
            combo_shop.TabIndex = 6;
            combo_shop.SelectedIndexChanged += combo_shop_SelectedIndexChanged;
            combo_shop.Click += comboBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 303);
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
            label2.Location = new Point(258, 303);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 4;
            label2.Text = "Sign Up";
            // 
            // button1
            // 
            button1.Location = new Point(105, 250);
            button1.Name = "button1";
            button1.Size = new Size(191, 37);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(106, 201);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '#';
            txt_password.Size = new Size(191, 28);
            txt_password.TabIndex = 2;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(106, 152);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(191, 28);
            txt_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pyidaungsu", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 24);
            label1.Name = "label1";
            label1.Size = new Size(119, 60);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1459, 713);
            Controls.Add(grp_login);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            WindowState = FormWindowState.Maximized;
            FormClosed += login_FormClosed;
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grp_login.ResumeLayout(false);
            grp_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox grp_login;
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
    }
}