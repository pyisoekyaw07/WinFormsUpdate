namespace GHF
{
    partial class Master
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            Pan_item = new Panel();
            label2 = new Label();
            btn_save = new Button();
            button1 = new Button();
            chk_parent = new CheckBox();
            itemtype_combo = new ComboBox();
            txt_master_item = new TextBox();
            Parentitem_combo = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            Pan_item.SuspendLayout();
            SuspendLayout();
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1282, 471);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1274, 437);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Product Master";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item/Itemname", "GoldType", "Gold Price", "Source Remark" });
            comboBox1.Location = new Point(6, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 29);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Pan_item);
            groupBox1.Location = new Point(6, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1228, 383);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
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
            Pan_item.Location = new Point(18, 27);
            Pan_item.Name = "Pan_item";
            Pan_item.Size = new Size(512, 346);
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
            // btn_save
            // 
            btn_save.Location = new Point(136, 238);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(127, 34);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += button1_Click;
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
            chk_parent.CheckedChanged += chk_parent_CheckedChanged;
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
            Parentitem_combo.Click += Parentitem_combo_Click;
            // 
            // Master
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "Master";
            Size = new Size(1300, 477);
            Load += Master_Load;
            Leave += Master_Leave;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            Pan_item.ResumeLayout(false);
            Pan_item.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btn_save;
        private Label label2;
        private ComboBox itemtype_combo;
        private Button button1;
        private ComboBox Parentitem_combo;
        private TextBox txt_master_item;
        private CheckBox chk_parent;
        private Panel Pan_item;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
    }
}
