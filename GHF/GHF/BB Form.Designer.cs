namespace GHF
{
    partial class BB_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BB_Form));
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            label16 = new Label();
            lbl_qty = new Label();
            label9 = new Label();
            lbl_gm = new Label();
            label20 = new Label();
            lbl_totalamt = new Label();
            button2 = new Button();
            label10 = new Label();
            label11 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 61);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 0;
            label1.Text = "Remark";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-", "ဆိုင်ထည်", "ပြင်ပထည်", "အလျော့မရှုံး", "White Gold", "Gems" });
            comboBox1.Location = new Point(52, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 29);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(283, 85);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(203, 29);
            comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 61);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 2;
            label2.Text = "Item";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 235);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 5;
            label4.Text = "Qty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 367);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 6;
            label5.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 433);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 7;
            label6.Text = "Voucher no";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 169);
            label7.Name = "label7";
            label7.Size = new Size(24, 21);
            label7.TabIndex = 8;
            label7.Text = "GP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 301);
            label8.Name = "label8";
            label8.Size = new Size(27, 21);
            label8.TabIndex = 9;
            label8.Text = "Gm";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 581);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(718, 150);
            dataGridView1.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ButtonShadow;
            label16.Location = new Point(283, 548);
            label16.Name = "label16";
            label16.Size = new Size(63, 21);
            label16.TabIndex = 294;
            label16.Text = "TOTALQTY";
            // 
            // lbl_qty
            // 
            lbl_qty.BackColor = Color.White;
            lbl_qty.Location = new Point(352, 541);
            lbl_qty.Name = "lbl_qty";
            lbl_qty.Size = new Size(45, 33);
            lbl_qty.TabIndex = 291;
            lbl_qty.Text = "0";
            lbl_qty.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonShadow;
            label9.Location = new Point(526, 547);
            label9.Name = "label9";
            label9.Size = new Size(92, 21);
            label9.TabIndex = 292;
            label9.Text = "TOTAL AMOUNT";
            // 
            // lbl_gm
            // 
            lbl_gm.BackColor = Color.White;
            lbl_gm.Location = new Point(471, 541);
            lbl_gm.Name = "lbl_gm";
            lbl_gm.Size = new Size(49, 33);
            lbl_gm.TabIndex = 289;
            lbl_gm.Text = "0";
            lbl_gm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.ButtonShadow;
            label20.Location = new Point(403, 548);
            label20.Name = "label20";
            label20.Size = new Size(62, 21);
            label20.TabIndex = 293;
            label20.Text = "TOTAL GM";
            // 
            // lbl_totalamt
            // 
            lbl_totalamt.BackColor = Color.White;
            lbl_totalamt.Location = new Point(624, 541);
            lbl_totalamt.Name = "lbl_totalamt";
            lbl_totalamt.Size = new Size(104, 33);
            lbl_totalamt.TabIndex = 290;
            lbl_totalamt.Text = "0";
            lbl_totalamt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.Location = new Point(595, 753);
            button2.Name = "button2";
            button2.Size = new Size(135, 41);
            button2.TabIndex = 296;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Pyidaungsu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(52, 20);
            label10.Name = "label10";
            label10.Size = new Size(91, 27);
            label10.TabIndex = 298;
            label10.Text = "Voucher No";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.BackColor = Color.LightGray;
            label11.Location = new Point(-1, 525);
            label11.Name = "label11";
            label11.Size = new Size(746, 2);
            label11.TabIndex = 299;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(52, 132);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 25);
            radioButton1.TabIndex = 300;
            radioButton1.TabStop = true;
            radioButton1.Text = "22K";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(118, 132);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 25);
            radioButton2.TabIndex = 301;
            radioButton2.TabStop = true;
            radioButton2.Text = "24K";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 193);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 39);
            textBox1.TabIndex = 302;
            // 
            // iconButton1
            // 
            iconButton1.BackgroundImage = (Image)resources.GetObject("iconButton1.BackgroundImage");
            iconButton1.BackgroundImageLayout = ImageLayout.Zoom;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(221, 200);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(22, 23);
            iconButton1.TabIndex = 303;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(52, 391);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 39);
            textBox2.TabIndex = 304;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(52, 259);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 39);
            textBox3.TabIndex = 306;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(52, 325);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 39);
            textBox4.TabIndex = 307;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(52, 457);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(203, 39);
            textBox5.TabIndex = 308;
            // 
            // iconButton3
            // 
            iconButton3.BackgroundImage = (Image)resources.GetObject("iconButton3.BackgroundImage");
            iconButton3.BackgroundImageLayout = ImageLayout.Zoom;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(221, 400);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(22, 23);
            iconButton3.TabIndex = 309;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(442, 753);
            button1.Name = "button1";
            button1.Size = new Size(135, 41);
            button1.TabIndex = 310;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // BB_Form
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(742, 806);
            Controls.Add(button1);
            Controls.Add(iconButton3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(iconButton1);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(label16);
            Controls.Add(lbl_qty);
            Controls.Add(label9);
            Controls.Add(lbl_gm);
            Controls.Add(label20);
            Controls.Add(lbl_totalamt);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BB_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BB";
            TopMost = true;
            Load += BB_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private Label label16;
        private Label lbl_qty;
        private Label label9;
        private Label lbl_gm;
        private Label label20;
        private Label lbl_totalamt;
        private Button button2;
        private Label label10;
        private Label label11;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Button button1;
    }
}