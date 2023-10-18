namespace GHF
{
    partial class gform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gform));
            btn_add_photo = new Button();
            dataGridView2 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            remark = new DataGridViewTextBoxColumn();
            goldtype = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            pictureBox = new PictureBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            button3 = new Button();
            label23 = new Label();
            openFileDialog1 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label22 = new Label();
            label21 = new Label();
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            textBox29 = new TextBox();
            textBox28 = new TextBox();
            textBox27 = new TextBox();
            textBox26 = new TextBox();
            textBox25 = new TextBox();
            textBox24 = new TextBox();
            textBox23 = new TextBox();
            textBox22 = new TextBox();
            textBox21 = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            label3 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txt_time = new TextBox();
            label2 = new Label();
            txt_date = new TextBox();
            label1 = new Label();
            check_language = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btn_add_photo
            // 
            btn_add_photo.Location = new Point(1112, 155);
            btn_add_photo.Name = "btn_add_photo";
            btn_add_photo.Size = new Size(107, 33);
            btn_add_photo.TabIndex = 127;
            btn_add_photo.Text = "ပုံထည့်သွင်းရန်";
            btn_add_photo.UseVisualStyleBackColor = true;
            btn_add_photo.Click += btn_add_photo_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Date, Time, remark, goldtype, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView2.Location = new Point(685, 242);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 30;
            dataGridView2.Size = new Size(702, 242);
            dataGridView2.TabIndex = 122;
            // 
            // Date
            // 
            Date.HeaderText = "ရက်စွဲ";
            Date.Name = "Date";
            // 
            // Time
            // 
            Time.HeaderText = "အချိန်";
            Time.Name = "Time";
            // 
            // remark
            // 
            remark.HeaderText = "အ၀င်မှတ်ချက်";
            remark.Name = "remark";
            remark.Width = 150;
            // 
            // goldtype
            // 
            goldtype.HeaderText = "ရွှေရည်";
            goldtype.Name = "goldtype";
            // 
            // Column1
            // 
            Column1.HeaderText = "ရွှေစျေး";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "ပစ္စည်းအမျိုးအစား";
            Column2.Name = "Column2";
            Column2.Width = 130;
            // 
            // Column3
            // 
            Column3.HeaderText = "ပစ္စည်းအမျိုးအမည်";
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "အလေးချိန်(ဂရမ်)";
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = "ကျပ်";
            Column5.Name = "Column5";
            Column5.Width = 80;
            // 
            // Column6
            // 
            Column6.HeaderText = "ပဲ";
            Column6.Name = "Column6";
            Column6.Width = 80;
            // 
            // Column7
            // 
            Column7.HeaderText = "ရွေး";
            Column7.Name = "Column7";
            Column7.Width = 80;
            // 
            // Column8
            // 
            Column8.HeaderText = "ခြမ်း";
            Column8.Name = "Column8";
            Column8.Width = 80;
            // 
            // comboBox4
            // 
            comboBox4.DropDownHeight = 100;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.IntegralHeight = false;
            comboBox4.Location = new Point(170, 245);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(310, 29);
            comboBox4.TabIndex = 121;
            // 
            // comboBox3
            // 
            comboBox3.DropDownHeight = 100;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.IntegralHeight = false;
            comboBox3.Location = new Point(170, 199);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(310, 29);
            comboBox3.TabIndex = 120;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            comboBox3.Click += comboBox3_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(170, 155);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(122, 29);
            comboBox2.TabIndex = 119;
            comboBox2.Click += comboBox2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(310, 29);
            comboBox1.TabIndex = 118;
            comboBox1.Click += comboBox1_Click;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(1062, 20);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(197, 123);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 117;
            pictureBox.TabStop = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(30, 603);
            label20.Name = "label20";
            label20.Size = new Size(56, 22);
            label20.TabIndex = 116;
            label20.Text = "မှတ်ချက်";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(30, 556);
            label19.Name = "label19";
            label19.Size = new Size(90, 22);
            label19.TabIndex = 115;
            label19.Text = "စုစုပေါင်းတန်ဖိုး";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(30, 513);
            label18.Name = "label18";
            label18.Size = new Size(100, 22);
            label18.TabIndex = 114;
            label18.Text = "ပြန်လဲအရှုံးတန်ဖိုး";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(31, 469);
            label17.Name = "label17";
            label17.Size = new Size(46, 22);
            label17.TabIndex = 113;
            label17.Text = "လက်ခ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(30, 422);
            label16.Name = "label16";
            label16.Size = new Size(90, 22);
            label16.TabIndex = 112;
            label16.Text = "စုစုပေါင်းရွှေချိန်";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(682, 155);
            label15.Name = "label15";
            label15.Size = new Size(87, 22);
            label15.TabIndex = 111;
            label15.Text = "ဘားကုဒ်နံပါတ်";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(682, 113);
            label14.Name = "label14";
            label14.Size = new Size(112, 22);
            label14.TabIndex = 110;
            label14.Text = "အရောင်းကောင်တာ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(685, 70);
            label13.Name = "label13";
            label13.Size = new Size(115, 22);
            label13.TabIndex = 109;
            label13.Text = "စာရင်းသွင်းသူအမည်";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(30, 74);
            label12.Name = "label12";
            label12.Size = new Size(133, 22);
            label12.TabIndex = 108;
            label12.Text = "အ၀ယ်ဘောက်ချာနံပါတ်";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(685, 24);
            label11.Name = "label11";
            label11.Size = new Size(0, 22);
            label11.TabIndex = 107;
            // 
            // button3
            // 
            button3.Location = new Point(486, 653);
            button3.Name = "button3";
            button3.Size = new Size(196, 38);
            button3.TabIndex = 106;
            button3.Text = "ပြန်ကြည့်မည်";
            button3.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(682, 25);
            label23.Name = "label23";
            label23.Size = new Size(121, 22);
            label23.TabIndex = 128;
            label23.Text = "စက်ဘောက်ချာနံပါတ်";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_1;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(989, 543);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(123, 28);
            textBox4.TabIndex = 126;
            textBox4.Tag = "";
            textBox4.Text = "0";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(777, 543);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(96, 28);
            textBox3.TabIndex = 125;
            textBox3.Text = "0";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(893, 546);
            label22.Name = "label22";
            label22.Size = new Size(90, 22);
            label22.TabIndex = 124;
            label22.Text = "စုစုပေါင်းတန်ဖိုး";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(682, 546);
            label21.Name = "label21";
            label21.Size = new Size(92, 22);
            label21.TabIndex = 123;
            label21.Text = "စုစုပေါင်းအခုရေ";
            // 
            // button2
            // 
            button2.Location = new Point(255, 653);
            button2.Name = "button2";
            button2.Size = new Size(196, 38);
            button2.TabIndex = 105;
            button2.Text = "ပယ်ဖျက်မည်";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(30, 653);
            button1.Name = "button1";
            button1.Size = new Size(196, 38);
            button1.TabIndex = 104;
            button1.Text = "သိမ်းဆည်းမည်";
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(30, 206);
            label10.Name = "label10";
            label10.Size = new Size(102, 22);
            label10.TabIndex = 103;
            label10.Text = "ပစ္စည်းအမျိုးအစား";
            // 
            // textBox29
            // 
            textBox29.BackColor = Color.LightSteelBlue;
            textBox29.Enabled = false;
            textBox29.Location = new Point(825, 151);
            textBox29.Name = "textBox29";
            textBox29.Size = new Size(207, 28);
            textBox29.TabIndex = 102;
            // 
            // textBox28
            // 
            textBox28.BackColor = Color.LightSteelBlue;
            textBox28.Enabled = false;
            textBox28.Location = new Point(825, 64);
            textBox28.Name = "textBox28";
            textBox28.Size = new Size(207, 28);
            textBox28.TabIndex = 101;
            // 
            // textBox27
            // 
            textBox27.BackColor = Color.LightSteelBlue;
            textBox27.Enabled = false;
            textBox27.Location = new Point(825, 107);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(207, 28);
            textBox27.TabIndex = 100;
            // 
            // textBox26
            // 
            textBox26.Location = new Point(170, 68);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(189, 28);
            textBox26.TabIndex = 99;
            // 
            // textBox25
            // 
            textBox25.BackColor = Color.LightSteelBlue;
            textBox25.Enabled = false;
            textBox25.Location = new Point(825, 20);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(207, 28);
            textBox25.TabIndex = 98;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(170, 596);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(298, 28);
            textBox24.TabIndex = 97;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(170, 549);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(189, 28);
            textBox23.TabIndex = 96;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(170, 506);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(189, 28);
            textBox22.TabIndex = 95;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(170, 462);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(189, 28);
            textBox21.TabIndex = 94;
            // 
            // textBox17
            // 
            textBox17.BackColor = Color.LightSteelBlue;
            textBox17.Enabled = false;
            textBox17.Location = new Point(365, 415);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(59, 28);
            textBox17.TabIndex = 93;
            // 
            // textBox18
            // 
            textBox18.BackColor = Color.LightSteelBlue;
            textBox18.Enabled = false;
            textBox18.Location = new Point(300, 415);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(59, 28);
            textBox18.TabIndex = 92;
            // 
            // textBox19
            // 
            textBox19.BackColor = Color.LightSteelBlue;
            textBox19.Enabled = false;
            textBox19.Location = new Point(235, 415);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(59, 28);
            textBox19.TabIndex = 91;
            // 
            // textBox20
            // 
            textBox20.BackColor = Color.LightSteelBlue;
            textBox20.Enabled = false;
            textBox20.Location = new Point(170, 415);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(59, 28);
            textBox20.TabIndex = 90;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(365, 369);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(59, 28);
            textBox13.TabIndex = 89;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(300, 369);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(59, 28);
            textBox14.TabIndex = 88;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(235, 369);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(59, 28);
            textBox15.TabIndex = 87;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(170, 369);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(59, 28);
            textBox16.TabIndex = 86;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.LightSteelBlue;
            textBox12.Enabled = false;
            textBox12.Location = new Point(365, 326);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(59, 28);
            textBox12.TabIndex = 85;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.LightSteelBlue;
            textBox11.Enabled = false;
            textBox11.Location = new Point(300, 326);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(59, 28);
            textBox11.TabIndex = 84;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.LightSteelBlue;
            textBox10.Enabled = false;
            textBox10.Location = new Point(235, 326);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(59, 28);
            textBox10.TabIndex = 83;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 119);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 82;
            label3.Text = "အ၀င်စာရင်းမှတ်ချက်";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.LightSteelBlue;
            textBox8.Location = new Point(358, 155);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(122, 28);
            textBox8.TabIndex = 81;
            textBox8.DoubleClick += textBox8_DoubleClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(298, 161);
            label8.Name = "label8";
            label8.Size = new Size(48, 22);
            label8.TabIndex = 80;
            label8.Text = "ရွှေစျေး";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(30, 162);
            label9.Name = "label9";
            label9.Size = new Size(47, 22);
            label9.TabIndex = 79;
            label9.Text = "ရွှေရည်";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.LightSteelBlue;
            textBox7.Enabled = false;
            textBox7.Location = new Point(170, 326);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(59, 28);
            textBox7.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 376);
            label7.Name = "label7";
            label7.Size = new Size(80, 22);
            label7.TabIndex = 77;
            label7.Text = "အလျော့တွက်";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(170, 286);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(122, 28);
            textBox6.TabIndex = 76;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 333);
            label6.Name = "label6";
            label6.Size = new Size(83, 22);
            label6.TabIndex = 75;
            label6.Text = "ရွှေအသားတင်";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 293);
            label5.Name = "label5";
            label5.Size = new Size(100, 22);
            label5.TabIndex = 74;
            label5.Text = "အလေးချိန်(ဂရမ်)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 248);
            label4.Name = "label4";
            label4.Size = new Size(105, 22);
            label4.TabIndex = 73;
            label4.Text = "ပစ္စည်းအမျိုးအမည်";
            // 
            // txt_time
            // 
            txt_time.BackColor = Color.LightSteelBlue;
            txt_time.Location = new Point(358, 22);
            txt_time.Name = "txt_time";
            txt_time.ReadOnly = true;
            txt_time.Size = new Size(122, 28);
            txt_time.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(298, 28);
            label2.Name = "label2";
            label2.Size = new Size(40, 22);
            label2.TabIndex = 71;
            label2.Text = "အချိန်";
            // 
            // txt_date
            // 
            txt_date.BackColor = Color.LightSteelBlue;
            txt_date.Location = new Point(170, 22);
            txt_date.Name = "txt_date";
            txt_date.ReadOnly = true;
            txt_date.Size = new Size(122, 28);
            txt_date.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(40, 22);
            label1.TabIndex = 69;
            label1.Text = "ရက်စွဲ";
            // 
            // check_language
            // 
            check_language.AutoSize = true;
            check_language.Location = new Point(854, 662);
            check_language.Name = "check_language";
            check_language.Size = new Size(59, 21);
            check_language.TabIndex = 129;
            check_language.Text = "myanmar";
            check_language.Visible = false;
            // 
            // gform
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1429, 759);
            Controls.Add(check_language);
            Controls.Add(btn_add_photo);
            Controls.Add(dataGridView2);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button3);
            Controls.Add(label23);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(textBox29);
            Controls.Add(textBox28);
            Controls.Add(textBox27);
            Controls.Add(textBox26);
            Controls.Add(textBox25);
            Controls.Add(textBox24);
            Controls.Add(textBox23);
            Controls.Add(textBox22);
            Controls.Add(textBox21);
            Controls.Add(textBox17);
            Controls.Add(textBox18);
            Controls.Add(textBox19);
            Controls.Add(textBox20);
            Controls.Add(textBox13);
            Controls.Add(textBox14);
            Controls.Add(textBox15);
            Controls.Add(textBox16);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(label3);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_time);
            Controls.Add(label2);
            Controls.Add(txt_date);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gform";
            Text = "gform";
            Load += gform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add_photo;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn remark;
        private DataGridViewTextBoxColumn goldtype;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private PictureBox pictureBox;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button button3;
        private Label label23;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label22;
        private Label label21;
        private Button button2;
        private Button button1;
        private Label label10;
        private TextBox textBox29;
        private TextBox textBox28;
        private TextBox textBox27;
        private TextBox textBox26;
        private TextBox textBox25;
        private TextBox textBox24;
        private TextBox textBox23;
        private TextBox textBox22;
        private TextBox textBox21;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private Label label3;
        private TextBox textBox8;
        private Label label8;
        private Label label9;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_time;
        private Label label2;
        private TextBox txt_date;
        private Label label1;
        private Label check_language;
    }
}