namespace GHF
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
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            txt_update = new TextBox();
            dataGridView1 = new DataGridView();
            pen_counter = new Panel();
            btn_counter_save = new Button();
            txt_Gem_counter = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txt_WG_counter = new TextBox();
            label4 = new Label();
            txt_G_counter = new TextBox();
            Pan_item = new Panel();
            label2 = new Label();
            label1 = new Label();
            btn_save = new Button();
            button1 = new Button();
            chk_parent = new CheckBox();
            itemtype_combo = new ComboBox();
            txt_master_item = new TextBox();
            Parentitem_combo = new ComboBox();
            txt_Time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            txt_Date = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pen_counter.SuspendLayout();
            Pan_item.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(11, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1282, 441);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1274, 406);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Product Master";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item/Itemname", "GoldType", "Gold Price", "Source Remark", "Counter" });
            comboBox1.Location = new Point(6, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 30);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(txt_update);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(pen_counter);
            groupBox1.Controls.Add(Pan_item);
            groupBox1.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1228, 383);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txt_update
            // 
            txt_update.Location = new Point(554, 284);
            txt_update.Name = "txt_update";
            txt_update.ReadOnly = true;
            txt_update.Size = new Size(283, 30);
            txt_update.TabIndex = 19;
            txt_update.TextChanged += txt_update_TextChanged;
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
            dataGridView1.Location = new Point(554, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(668, 222);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pen_counter
            // 
            pen_counter.BackColor = Color.Gainsboro;
            pen_counter.Controls.Add(btn_counter_save);
            pen_counter.Controls.Add(txt_Gem_counter);
            pen_counter.Controls.Add(label6);
            pen_counter.Controls.Add(label5);
            pen_counter.Controls.Add(txt_WG_counter);
            pen_counter.Controls.Add(label4);
            pen_counter.Controls.Add(txt_G_counter);
            pen_counter.Location = new Point(6, 328);
            pen_counter.Name = "pen_counter";
            pen_counter.Size = new Size(522, 346);
            pen_counter.TabIndex = 23;
            // 
            // btn_counter_save
            // 
            btn_counter_save.Location = new Point(189, 196);
            btn_counter_save.Name = "btn_counter_save";
            btn_counter_save.Size = new Size(193, 34);
            btn_counter_save.TabIndex = 6;
            btn_counter_save.Text = "Save";
            btn_counter_save.UseVisualStyleBackColor = true;
            btn_counter_save.Click += btn_counter_save_Click;
            // 
            // txt_Gem_counter
            // 
            txt_Gem_counter.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Gem_counter.Location = new Point(189, 147);
            txt_Gem_counter.Name = "txt_Gem_counter";
            txt_Gem_counter.Size = new Size(193, 30);
            txt_Gem_counter.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 150);
            label6.Name = "label6";
            label6.Size = new Size(40, 22);
            label6.TabIndex = 4;
            label6.Text = "Gems";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 112);
            label5.Name = "label5";
            label5.Size = new Size(64, 22);
            label5.TabIndex = 3;
            label5.Text = "Whitegold";
            // 
            // txt_WG_counter
            // 
            txt_WG_counter.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_WG_counter.Location = new Point(189, 109);
            txt_WG_counter.Name = "txt_WG_counter";
            txt_WG_counter.Size = new Size(193, 30);
            txt_WG_counter.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 70);
            label4.Name = "label4";
            label4.Size = new Size(35, 22);
            label4.TabIndex = 1;
            label4.Text = "Gold";
            // 
            // txt_G_counter
            // 
            txt_G_counter.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_G_counter.Location = new Point(189, 67);
            txt_G_counter.Name = "txt_G_counter";
            txt_G_counter.Size = new Size(193, 30);
            txt_G_counter.TabIndex = 0;
            // 
            // Pan_item
            // 
            Pan_item.BackColor = Color.Gainsboro;
            Pan_item.Controls.Add(label2);
            Pan_item.Controls.Add(label1);
            Pan_item.Controls.Add(btn_save);
            Pan_item.Controls.Add(button1);
            Pan_item.Controls.Add(chk_parent);
            Pan_item.Controls.Add(itemtype_combo);
            Pan_item.Controls.Add(txt_master_item);
            Pan_item.Controls.Add(Parentitem_combo);
            Pan_item.Location = new Point(6, 21);
            Pan_item.Name = "Pan_item";
            Pan_item.Size = new Size(519, 346);
            Pan_item.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 45);
            label2.Name = "label2";
            label2.Size = new Size(64, 22);
            label2.TabIndex = 11;
            label2.Text = "Item Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 102);
            label1.Name = "label1";
            label1.Size = new Size(34, 22);
            label1.TabIndex = 0;
            label1.Text = "Item";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(136, 223);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(283, 34);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // button1
            // 
            button1.Location = new Point(136, 263);
            button1.Name = "button1";
            button1.Size = new Size(283, 34);
            button1.TabIndex = 9;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chk_parent
            // 
            chk_parent.AutoSize = true;
            chk_parent.Location = new Point(136, 144);
            chk_parent.Name = "chk_parent";
            chk_parent.Size = new Size(93, 26);
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
            itemtype_combo.Location = new Point(136, 45);
            itemtype_combo.Name = "itemtype_combo";
            itemtype_combo.Size = new Size(283, 30);
            itemtype_combo.TabIndex = 10;
            itemtype_combo.SelectedIndexChanged += itemtype_combo_SelectedIndexChanged;
            // 
            // txt_master_item
            // 
            txt_master_item.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_master_item.Location = new Point(136, 99);
            txt_master_item.Name = "txt_master_item";
            txt_master_item.Size = new Size(283, 30);
            txt_master_item.TabIndex = 17;
            // 
            // Parentitem_combo
            // 
            Parentitem_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            Parentitem_combo.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Parentitem_combo.FormattingEnabled = true;
            Parentitem_combo.Items.AddRange(new object[] { "Gold", "WhiteGold", "Gems & Diamond" });
            Parentitem_combo.Location = new Point(136, 174);
            Parentitem_combo.Name = "Parentitem_combo";
            Parentitem_combo.Size = new Size(283, 30);
            Parentitem_combo.TabIndex = 16;
            Parentitem_combo.Click += Parentitem_combo_Click_2;
            // 
            // txt_Time
            // 
            txt_Time.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Time.AutoSize = true;
            txt_Time.Location = new Point(1240, 3);
            txt_Time.Name = "txt_Time";
            txt_Time.Size = new Size(41, 21);
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
            txt_Date.Location = new Point(1157, 3);
            txt_Date.Name = "txt_Date";
            txt_Date.Size = new Size(41, 21);
            txt_Date.TabIndex = 29;
            txt_Date.Text = "label8";
            // 
            // master2
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 532);
            Controls.Add(txt_Date);
            Controls.Add(txt_Time);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "master2";
            Text = "master2";
            Load += master2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pen_counter.ResumeLayout(false);
            pen_counter.PerformLayout();
            Pan_item.ResumeLayout(false);
            Pan_item.PerformLayout();
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
        private Label label3;
        private TextBox txt_update;
    }
}