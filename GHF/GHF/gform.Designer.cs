﻿namespace GHF
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btn_add_photo = new Button();
            cmb_itemname = new ComboBox();
            cmb_item = new ComboBox();
            cmb_gt = new ComboBox();
            cmb_remark = new ComboBox();
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
            label21 = new Label();
            btn_cancel = new Button();
            btn_save = new Button();
            label10 = new Label();
            txt_barcode = new TextBox();
            txt_counter = new TextBox();
            txt_pur_no = new TextBox();
            txt_voucher = new TextBox();
            txt_remark = new TextBox();
            txt_totalamt = new TextBox();
            txt_rep = new TextBox();
            txt_mcost = new TextBox();
            total_S = new TextBox();
            total_Y = new TextBox();
            total_P = new TextBox();
            total_K = new TextBox();
            txt_WC = new TextBox();
            txt_WY = new TextBox();
            txt_WP = new TextBox();
            txt_WK = new TextBox();
            txt_s = new TextBox();
            txt_y = new TextBox();
            txt_p = new TextBox();
            label3 = new Label();
            txt_goldprice = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txt_k = new TextBox();
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
            dataGridView1 = new DataGridView();
            image = new DataGridViewImageColumn();
            date = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            Voucher = new DataGridViewTextBoxColumn();
            enter_remark = new DataGridViewTextBoxColumn();
            purvoc = new DataGridViewTextBoxColumn();
            barcode = new DataGridViewTextBoxColumn();
            goldtype = new DataGridViewTextBoxColumn();
            gold_price = new DataGridViewTextBoxColumn();
            Items = new DataGridViewTextBoxColumn();
            item_name = new DataGridViewTextBoxColumn();
            gm = new DataGridViewTextBoxColumn();
            K = new DataGridViewTextBoxColumn();
            P = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            S = new DataGridViewTextBoxColumn();
            wk = new DataGridViewTextBoxColumn();
            wp = new DataGridViewTextBoxColumn();
            wy = new DataGridViewTextBoxColumn();
            ws = new DataGridViewTextBoxColumn();
            tk = new DataGridViewTextBoxColumn();
            tp = new DataGridViewTextBoxColumn();
            ty = new DataGridViewTextBoxColumn();
            ts = new DataGridViewTextBoxColumn();
            mcost = new DataGridViewTextBoxColumn();
            repamt = new DataGridViewTextBoxColumn();
            total_amt = new DataGridViewTextBoxColumn();
            remark = new DataGridViewTextBoxColumn();
            employee = new DataGridViewTextBoxColumn();
            coledit = new DataGridViewImageColumn();
            label13 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            panel1 = new Panel();
            lbl_totalgm = new Label();
            panel2 = new Panel();
            lbl_totalamt = new Label();
            label33 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel3 = new Panel();
            timer2 = new System.Windows.Forms.Timer(components);
            txt_edit_check = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_add_photo
            // 
            btn_add_photo.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_photo.Location = new Point(1082, 147);
            btn_add_photo.Name = "btn_add_photo";
            btn_add_photo.Size = new Size(107, 47);
            btn_add_photo.TabIndex = 14;
            btn_add_photo.Text = "ပုံထည့်သွင်းရန်";
            btn_add_photo.UseVisualStyleBackColor = true;
            btn_add_photo.Click += btn_add_photo_Click_1;
            // 
            // cmb_itemname
            // 
            cmb_itemname.DropDownHeight = 150;
            cmb_itemname.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_itemname.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_itemname.FormattingEnabled = true;
            cmb_itemname.IntegralHeight = false;
            cmb_itemname.Location = new Point(166, 288);
            cmb_itemname.Name = "cmb_itemname";
            cmb_itemname.Size = new Size(330, 30);
            cmb_itemname.TabIndex = 5;
            cmb_itemname.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // cmb_item
            // 
            cmb_item.DropDownHeight = 150;
            cmb_item.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_item.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_item.FormattingEnabled = true;
            cmb_item.IntegralHeight = false;
            cmb_item.Location = new Point(166, 232);
            cmb_item.Name = "cmb_item";
            cmb_item.Size = new Size(330, 30);
            cmb_item.TabIndex = 4;
            cmb_item.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            cmb_item.Click += comboBox3_Click;
            cmb_item.KeyPress += comboBox3_KeyPress;
            // 
            // cmb_gt
            // 
            cmb_gt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_gt.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_gt.FormattingEnabled = true;
            cmb_gt.Location = new Point(362, 180);
            cmb_gt.Name = "cmb_gt";
            cmb_gt.Size = new Size(134, 30);
            cmb_gt.TabIndex = 3;
            cmb_gt.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            cmb_gt.Click += comboBox2_Click;
            cmb_gt.KeyPress += comboBox2_KeyPress;
            // 
            // cmb_remark
            // 
            cmb_remark.DropDownHeight = 150;
            cmb_remark.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_remark.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_remark.FormattingEnabled = true;
            cmb_remark.IntegralHeight = false;
            cmb_remark.Location = new Point(166, 127);
            cmb_remark.Name = "cmb_remark";
            cmb_remark.Size = new Size(330, 30);
            cmb_remark.TabIndex = 2;
            cmb_remark.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cmb_remark.Click += comboBox1_Click;
            cmb_remark.KeyPress += comboBox1_KeyPress;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = Properties.Resources.ghf3;
            pictureBox.Location = new Point(1058, 23);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(152, 117);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 117;
            pictureBox.TabStop = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(29, 742);
            label20.Name = "label20";
            label20.Size = new Size(56, 22);
            label20.TabIndex = 116;
            label20.Text = "မှတ်ချက်";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(29, 694);
            label19.Name = "label19";
            label19.Size = new Size(90, 22);
            label19.TabIndex = 115;
            label19.Text = "စုစုပေါင်းတန်ဖိုး";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(28, 642);
            label18.Name = "label18";
            label18.Size = new Size(100, 22);
            label18.TabIndex = 114;
            label18.Text = "ပြန်လဲအရှုံးတန်ဖိုး";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(29, 589);
            label17.Name = "label17";
            label17.Size = new Size(46, 22);
            label17.TabIndex = 113;
            label17.Text = "လက်ခ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(25, 525);
            label16.Name = "label16";
            label16.Size = new Size(90, 22);
            label16.TabIndex = 112;
            label16.Text = "စုစုပေါင်းရွှေချိန်";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(649, 108);
            label15.Name = "label15";
            label15.Size = new Size(87, 22);
            label15.TabIndex = 111;
            label15.Text = "ဘားကုဒ်နံပါတ်";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(649, 68);
            label14.Name = "label14";
            label14.Size = new Size(112, 22);
            label14.TabIndex = 110;
            label14.Text = "အရောင်းကောင်တာ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(28, 76);
            label12.Name = "label12";
            label12.Size = new Size(133, 22);
            label12.TabIndex = 108;
            label12.Text = "အ၀ယ်ဘောက်ချာနံပါတ်";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(637, 35);
            label11.Name = "label11";
            label11.Size = new Size(0, 22);
            label11.TabIndex = 107;
            // 
            // btn_review
            // 
            btn_review.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_review.Location = new Point(460, 809);
            btn_review.Name = "btn_review";
            btn_review.Size = new Size(196, 35);
            btn_review.TabIndex = 106;
            btn_review.Text = "&Preview";
            btn_review.UseVisualStyleBackColor = true;
            btn_review.Click += btn_review_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(649, 29);
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
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.DimGray;
            label21.Location = new Point(17, 13);
            label21.Name = "label21";
            label21.Size = new Size(97, 22);
            label21.TabIndex = 123;
            label21.Text = "စုစုပေါင်းဂရမ်ချိန်";
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancel.Location = new Point(245, 809);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(196, 35);
            btn_cancel.TabIndex = 105;
            btn_cancel.Text = "&Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_save.Location = new Point(32, 809);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(196, 35);
            btn_save.TabIndex = 104;
            btn_save.Text = "&Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(25, 236);
            label10.Name = "label10";
            label10.Size = new Size(102, 22);
            label10.TabIndex = 103;
            label10.Text = "ပစ္စည်းအမျိုးအစား";
            // 
            // txt_barcode
            // 
            txt_barcode.BackColor = Color.FromArgb(173, 199, 217);
            txt_barcode.BorderStyle = BorderStyle.None;
            txt_barcode.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_barcode.ForeColor = Color.Black;
            txt_barcode.Location = new Point(793, 104);
            txt_barcode.Multiline = true;
            txt_barcode.Name = "txt_barcode";
            txt_barcode.ReadOnly = true;
            txt_barcode.Size = new Size(207, 28);
            txt_barcode.TabIndex = 102;
            // 
            // txt_counter
            // 
            txt_counter.BackColor = Color.FromArgb(173, 199, 217);
            txt_counter.BorderStyle = BorderStyle.None;
            txt_counter.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_counter.ForeColor = Color.Black;
            txt_counter.Location = new Point(793, 64);
            txt_counter.Multiline = true;
            txt_counter.Name = "txt_counter";
            txt_counter.ReadOnly = true;
            txt_counter.Size = new Size(207, 28);
            txt_counter.TabIndex = 100;
            // 
            // txt_pur_no
            // 
            txt_pur_no.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pur_no.Location = new Point(166, 71);
            txt_pur_no.Name = "txt_pur_no";
            txt_pur_no.Size = new Size(175, 30);
            txt_pur_no.TabIndex = 1;
            // 
            // txt_voucher
            // 
            txt_voucher.BackColor = Color.FromArgb(173, 199, 217);
            txt_voucher.BorderStyle = BorderStyle.None;
            txt_voucher.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_voucher.ForeColor = Color.Black;
            txt_voucher.Location = new Point(793, 25);
            txt_voucher.Multiline = true;
            txt_voucher.Name = "txt_voucher";
            txt_voucher.ReadOnly = true;
            txt_voucher.Size = new Size(207, 28);
            txt_voucher.TabIndex = 98;
            txt_voucher.TabStop = false;
            // 
            // txt_remark
            // 
            txt_remark.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_remark.Location = new Point(169, 738);
            txt_remark.Name = "txt_remark";
            txt_remark.Size = new Size(298, 30);
            txt_remark.TabIndex = 13;
            // 
            // txt_totalamt
            // 
            txt_totalamt.BackColor = Color.FromArgb(173, 199, 217);
            txt_totalamt.BorderStyle = BorderStyle.None;
            txt_totalamt.Enabled = false;
            txt_totalamt.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_totalamt.Location = new Point(169, 692);
            txt_totalamt.Multiline = true;
            txt_totalamt.Name = "txt_totalamt";
            txt_totalamt.Size = new Size(189, 28);
            txt_totalamt.TabIndex = 96;
            txt_totalamt.TextChanged += txt_totalamt_TextChanged;
            // 
            // txt_rep
            // 
            txt_rep.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_rep.Location = new Point(168, 638);
            txt_rep.Name = "txt_rep";
            txt_rep.Size = new Size(189, 30);
            txt_rep.TabIndex = 12;
            txt_rep.TextChanged += txt_rep_TextChanged;
            txt_rep.KeyPress += txt_rep_KeyPress;
            txt_rep.Leave += txt_rep_Leave;
            // 
            // txt_mcost
            // 
            txt_mcost.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_mcost.Location = new Point(169, 583);
            txt_mcost.Name = "txt_mcost";
            txt_mcost.Size = new Size(189, 30);
            txt_mcost.TabIndex = 11;
            txt_mcost.TextChanged += txt_mcost_TextChanged;
            txt_mcost.KeyPress += txt_mcost_KeyPress;
            txt_mcost.Leave += txt_mcost_Leave;
            // 
            // total_S
            // 
            total_S.BackColor = Color.FromArgb(173, 199, 217);
            total_S.BorderStyle = BorderStyle.None;
            total_S.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            total_S.Location = new Point(364, 524);
            total_S.Multiline = true;
            total_S.Name = "total_S";
            total_S.ReadOnly = true;
            total_S.Size = new Size(59, 28);
            total_S.TabIndex = 93;
            total_S.TextAlign = HorizontalAlignment.Center;
            // 
            // total_Y
            // 
            total_Y.BackColor = Color.FromArgb(173, 199, 217);
            total_Y.BorderStyle = BorderStyle.None;
            total_Y.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            total_Y.Location = new Point(299, 523);
            total_Y.Multiline = true;
            total_Y.Name = "total_Y";
            total_Y.ReadOnly = true;
            total_Y.Size = new Size(59, 28);
            total_Y.TabIndex = 92;
            total_Y.TextAlign = HorizontalAlignment.Center;
            // 
            // total_P
            // 
            total_P.BackColor = Color.FromArgb(173, 199, 217);
            total_P.BorderStyle = BorderStyle.None;
            total_P.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            total_P.Location = new Point(233, 523);
            total_P.Multiline = true;
            total_P.Name = "total_P";
            total_P.ReadOnly = true;
            total_P.Size = new Size(59, 28);
            total_P.TabIndex = 91;
            total_P.TextAlign = HorizontalAlignment.Center;
            // 
            // total_K
            // 
            total_K.BackColor = Color.FromArgb(173, 199, 217);
            total_K.BorderStyle = BorderStyle.None;
            total_K.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            total_K.Location = new Point(167, 523);
            total_K.Multiline = true;
            total_K.Name = "total_K";
            total_K.ReadOnly = true;
            total_K.Size = new Size(59, 28);
            total_K.TabIndex = 90;
            total_K.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_WC
            // 
            txt_WC.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_WC.Location = new Point(364, 473);
            txt_WC.Name = "txt_WC";
            txt_WC.Size = new Size(59, 30);
            txt_WC.TabIndex = 10;
            txt_WC.TextAlign = HorizontalAlignment.Center;
            txt_WC.TextChanged += txt_YC_TextChanged;
            txt_WC.KeyPress += txt_YC_KeyPress;
            txt_WC.Leave += txt_YC_Leave;
            // 
            // txt_WY
            // 
            txt_WY.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_WY.Location = new Point(299, 473);
            txt_WY.Name = "txt_WY";
            txt_WY.Size = new Size(59, 30);
            txt_WY.TabIndex = 9;
            txt_WY.TextAlign = HorizontalAlignment.Center;
            txt_WY.TextChanged += txt_YY_TextChanged;
            txt_WY.KeyPress += txt_YY_KeyPress;
            txt_WY.Leave += txt_YY_Leave;
            // 
            // txt_WP
            // 
            txt_WP.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_WP.Location = new Point(233, 473);
            txt_WP.Name = "txt_WP";
            txt_WP.Size = new Size(59, 30);
            txt_WP.TabIndex = 8;
            txt_WP.TextAlign = HorizontalAlignment.Center;
            txt_WP.TextChanged += txt_YP_TextChanged;
            txt_WP.KeyPress += txt_YP_KeyPress;
            txt_WP.Leave += txt_YP_Leave;
            // 
            // txt_WK
            // 
            txt_WK.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_WK.Location = new Point(167, 473);
            txt_WK.Name = "txt_WK";
            txt_WK.Size = new Size(59, 30);
            txt_WK.TabIndex = 7;
            txt_WK.TextAlign = HorizontalAlignment.Center;
            txt_WK.TextChanged += txt_YK_TextChanged;
            txt_WK.KeyPress += txt_YK_KeyPress;
            txt_WK.Leave += txt_YK_Leave;
            // 
            // txt_s
            // 
            txt_s.BackColor = Color.FromArgb(173, 199, 217);
            txt_s.BorderStyle = BorderStyle.None;
            txt_s.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_s.Location = new Point(362, 427);
            txt_s.Multiline = true;
            txt_s.Name = "txt_s";
            txt_s.ReadOnly = true;
            txt_s.Size = new Size(59, 28);
            txt_s.TabIndex = 85;
            txt_s.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_y
            // 
            txt_y.BackColor = Color.FromArgb(173, 199, 217);
            txt_y.BorderStyle = BorderStyle.None;
            txt_y.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_y.Location = new Point(298, 427);
            txt_y.Multiline = true;
            txt_y.Name = "txt_y";
            txt_y.ReadOnly = true;
            txt_y.Size = new Size(59, 28);
            txt_y.TabIndex = 84;
            txt_y.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_p
            // 
            txt_p.BackColor = Color.FromArgb(173, 199, 217);
            txt_p.BorderStyle = BorderStyle.None;
            txt_p.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_p.Location = new Point(233, 427);
            txt_p.Multiline = true;
            txt_p.Name = "txt_p";
            txt_p.ReadOnly = true;
            txt_p.Size = new Size(59, 28);
            txt_p.TabIndex = 83;
            txt_p.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 131);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 82;
            label3.Text = "အ၀င်စာရင်းမှတ်ချက်";
            // 
            // txt_goldprice
            // 
            txt_goldprice.BackColor = Color.FromArgb(173, 199, 217);
            txt_goldprice.BorderStyle = BorderStyle.None;
            txt_goldprice.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_goldprice.ForeColor = Color.Black;
            txt_goldprice.Location = new Point(166, 183);
            txt_goldprice.Multiline = true;
            txt_goldprice.Name = "txt_goldprice";
            txt_goldprice.ReadOnly = true;
            txt_goldprice.Size = new Size(126, 28);
            txt_goldprice.TabIndex = 200;
            txt_goldprice.DoubleClick += textBox8_DoubleClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(26, 185);
            label8.Name = "label8";
            label8.Size = new Size(48, 22);
            label8.TabIndex = 80;
            label8.Text = "ရွှေစျေး";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(298, 183);
            label9.Name = "label9";
            label9.Size = new Size(47, 22);
            label9.TabIndex = 79;
            label9.Text = "ရွှေရည်";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_k
            // 
            txt_k.BackColor = Color.FromArgb(173, 199, 217);
            txt_k.BorderStyle = BorderStyle.None;
            txt_k.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_k.Location = new Point(167, 427);
            txt_k.Multiline = true;
            txt_k.Name = "txt_k";
            txt_k.ReadOnly = true;
            txt_k.Size = new Size(59, 28);
            txt_k.TabIndex = 78;
            txt_k.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(28, 477);
            label7.Name = "label7";
            label7.Size = new Size(80, 22);
            label7.TabIndex = 77;
            label7.Text = "အလျော့တွက်";
            // 
            // txt_gm
            // 
            txt_gm.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_gm.Location = new Point(166, 342);
            txt_gm.Name = "txt_gm";
            txt_gm.Size = new Size(122, 30);
            txt_gm.TabIndex = 6;
            txt_gm.TextChanged += txt_gm_TextChanged;
            txt_gm.KeyPress += txt_gm_KeyPress;
            txt_gm.Leave += txt_gm_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 429);
            label6.Name = "label6";
            label6.Size = new Size(83, 22);
            label6.TabIndex = 75;
            label6.Text = "ရွှေအသားတင်";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 349);
            label5.Name = "label5";
            label5.Size = new Size(100, 22);
            label5.TabIndex = 74;
            label5.Text = "အလေးချိန်(ဂရမ်)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 291);
            label4.Name = "label4";
            label4.Size = new Size(105, 22);
            label4.TabIndex = 73;
            label4.Text = "ပစ္စည်းအမျိုးအမည်";
            // 
            // txt_time
            // 
            txt_time.BackColor = Color.FromArgb(173, 199, 217);
            txt_time.BorderStyle = BorderStyle.None;
            txt_time.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_time.ForeColor = Color.Black;
            txt_time.Location = new Point(362, 23);
            txt_time.Multiline = true;
            txt_time.Name = "txt_time";
            txt_time.ReadOnly = true;
            txt_time.Size = new Size(134, 28);
            txt_time.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(309, 27);
            label2.Name = "label2";
            label2.Size = new Size(40, 22);
            label2.TabIndex = 71;
            label2.Text = "အချိန်";
            // 
            // txt_date
            // 
            txt_date.BackColor = Color.FromArgb(173, 199, 217);
            txt_date.BorderStyle = BorderStyle.None;
            txt_date.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_date.ForeColor = Color.Black;
            txt_date.Location = new Point(166, 23);
            txt_date.Multiline = true;
            txt_date.Name = "txt_date";
            txt_date.ReadOnly = true;
            txt_date.Size = new Size(126, 28);
            txt_date.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 27);
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
            groupBox1.Location = new Point(658, 673);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 196);
            groupBox1.TabIndex = 130;
            groupBox1.TabStop = false;
            groupBox1.Text = "requirment for calculation";
            groupBox1.Visible = false;
            // 
            // txt_incre_pid
            // 
            txt_incre_pid.Location = new Point(265, 145);
            txt_incre_pid.Name = "txt_incre_pid";
            txt_incre_pid.Size = new Size(100, 28);
            txt_incre_pid.TabIndex = 152;
            // 
            // txt_temparray_proid
            // 
            txt_temparray_proid.Location = new Point(152, 145);
            txt_temparray_proid.Name = "txt_temparray_proid";
            txt_temparray_proid.Size = new Size(107, 28);
            txt_temparray_proid.TabIndex = 151;
            // 
            // txt_ince_proid
            // 
            txt_ince_proid.Location = new Point(86, 145);
            txt_ince_proid.Name = "txt_ince_proid";
            txt_ince_proid.Size = new Size(57, 28);
            txt_ince_proid.TabIndex = 150;
            // 
            // check_language
            // 
            check_language.Location = new Point(417, 71);
            check_language.Name = "check_language";
            check_language.Size = new Size(100, 28);
            check_language.TabIndex = 149;
            check_language.Text = "myanmar";
            check_language.Visible = false;
            check_language.TextChanged += check_language_TextChanged_1;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(18, 100);
            label28.Name = "label28";
            label28.Size = new Size(69, 21);
            label28.TabIndex = 148;
            label28.Text = "product No";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(18, 52);
            label27.Name = "label27";
            label27.Size = new Size(65, 21);
            label27.TabIndex = 147;
            label27.Text = "invoice No";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(264, 25);
            label26.Name = "label26";
            label26.Size = new Size(63, 21);
            label26.TabIndex = 146;
            label26.Text = "temparray";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(152, 25);
            label24.Name = "label24";
            label24.Size = new Size(52, 21);
            label24.TabIndex = 145;
            label24.Text = "result Id";
            // 
            // txt_temparay
            // 
            txt_temparay.Location = new Point(264, 51);
            txt_temparay.Name = "txt_temparay";
            txt_temparay.Size = new Size(100, 28);
            txt_temparay.TabIndex = 144;
            // 
            // txt_result_id
            // 
            txt_result_id.Location = new Point(151, 51);
            txt_result_id.Name = "txt_result_id";
            txt_result_id.Size = new Size(107, 28);
            txt_result_id.TabIndex = 143;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(86, 24);
            label25.Name = "label25";
            label25.Size = new Size(51, 21);
            label25.TabIndex = 141;
            label25.Text = "Decre Id";
            // 
            // txt_Dece
            // 
            txt_Dece.Location = new Point(88, 50);
            txt_Dece.Name = "txt_Dece";
            txt_Dece.Size = new Size(57, 28);
            txt_Dece.TabIndex = 139;
            // 
            // txt_temparay_pid
            // 
            txt_temparay_pid.Location = new Point(264, 93);
            txt_temparay_pid.Name = "txt_temparay_pid";
            txt_temparay_pid.Size = new Size(100, 28);
            txt_temparay_pid.TabIndex = 138;
            // 
            // txt_result_pid
            // 
            txt_result_pid.Location = new Point(152, 93);
            txt_result_pid.Name = "txt_result_pid";
            txt_result_pid.Size = new Size(106, 28);
            txt_result_pid.TabIndex = 137;
            // 
            // txt_Dece_pid
            // 
            txt_Dece_pid.Location = new Point(88, 94);
            txt_Dece_pid.Name = "txt_Dece_pid";
            txt_Dece_pid.Size = new Size(57, 28);
            txt_Dece_pid.TabIndex = 136;
            // 
            // btn_add
            // 
            btn_add.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(472, 738);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(55, 38);
            btn_add.TabIndex = 15;
            btn_add.Text = "&Add";
            btn_add.TextAlign = ContentAlignment.MiddleRight;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(173, 199, 217);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new Font("Pyidaungsu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(24, 47, 81);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { image, date, time, Voucher, enter_remark, purvoc, barcode, goldtype, gold_price, Items, item_name, gm, K, P, Y, S, wk, wp, wy, ws, tk, tp, ty, ts, mcost, repamt, total_amt, remark, employee, coledit });
            dataGridView1.Location = new Point(30, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Pyidaungsu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(773, 227);
            dataGridView1.TabIndex = 201;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // image
            // 
            image.HeaderText = "ဓါတ်ပုံ";
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            image.MinimumWidth = 6;
            image.Name = "image";
            image.Width = 125;
            // 
            // date
            // 
            date.HeaderText = "ရက်စွဲ";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // time
            // 
            time.HeaderText = "အချိန်";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.Width = 125;
            // 
            // Voucher
            // 
            Voucher.HeaderText = "ဘောက်ချာနံပါတ်";
            Voucher.MinimumWidth = 6;
            Voucher.Name = "Voucher";
            Voucher.Width = 150;
            // 
            // enter_remark
            // 
            enter_remark.HeaderText = "အ၀င်စာရင်းမှတ်ချက်";
            enter_remark.MinimumWidth = 6;
            enter_remark.Name = "enter_remark";
            enter_remark.Width = 132;
            // 
            // purvoc
            // 
            purvoc.HeaderText = "အ၀ယ်ဘောက်ချာနံပါတ်";
            purvoc.MinimumWidth = 6;
            purvoc.Name = "purvoc";
            purvoc.Width = 148;
            // 
            // barcode
            // 
            barcode.HeaderText = "ဘားကုဒ်နံပါတ်";
            barcode.MinimumWidth = 6;
            barcode.Name = "barcode";
            barcode.Width = 105;
            // 
            // goldtype
            // 
            goldtype.HeaderText = "ရွှေရည်";
            goldtype.MinimumWidth = 6;
            goldtype.Name = "goldtype";
            goldtype.Width = 68;
            // 
            // gold_price
            // 
            gold_price.HeaderText = "ရွှေစျေး";
            gold_price.MinimumWidth = 6;
            gold_price.Name = "gold_price";
            gold_price.Width = 68;
            // 
            // Items
            // 
            Items.HeaderText = "ပစ္စည်းအမျိုးအစား";
            Items.MinimumWidth = 6;
            Items.Name = "Items";
            Items.Width = 119;
            // 
            // item_name
            // 
            item_name.HeaderText = "ပစ္စည်းအမျိုးအမည်";
            item_name.MinimumWidth = 6;
            item_name.Name = "item_name";
            item_name.Width = 122;
            // 
            // gm
            // 
            gm.HeaderText = "ဂရမ်ချိန်";
            gm.MinimumWidth = 6;
            gm.Name = "gm";
            gm.Width = 72;
            // 
            // K
            // 
            K.HeaderText = "ကျပ်";
            K.MinimumWidth = 6;
            K.Name = "K";
            K.Width = 57;
            // 
            // P
            // 
            P.HeaderText = "ပဲ";
            P.MinimumWidth = 6;
            P.Name = "P";
            P.Width = 57;
            // 
            // Y
            // 
            Y.HeaderText = "ရွေး";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 57;
            // 
            // S
            // 
            S.HeaderText = "စိတ်";
            S.MinimumWidth = 6;
            S.Name = "S";
            S.Width = 57;
            // 
            // wk
            // 
            wk.HeaderText = "ကျပ်";
            wk.MinimumWidth = 6;
            wk.Name = "wk";
            wk.Width = 57;
            // 
            // wp
            // 
            wp.HeaderText = "ပဲ";
            wp.MinimumWidth = 6;
            wp.Name = "wp";
            wp.Width = 57;
            // 
            // wy
            // 
            wy.HeaderText = "ရွေး";
            wy.MinimumWidth = 6;
            wy.Name = "wy";
            wy.Width = 57;
            // 
            // ws
            // 
            ws.HeaderText = "စိတ်";
            ws.MinimumWidth = 6;
            ws.Name = "ws";
            ws.Width = 57;
            // 
            // tk
            // 
            tk.HeaderText = "ကျပ်";
            tk.MinimumWidth = 6;
            tk.Name = "tk";
            tk.Width = 57;
            // 
            // tp
            // 
            tp.HeaderText = "ပဲ";
            tp.MinimumWidth = 6;
            tp.Name = "tp";
            tp.Width = 57;
            // 
            // ty
            // 
            ty.HeaderText = "ရွေး";
            ty.MinimumWidth = 6;
            ty.Name = "ty";
            ty.Width = 57;
            // 
            // ts
            // 
            ts.HeaderText = "စိတ်";
            ts.MinimumWidth = 6;
            ts.Name = "ts";
            ts.Width = 57;
            // 
            // mcost
            // 
            mcost.HeaderText = "လက်ခ";
            mcost.MinimumWidth = 6;
            mcost.Name = "mcost";
            mcost.Width = 125;
            // 
            // repamt
            // 
            repamt.HeaderText = "ပြန်လဲအရှုံးတန်ဖိုး";
            repamt.MinimumWidth = 6;
            repamt.Name = "repamt";
            repamt.Width = 125;
            // 
            // total_amt
            // 
            total_amt.HeaderText = "စုစုပေါင်းတန်ဖိုး";
            total_amt.MinimumWidth = 6;
            total_amt.Name = "total_amt";
            total_amt.Width = 125;
            // 
            // remark
            // 
            remark.HeaderText = "မှတ်ချက်";
            remark.MinimumWidth = 6;
            remark.Name = "remark";
            remark.Width = 200;
            // 
            // employee
            // 
            employee.HeaderText = "စာရင်းသွင်းသူအမည်";
            employee.MinimumWidth = 6;
            employee.Name = "employee";
            employee.Width = 150;
            // 
            // coledit
            // 
            coledit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.NullValue = resources.GetObject("dataGridViewCellStyle5.NullValue");
            coledit.DefaultCellStyle = dataGridViewCellStyle5;
            coledit.Description = "Edit";
            coledit.HeaderText = "";
            coledit.Image = (Image)resources.GetObject("coledit.Image");
            coledit.ImageLayout = DataGridViewImageCellLayout.Stretch;
            coledit.Name = "coledit";
            coledit.Width = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(181, 395);
            label13.Name = "label13";
            label13.Size = new Size(34, 22);
            label13.TabIndex = 202;
            label13.Text = "ကျပ်";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.Transparent;
            label29.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(253, 395);
            label29.Name = "label29";
            label29.Size = new Size(18, 22);
            label29.TabIndex = 203;
            label29.Text = "ပဲ";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(313, 394);
            label30.Name = "label30";
            label30.Size = new Size(30, 22);
            label30.TabIndex = 204;
            label30.Text = "ရွေး";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.Transparent;
            label31.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(377, 396);
            label31.Name = "label31";
            label31.Size = new Size(32, 22);
            label31.TabIndex = 205;
            label31.Text = "စိတ်";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbl_totalgm);
            panel1.Controls.Add(label21);
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(654, 505);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 53);
            panel1.TabIndex = 206;
            // 
            // lbl_totalgm
            // 
            lbl_totalgm.AutoSize = true;
            lbl_totalgm.Font = new Font("Pyidaungsu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_totalgm.ForeColor = Color.DimGray;
            lbl_totalgm.Location = new Point(139, 9);
            lbl_totalgm.Name = "lbl_totalgm";
            lbl_totalgm.Size = new Size(20, 27);
            lbl_totalgm.TabIndex = 124;
            lbl_totalgm.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_totalamt);
            panel2.Controls.Add(label33);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(922, 505);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 53);
            panel2.TabIndex = 207;
            // 
            // lbl_totalamt
            // 
            lbl_totalamt.AutoSize = true;
            lbl_totalamt.Font = new Font("Pyidaungsu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_totalamt.ForeColor = Color.DimGray;
            lbl_totalamt.Location = new Point(130, 9);
            lbl_totalamt.Name = "lbl_totalamt";
            lbl_totalamt.Size = new Size(20, 27);
            lbl_totalamt.TabIndex = 124;
            lbl_totalamt.Text = "0";
            lbl_totalamt.TextChanged += lbl_totalamt_TextChanged;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label33.ForeColor = Color.DimGray;
            label33.Location = new Point(18, 13);
            label33.Name = "label33";
            label33.Size = new Size(89, 22);
            label33.TabIndex = 123;
            label33.Text = "စုစုပေါင်းတန်ဖိုး";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 400;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(624, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(828, 256);
            panel3.TabIndex = 208;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // txt_edit_check
            // 
            txt_edit_check.Location = new Point(533, 744);
            txt_edit_check.Name = "txt_edit_check";
            txt_edit_check.Size = new Size(100, 28);
            txt_edit_check.TabIndex = 209;
            txt_edit_check.Text = "0";
            txt_edit_check.Visible = false;
            // 
            // gform
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1456, 980);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txt_k);
            Controls.Add(txt_edit_check);
            Controls.Add(txt_p);
            Controls.Add(panel3);
            Controls.Add(txt_y);
            Controls.Add(panel2);
            Controls.Add(label31);
            Controls.Add(panel1);
            Controls.Add(txt_s);
            Controls.Add(btn_add);
            Controls.Add(label30);
            Controls.Add(groupBox1);
            Controls.Add(txt_WK);
            Controls.Add(btn_add_photo);
            Controls.Add(label29);
            Controls.Add(cmb_itemname);
            Controls.Add(txt_WP);
            Controls.Add(cmb_item);
            Controls.Add(label13);
            Controls.Add(cmb_gt);
            Controls.Add(txt_WY);
            Controls.Add(cmb_remark);
            Controls.Add(txt_WC);
            Controls.Add(pictureBox);
            Controls.Add(total_K);
            Controls.Add(label20);
            Controls.Add(total_P);
            Controls.Add(label19);
            Controls.Add(total_Y);
            Controls.Add(label18);
            Controls.Add(total_S);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btn_review);
            Controls.Add(label23);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(label10);
            Controls.Add(txt_barcode);
            Controls.Add(txt_counter);
            Controls.Add(txt_pur_no);
            Controls.Add(txt_voucher);
            Controls.Add(txt_remark);
            Controls.Add(txt_totalamt);
            Controls.Add(txt_rep);
            Controls.Add(txt_mcost);
            Controls.Add(label3);
            Controls.Add(txt_goldprice);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txt_gm);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_time);
            Controls.Add(label2);
            Controls.Add(txt_date);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "gform";
            Text = "gform";
            Load += gform_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add_photo;
        private ComboBox cmb_itemname;
        private ComboBox cmb_item;
        private ComboBox cmb_gt;
        private ComboBox cmb_remark;
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
        private Label label21;
        private Button btn_cancel;
        private Button btn_save;
        private Label label10;
        private TextBox txt_barcode;
        private TextBox txt_counter;
        private TextBox txt_pur_no;
        private TextBox txt_voucher;
        private TextBox txt_remark;
        private TextBox txt_totalamt;
        private TextBox txt_rep;
        private TextBox txt_mcost;
        private TextBox total_S;
        private TextBox total_Y;
        private TextBox total_P;
        private TextBox total_K;
        private TextBox txt_WC;
        private TextBox txt_WY;
        private TextBox txt_WP;
        private TextBox txt_WK;
        private TextBox txt_s;
        private TextBox txt_y;
        private TextBox txt_p;
        private Label label3;
        private TextBox txt_goldprice;
        private Label label8;
        private Label label9;
        private TextBox txt_k;
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
        private DataGridView dataGridView1;
        private Label label13;
        private Label label29;
        private Label label30;
        private Label label31;
        private Panel panel1;
        private Label lbl_totalgm;
        private Panel panel2;
        private Label lbl_totalamt;
        private Label label33;
        private ErrorProvider errorProvider1;
        private Panel panel3;
        private System.Windows.Forms.Timer timer2;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn Voucher;
        private DataGridViewTextBoxColumn enter_remark;
        private DataGridViewTextBoxColumn purvoc;
        private DataGridViewTextBoxColumn barcode;
        private DataGridViewTextBoxColumn goldtype;
        private DataGridViewTextBoxColumn gold_price;
        private DataGridViewTextBoxColumn Items;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn gm;
        private DataGridViewTextBoxColumn K;
        private DataGridViewTextBoxColumn P;
        private DataGridViewTextBoxColumn Y;
        private DataGridViewTextBoxColumn S;
        private DataGridViewTextBoxColumn wk;
        private DataGridViewTextBoxColumn wp;
        private DataGridViewTextBoxColumn wy;
        private DataGridViewTextBoxColumn ws;
        private DataGridViewTextBoxColumn tk;
        private DataGridViewTextBoxColumn tp;
        private DataGridViewTextBoxColumn ty;
        private DataGridViewTextBoxColumn ts;
        private DataGridViewTextBoxColumn mcost;
        private DataGridViewTextBoxColumn repamt;
        private DataGridViewTextBoxColumn total_amt;
        private DataGridViewTextBoxColumn remark;
        private DataGridViewTextBoxColumn employee;
        private DataGridViewImageColumn coledit;
        private TextBox txt_edit_check;
    }
}