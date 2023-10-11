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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            pen_counter.SuspendLayout();
            Pan_item.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1282, 471);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1274, 437);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Product Master";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 21);
            label3.Name = "label3";
            label3.Size = new Size(34, 21);
            label3.TabIndex = 27;
            label3.Text = "1.0.0";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item/Itemname", "GoldType", "Gold Price", "Source Remark", "Counter" });
            comboBox1.Location = new Point(6, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 29);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pen_counter);
            groupBox1.Controls.Add(Pan_item);
            groupBox1.Location = new Point(6, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1228, 383);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
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
            pen_counter.Location = new Point(24, 27);
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
            txt_Gem_counter.Location = new Point(189, 147);
            txt_Gem_counter.Name = "txt_Gem_counter";
            txt_Gem_counter.Size = new Size(193, 28);
            txt_Gem_counter.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 150);
            label6.Name = "label6";
            label6.Size = new Size(38, 21);
            label6.TabIndex = 4;
            label6.Text = "Gems";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 112);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 3;
            label5.Text = "Whitegold";
            // 
            // txt_WG_counter
            // 
            txt_WG_counter.Location = new Point(189, 109);
            txt_WG_counter.Name = "txt_WG_counter";
            txt_WG_counter.Size = new Size(193, 28);
            txt_WG_counter.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 70);
            label4.Name = "label4";
            label4.Size = new Size(34, 21);
            label4.TabIndex = 1;
            label4.Text = "Gold";
            // 
            // txt_G_counter
            // 
            txt_G_counter.Location = new Point(189, 67);
            txt_G_counter.Name = "txt_G_counter";
            txt_G_counter.Size = new Size(193, 28);
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
            Pan_item.Location = new Point(23, 27);
            Pan_item.Name = "Pan_item";
            Pan_item.Size = new Size(519, 346);
            Pan_item.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 45);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 11;
            label2.Text = "Item Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 102);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 0;
            label1.Text = "Item";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(136, 238);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(127, 34);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // button1
            // 
            button1.Location = new Point(292, 238);
            button1.Name = "button1";
            button1.Size = new Size(127, 34);
            button1.TabIndex = 9;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // chk_parent
            // 
            chk_parent.AutoSize = true;
            chk_parent.Location = new Point(136, 144);
            chk_parent.Name = "chk_parent";
            chk_parent.Size = new Size(89, 25);
            chk_parent.TabIndex = 18;
            chk_parent.Text = "Parent Item";
            chk_parent.UseVisualStyleBackColor = true;
            chk_parent.CheckedChanged += chk_parent_CheckedChanged_1;
            // 
            // itemtype_combo
            // 
            itemtype_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            itemtype_combo.FormattingEnabled = true;
            itemtype_combo.Items.AddRange(new object[] { "Gold", "WhiteGold", "Gems & Diamond" });
            itemtype_combo.Location = new Point(136, 45);
            itemtype_combo.Name = "itemtype_combo";
            itemtype_combo.Size = new Size(283, 29);
            itemtype_combo.TabIndex = 10;
            // 
            // txt_master_item
            // 
            txt_master_item.Location = new Point(136, 99);
            txt_master_item.Name = "txt_master_item";
            txt_master_item.Size = new Size(283, 28);
            txt_master_item.TabIndex = 17;
            // 
            // Parentitem_combo
            // 
            Parentitem_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            Parentitem_combo.FormattingEnabled = true;
            Parentitem_combo.Items.AddRange(new object[] { "Gold", "WhiteGold", "Gems & Diamond" });
            Parentitem_combo.Location = new Point(136, 174);
            Parentitem_combo.Name = "Parentitem_combo";
            Parentitem_combo.Size = new Size(283, 29);
            Parentitem_combo.TabIndex = 16;
            Parentitem_combo.Click += Parentitem_combo_Click_2;
            // 
            // master2
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 532);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "master2";
            Text = "master2";
            Load += master2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            pen_counter.ResumeLayout(false);
            pen_counter.PerformLayout();
            Pan_item.ResumeLayout(false);
            Pan_item.PerformLayout();
            ResumeLayout(false);
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
        private Label label3;
        private Panel pen_counter;
        private Label label5;
        private TextBox txt_WG_counter;
        private Label label4;
        private TextBox txt_G_counter;
        private Button btn_counter_save;
        private TextBox txt_Gem_counter;
        private Label label6;
    }
}