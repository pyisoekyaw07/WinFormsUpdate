﻿namespace GHF
{
    partial class master2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txt_item = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            txt_update = new TextBox();
            Pan_item = new Panel();
            radioButton1 = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            btn_save = new Button();
            button1 = new Button();
            chk_parent = new CheckBox();
            itemtype_combo = new ComboBox();
            txt_master_item = new TextBox();
            Parentitem_combo = new ComboBox();
            pen_counter = new Panel();
            btn_counter_save = new Button();
            txt_Gem_counter = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txt_WG_counter = new TextBox();
            label4 = new Label();
            txt_G_counter = new TextBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            btn_View = new Button();
            txt_shop_name = new TextBox();
            label3 = new Label();
            lbl_shop_name = new Label();
            dataGridView2 = new DataGridView();
            txt_branch_name = new TextBox();
            btn_shop_save = new Button();
            txt_Time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            txt_Date = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Pan_item.SuspendLayout();
            pen_counter.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(15, 5);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1709, 655);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(txt_item);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(txt_update);
            tabPage1.Controls.Add(Pan_item);
            tabPage1.Controls.Add(pen_counter);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 36);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(1701, 615);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Product Master";
            // 
            // txt_item
            // 
            txt_item.Location = new Point(1096, 347);
            txt_item.Margin = new Padding(4, 3, 4, 3);
            txt_item.Name = "txt_item";
            txt_item.Size = new Size(292, 36);
            txt_item.TabIndex = 28;
            txt_item.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(708, 47);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 294);
            panel1.TabIndex = 27;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 47, 81);
            dataGridViewCellStyle2.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(973, 291);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txt_update
            // 
            txt_update.BackColor = Color.White;
            txt_update.Location = new Point(711, 348);
            txt_update.Margin = new Padding(4, 3, 4, 3);
            txt_update.Name = "txt_update";
            txt_update.ReadOnly = true;
            txt_update.Size = new Size(376, 36);
            txt_update.TabIndex = 19;
            txt_update.TextChanged += txt_update_TextChanged;
            // 
            // Pan_item
            // 
            Pan_item.BackColor = SystemColors.InactiveCaption;
            Pan_item.Controls.Add(radioButton1);
            Pan_item.Controls.Add(label2);
            Pan_item.Controls.Add(label1);
            Pan_item.Controls.Add(btn_save);
            Pan_item.Controls.Add(button1);
            Pan_item.Controls.Add(chk_parent);
            Pan_item.Controls.Add(itemtype_combo);
            Pan_item.Controls.Add(txt_master_item);
            Pan_item.Controls.Add(Parentitem_combo);
            Pan_item.Location = new Point(7, 50);
            Pan_item.Margin = new Padding(4, 3, 4, 3);
            Pan_item.Name = "Pan_item";
            Pan_item.Size = new Size(692, 344);
            Pan_item.TabIndex = 22;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(49, 13);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(129, 34);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Update Mode";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton1.Click += radioButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 30);
            label2.TabIndex = 11;
            label2.Text = "Item Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 30);
            label1.TabIndex = 0;
            label1.Text = "Item";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(181, 236);
            btn_save.Margin = new Padding(4, 3, 4, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(377, 40);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // button1
            // 
            button1.Location = new Point(181, 286);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(377, 40);
            button1.TabIndex = 9;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chk_parent
            // 
            chk_parent.AutoSize = true;
            chk_parent.Location = new Point(181, 143);
            chk_parent.Margin = new Padding(4, 3, 4, 3);
            chk_parent.Name = "chk_parent";
            chk_parent.Size = new Size(120, 34);
            chk_parent.TabIndex = 18;
            chk_parent.Text = "Parent Item";
            chk_parent.UseVisualStyleBackColor = true;
            chk_parent.CheckedChanged += chk_parent_CheckedChanged_1;
            // 
            // itemtype_combo
            // 
            itemtype_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            itemtype_combo.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            itemtype_combo.FormattingEnabled = true;
            itemtype_combo.Items.AddRange(new object[] { "Gold", "WhiteGold", "Gems & Diamond" });
            itemtype_combo.Location = new Point(181, 54);
            itemtype_combo.Margin = new Padding(4, 3, 4, 3);
            itemtype_combo.Name = "itemtype_combo";
            itemtype_combo.Size = new Size(376, 35);
            itemtype_combo.TabIndex = 10;
            itemtype_combo.SelectedIndexChanged += itemtype_combo_SelectedIndexChanged;
            // 
            // txt_master_item
            // 
            txt_master_item.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_master_item.Location = new Point(181, 101);
            txt_master_item.Margin = new Padding(4, 3, 4, 3);
            txt_master_item.Name = "txt_master_item";
            txt_master_item.Size = new Size(376, 36);
            txt_master_item.TabIndex = 17;
            // 
            // Parentitem_combo
            // 
            Parentitem_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            Parentitem_combo.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Parentitem_combo.FormattingEnabled = true;
            Parentitem_combo.Items.AddRange(new object[] { "Gold", "WhiteGold", "Gems & Diamond" });
            Parentitem_combo.Location = new Point(181, 188);
            Parentitem_combo.Margin = new Padding(4, 3, 4, 3);
            Parentitem_combo.Name = "Parentitem_combo";
            Parentitem_combo.Size = new Size(376, 35);
            Parentitem_combo.TabIndex = 16;
            Parentitem_combo.Click += Parentitem_combo_Click_2;
            // 
            // pen_counter
            // 
            pen_counter.BackColor = SystemColors.InactiveCaption;
            pen_counter.Controls.Add(btn_counter_save);
            pen_counter.Controls.Add(txt_Gem_counter);
            pen_counter.Controls.Add(label6);
            pen_counter.Controls.Add(label5);
            pen_counter.Controls.Add(txt_WG_counter);
            pen_counter.Controls.Add(label4);
            pen_counter.Controls.Add(txt_G_counter);
            pen_counter.Location = new Point(8, 54);
            pen_counter.Margin = new Padding(4, 3, 4, 3);
            pen_counter.Name = "pen_counter";
            pen_counter.Size = new Size(691, 330);
            pen_counter.TabIndex = 23;
            // 
            // btn_counter_save
            // 
            btn_counter_save.Location = new Point(252, 203);
            btn_counter_save.Margin = new Padding(4, 3, 4, 3);
            btn_counter_save.Name = "btn_counter_save";
            btn_counter_save.Size = new Size(257, 40);
            btn_counter_save.TabIndex = 6;
            btn_counter_save.Text = "Save";
            btn_counter_save.UseVisualStyleBackColor = true;
            btn_counter_save.Click += btn_counter_save_Click;
            // 
            // txt_Gem_counter
            // 
            txt_Gem_counter.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Gem_counter.Location = new Point(252, 156);
            txt_Gem_counter.Margin = new Padding(4, 3, 4, 3);
            txt_Gem_counter.Name = "txt_Gem_counter";
            txt_Gem_counter.Size = new Size(256, 36);
            txt_Gem_counter.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(161, 160);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 30);
            label6.TabIndex = 4;
            label6.Text = "Gems";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 113);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 30);
            label5.TabIndex = 3;
            label5.Text = "Whitegold";
            // 
            // txt_WG_counter
            // 
            txt_WG_counter.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_WG_counter.Location = new Point(252, 110);
            txt_WG_counter.Margin = new Padding(4, 3, 4, 3);
            txt_WG_counter.Name = "txt_WG_counter";
            txt_WG_counter.Size = new Size(256, 36);
            txt_WG_counter.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 67);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 30);
            label4.TabIndex = 1;
            label4.Text = "Gold";
            // 
            // txt_G_counter
            // 
            txt_G_counter.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_G_counter.Location = new Point(252, 64);
            txt_G_counter.Margin = new Padding(4, 3, 4, 3);
            txt_G_counter.Name = "txt_G_counter";
            txt_G_counter.Size = new Size(256, 36);
            txt_G_counter.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item/Itemname", "GoldType", "Gold Price", "Source Remark", "Counter" });
            comboBox1.Location = new Point(8, 12);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(399, 35);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(685, 397);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(300, 32);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 36);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(1701, 615);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Shop";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_View);
            groupBox2.Controls.Add(txt_shop_name);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lbl_shop_name);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(txt_branch_name);
            groupBox2.Controls.Add(btn_shop_save);
            groupBox2.Location = new Point(153, 74);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1008, 200);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // btn_View
            // 
            btn_View.Location = new Point(169, 168);
            btn_View.Margin = new Padding(4, 3, 4, 3);
            btn_View.Name = "btn_View";
            btn_View.Size = new Size(221, 32);
            btn_View.TabIndex = 33;
            btn_View.Text = "View";
            btn_View.UseVisualStyleBackColor = true;
            btn_View.Click += btn_View_Click;
            // 
            // txt_shop_name
            // 
            txt_shop_name.Location = new Point(169, 34);
            txt_shop_name.Margin = new Padding(4, 3, 4, 3);
            txt_shop_name.Name = "txt_shop_name";
            txt_shop_name.Size = new Size(220, 36);
            txt_shop_name.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 31;
            label3.Text = "Branch Name";
            // 
            // lbl_shop_name
            // 
            lbl_shop_name.AutoSize = true;
            lbl_shop_name.Location = new Point(8, 42);
            lbl_shop_name.Margin = new Padding(4, 0, 4, 0);
            lbl_shop_name.Name = "lbl_shop_name";
            lbl_shop_name.Size = new Size(135, 30);
            lbl_shop_name.TabIndex = 30;
            lbl_shop_name.Text = "Main Shop Name";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(440, 28);
            dataGridView2.Margin = new Padding(4, 3, 4, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 30;
            dataGridView2.Size = new Size(536, 143);
            dataGridView2.TabIndex = 30;
            // 
            // txt_branch_name
            // 
            txt_branch_name.Location = new Point(169, 79);
            txt_branch_name.Margin = new Padding(4, 3, 4, 3);
            txt_branch_name.Name = "txt_branch_name";
            txt_branch_name.Size = new Size(220, 36);
            txt_branch_name.TabIndex = 30;
            // 
            // btn_shop_save
            // 
            btn_shop_save.Location = new Point(169, 125);
            btn_shop_save.Margin = new Padding(4, 3, 4, 3);
            btn_shop_save.Name = "btn_shop_save";
            btn_shop_save.Size = new Size(221, 32);
            btn_shop_save.TabIndex = 30;
            btn_shop_save.Text = "Save";
            btn_shop_save.UseVisualStyleBackColor = true;
            btn_shop_save.Click += btn_shop_save_Click;
            // 
            // txt_Time
            // 
            txt_Time.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Time.AutoSize = true;
            txt_Time.Location = new Point(1653, 3);
            txt_Time.Margin = new Padding(4, 0, 4, 0);
            txt_Time.Name = "txt_Time";
            txt_Time.Size = new Size(50, 20);
            txt_Time.TabIndex = 28;
            txt_Time.Text = "label7";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // txt_Date
            // 
            txt_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Date.AutoSize = true;
            txt_Date.Location = new Point(1543, 3);
            txt_Date.Margin = new Padding(4, 0, 4, 0);
            txt_Date.Name = "txt_Date";
            txt_Date.Size = new Size(50, 20);
            txt_Date.TabIndex = 29;
            txt_Date.Text = "label8";
            // 
            // master2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1892, 672);
            Controls.Add(txt_Date);
            Controls.Add(txt_Time);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "master2";
            Text = "master2";
            Load += master2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Pan_item.ResumeLayout(false);
            Pan_item.PerformLayout();
            pen_counter.ResumeLayout(false);
            pen_counter.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Panel Pan_item;
        private Label label2;
        private Label label1;
        private Button btn_save;
        private Button button1;
        private CheckBox chk_parent;
        private ComboBox itemtype_combo;
        private TextBox txt_master_item;
        private ComboBox Parentitem_combo;
        private Panel pen_counter;
        private Label label5;
        private TextBox txt_WG_counter;
        private Label label4;
        private TextBox txt_G_counter;
        private Button btn_counter_save;
        private TextBox txt_Gem_counter;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dataGridView1;
        private Label txt_Time;
        private Label txt_Date;
        private Label lbl_shop_name;
        private TextBox txt_update;
        private TabPage tabPage2;
        private TextBox txt_branch_name;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Button btn_shop_save;
        private TextBox txt_shop_name;
        private Label label3;
        private Button btn_View;
        private RadioButton radioButton1;
        private Panel panel1;
        private TextBox txt_item;
    }
}