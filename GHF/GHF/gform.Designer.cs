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
            label12 = new Label();
            label11 = new Label();
            btn_review = new Button();
            label23 = new Label();
            openFileDialog1 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label22 = new Label();
            label21 = new Label();
            btn_cancel = new Button();
            btn_save = new Button();
            label10 = new Label();
            textBox29 = new TextBox();
            textBox27 = new TextBox();
            txt_pur_no = new TextBox();
            textBox25 = new TextBox();
            txt_remark = new TextBox();
            txt_totalamt = new TextBox();
            txt_rep = new TextBox();
            txt_mcost = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            txt_YC = new TextBox();
            txt_YY = new TextBox();
            txt_YP = new TextBox();
            txt_YK = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            label3 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            txt_gm = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txt_time = new TextBox();
            label2 = new Label();
            txt_date = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txt_incre_pid = new TextBox();
            txt_temparray_proid = new TextBox();
            txt_ince_proid = new TextBox();
            check_language = new TextBox();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label24 = new Label();
            txt_temparay = new TextBox();
            txt_result_id = new TextBox();
            label25 = new Label();
            txt_Dece = new TextBox();
            txt_temparay_pid = new TextBox();
            txt_result_pid = new TextBox();
            txt_Dece_pid = new TextBox();
            btn_add = new Button();
            DGW_register = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGW_register).BeginInit();
            SuspendLayout();
            // 
            // btn_add_photo
            // 
            btn_add_photo.Location = new Point(1106, 154);
            btn_add_photo.Name = "btn_add_photo";
            btn_add_photo.Size = new Size(107, 33);
            btn_add_photo.TabIndex = 127;
            btn_add_photo.Text = "ပုံထည့်သွင်းရန်";
            btn_add_photo.UseVisualStyleBackColor = true;
            btn_add_photo.Click += btn_add_photo_Click_1;
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
            comboBox4.TabIndex = 5;
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
            comboBox3.TabIndex = 4;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            comboBox3.Click += comboBox3_Click;
            comboBox3.KeyPress += comboBox3_KeyPress;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(170, 155);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(122, 29);
            comboBox2.TabIndex = 3;
            comboBox2.Click += comboBox2_Click;
            comboBox2.KeyPress += comboBox2_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(310, 29);
            comboBox1.TabIndex = 2;
            comboBox1.Click += comboBox1_Click;
            comboBox1.KeyPress += comboBox1_KeyPress;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(1062, 20);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(191, 117);
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
            label15.Location = new Point(682, 113);
            label15.Name = "label15";
            label15.Size = new Size(87, 22);
            label15.TabIndex = 111;
            label15.Text = "ဘားကုဒ်နံပါတ်";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(682, 71);
            label14.Name = "label14";
            label14.Size = new Size(112, 22);
            label14.TabIndex = 110;
            label14.Text = "အရောင်းကောင်တာ";
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
            // btn_review
            // 
            btn_review.Location = new Point(458, 653);
            btn_review.Name = "btn_review";
            btn_review.Size = new Size(196, 38);
            btn_review.TabIndex = 106;
            btn_review.Text = "&Preview";
            btn_review.UseVisualStyleBackColor = true;
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
            // btn_cancel
            // 
            btn_cancel.Location = new Point(243, 653);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(196, 38);
            btn_cancel.TabIndex = 105;
            btn_cancel.Text = "&Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(30, 653);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(196, 38);
            btn_save.TabIndex = 104;
            btn_save.Text = "&Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += button1_Click;
            btn_save.KeyDown += btn_save_KeyDown;
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
            textBox29.Location = new Point(825, 109);
            textBox29.Name = "textBox29";
            textBox29.Size = new Size(207, 28);
            textBox29.TabIndex = 102;
            // 
            // textBox27
            // 
            textBox27.BackColor = Color.LightSteelBlue;
            textBox27.Enabled = false;
            textBox27.Location = new Point(825, 65);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(207, 28);
            textBox27.TabIndex = 100;
            // 
            // txt_pur_no
            // 
            txt_pur_no.Location = new Point(170, 68);
            txt_pur_no.Name = "txt_pur_no";
            txt_pur_no.Size = new Size(189, 28);
            txt_pur_no.TabIndex = 1;
            // 
            // textBox25
            // 
            textBox25.BackColor = Color.LightSteelBlue;
            textBox25.Enabled = false;
            textBox25.Location = new Point(825, 20);
            textBox25.Name = "textBox25";
            textBox25.ReadOnly = true;
            textBox25.Size = new Size(207, 28);
            textBox25.TabIndex = 98;
            textBox25.TabStop = false;
            // 
            // txt_remark
            // 
            txt_remark.Location = new Point(170, 596);
            txt_remark.Name = "txt_remark";
            txt_remark.Size = new Size(298, 28);
            txt_remark.TabIndex = 13;
            txt_remark.KeyDown += txt_remark_KeyDown;
            // 
            // txt_totalamt
            // 
            txt_totalamt.Enabled = false;
            txt_totalamt.Location = new Point(170, 549);
            txt_totalamt.Name = "txt_totalamt";
            txt_totalamt.Size = new Size(189, 28);
            txt_totalamt.TabIndex = 96;
            // 
            // txt_rep
            // 
            txt_rep.Location = new Point(170, 506);
            txt_rep.Name = "txt_rep";
            txt_rep.Size = new Size(189, 28);
            txt_rep.TabIndex = 12;
            txt_rep.KeyPress += txt_rep_KeyPress;
            txt_rep.Leave += txt_rep_Leave;
            // 
            // txt_mcost
            // 
            txt_mcost.Location = new Point(170, 462);
            txt_mcost.Name = "txt_mcost";
            txt_mcost.Size = new Size(189, 28);
            txt_mcost.TabIndex = 11;
            txt_mcost.KeyPress += txt_mcost_KeyPress;
            txt_mcost.Leave += txt_mcost_Leave;
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
            // txt_YC
            // 
            txt_YC.Location = new Point(365, 369);
            txt_YC.Name = "txt_YC";
            txt_YC.Size = new Size(59, 28);
            txt_YC.TabIndex = 10;
            txt_YC.KeyPress += txt_YC_KeyPress;
            // 
            // txt_YY
            // 
            txt_YY.Location = new Point(300, 369);
            txt_YY.Name = "txt_YY";
            txt_YY.Size = new Size(59, 28);
            txt_YY.TabIndex = 9;
            txt_YY.KeyPress += txt_YY_KeyPress;
            // 
            // txt_YP
            // 
            txt_YP.Location = new Point(235, 369);
            txt_YP.Name = "txt_YP";
            txt_YP.Size = new Size(59, 28);
            txt_YP.TabIndex = 8;
            txt_YP.KeyPress += txt_YP_KeyPress;
            // 
            // txt_YK
            // 
            txt_YK.Location = new Point(170, 369);
            txt_YK.Name = "txt_YK";
            txt_YK.Size = new Size(59, 28);
            txt_YK.TabIndex = 7;
            txt_YK.KeyPress += txt_YK_KeyPress;
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
            textBox8.TabIndex = 200;
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
            // txt_gm
            // 
            txt_gm.Location = new Point(170, 286);
            txt_gm.Name = "txt_gm";
            txt_gm.Size = new Size(122, 28);
            txt_gm.TabIndex = 6;
            txt_gm.KeyPress += txt_gm_KeyPress;
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
            txt_time.Enabled = false;
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
            txt_date.Enabled = false;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_incre_pid);
            groupBox1.Controls.Add(txt_temparray_proid);
            groupBox1.Controls.Add(txt_ince_proid);
            groupBox1.Controls.Add(check_language);
            groupBox1.Controls.Add(label28);
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(txt_temparay);
            groupBox1.Controls.Add(txt_result_id);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(txt_Dece);
            groupBox1.Controls.Add(txt_temparay_pid);
            groupBox1.Controls.Add(txt_result_pid);
            groupBox1.Controls.Add(txt_Dece_pid);
            groupBox1.Location = new Point(688, 591);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 192);
            groupBox1.TabIndex = 130;
            groupBox1.TabStop = false;
            groupBox1.Text = "requirment for calculation";
            groupBox1.Visible = false;
            // 
            // txt_incre_pid
            // 
            txt_incre_pid.Location = new Point(250, 143);
            txt_incre_pid.Name = "txt_incre_pid";
            txt_incre_pid.Size = new Size(100, 28);
            txt_incre_pid.TabIndex = 152;
            // 
            // txt_temparray_proid
            // 
            txt_temparray_proid.Location = new Point(137, 143);
            txt_temparray_proid.Name = "txt_temparray_proid";
            txt_temparray_proid.Size = new Size(107, 28);
            txt_temparray_proid.TabIndex = 151;
            // 
            // txt_ince_proid
            // 
            txt_ince_proid.Location = new Point(71, 143);
            txt_ince_proid.Name = "txt_ince_proid";
            txt_ince_proid.Size = new Size(57, 28);
            txt_ince_proid.TabIndex = 150;
            // 
            // check_language
            // 
            check_language.Location = new Point(386, 49);
            check_language.Name = "check_language";
            check_language.Size = new Size(100, 28);
            check_language.TabIndex = 149;
            check_language.Text = "myanmar";
            check_language.TextChanged += check_language_TextChanged_1;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(3, 98);
            label28.Name = "label28";
            label28.Size = new Size(69, 21);
            label28.TabIndex = 148;
            label28.Text = "product No";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(3, 51);
            label27.Name = "label27";
            label27.Size = new Size(65, 21);
            label27.TabIndex = 147;
            label27.Text = "invoice No";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(249, 25);
            label26.Name = "label26";
            label26.Size = new Size(63, 21);
            label26.TabIndex = 146;
            label26.Text = "temparray";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(137, 25);
            label24.Name = "label24";
            label24.Size = new Size(52, 21);
            label24.TabIndex = 145;
            label24.Text = "result Id";
            // 
            // txt_temparay
            // 
            txt_temparay.Location = new Point(249, 49);
            txt_temparay.Name = "txt_temparay";
            txt_temparay.Size = new Size(100, 28);
            txt_temparay.TabIndex = 144;
            // 
            // txt_result_id
            // 
            txt_result_id.Location = new Point(136, 49);
            txt_result_id.Name = "txt_result_id";
            txt_result_id.Size = new Size(107, 28);
            txt_result_id.TabIndex = 143;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(71, 24);
            label25.Name = "label25";
            label25.Size = new Size(51, 21);
            label25.TabIndex = 141;
            label25.Text = "Decre Id";
            // 
            // txt_Dece
            // 
            txt_Dece.Location = new Point(73, 48);
            txt_Dece.Name = "txt_Dece";
            txt_Dece.Size = new Size(57, 28);
            txt_Dece.TabIndex = 139;
            // 
            // txt_temparay_pid
            // 
            txt_temparay_pid.Location = new Point(249, 91);
            txt_temparay_pid.Name = "txt_temparay_pid";
            txt_temparay_pid.Size = new Size(100, 28);
            txt_temparay_pid.TabIndex = 138;
            // 
            // txt_result_pid
            // 
            txt_result_pid.Location = new Point(137, 91);
            txt_result_pid.Name = "txt_result_pid";
            txt_result_pid.Size = new Size(106, 28);
            txt_result_pid.TabIndex = 137;
            // 
            // txt_Dece_pid
            // 
            txt_Dece_pid.Location = new Point(73, 93);
            txt_Dece_pid.Name = "txt_Dece_pid";
            txt_Dece_pid.Size = new Size(57, 28);
            txt_Dece_pid.TabIndex = 136;
            // 
            // btn_add
            // 
            btn_add.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(473, 596);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(55, 29);
            btn_add.TabIndex = 14;
            btn_add.Text = "&Add";
            btn_add.TextAlign = ContentAlignment.MiddleRight;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // DGW_register
            // 
            DGW_register.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGW_register.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGW_register.Location = new Point(682, 220);
            DGW_register.Name = "DGW_register";
            DGW_register.RowTemplate.Height = 30;
            DGW_register.Size = new Size(668, 150);
            DGW_register.TabIndex = 201;
            // 
            // gform
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1429, 828);
            Controls.Add(DGW_register);
            Controls.Add(btn_add);
            Controls.Add(groupBox1);
            Controls.Add(btn_add_photo);
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
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btn_review);
            Controls.Add(label23);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(label10);
            Controls.Add(textBox29);
            Controls.Add(textBox27);
            Controls.Add(txt_pur_no);
            Controls.Add(textBox25);
            Controls.Add(txt_remark);
            Controls.Add(txt_totalamt);
            Controls.Add(txt_rep);
            Controls.Add(txt_mcost);
            Controls.Add(textBox17);
            Controls.Add(textBox18);
            Controls.Add(textBox19);
            Controls.Add(textBox20);
            Controls.Add(txt_YC);
            Controls.Add(txt_YY);
            Controls.Add(txt_YP);
            Controls.Add(txt_YK);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(label3);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(txt_gm);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGW_register).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add_photo;
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
        private Label label12;
        private Label label11;
        private Button btn_review;
        private Label label23;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label22;
        private Label label21;
        private Button btn_cancel;
        private Button btn_save;
        private Label label10;
        private TextBox textBox29;
        private TextBox textBox27;
        private TextBox txt_pur_no;
        private TextBox textBox25;
        private TextBox txt_remark;
        private TextBox txt_totalamt;
        private TextBox txt_rep;
        private TextBox txt_mcost;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox txt_YC;
        private TextBox txt_YY;
        private TextBox txt_YP;
        private TextBox txt_YK;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private Label label3;
        private TextBox textBox8;
        private Label label8;
        private Label label9;
        private TextBox textBox7;
        private Label label7;
        private TextBox txt_gm;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_time;
        private Label label2;
        private TextBox txt_date;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txt_temparay_pid;
        private TextBox txt_result_pid;
        private TextBox txt_Dece_pid;
        private Label label25;
        private TextBox txt_Dece;
        private TextBox txt_result_id;
        private TextBox txt_temparay;
        private Label label24;
        private Label label28;
        private Label label27;
        private Label label26;
        private TextBox check_language;
        private Button btn_add;
        private TextBox txt_incre_pid;
        private TextBox txt_temparray_proid;
        private TextBox txt_ince_proid;
        private DataGridView DGW_register;
    }
}