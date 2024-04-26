namespace GHF
{
    partial class preview
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
            startdate = new DateTimePicker();
            enddate = new DateTimePicker();
            dataGridView1 = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txt_searchbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            export_excel = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            txt_shop_preview = new TextBox();
            txt_form_perview = new TextBox();
            test2 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // startdate
            // 
            startdate.Location = new Point(73, 8);
            startdate.Name = "startdate";
            startdate.Size = new Size(200, 28);
            startdate.TabIndex = 0;
            // 
            // enddate
            // 
            enddate.Location = new Point(72, 43);
            enddate.Name = "enddate";
            enddate.Size = new Size(200, 28);
            enddate.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(30, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(1178, 419);
            dataGridView1.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Pyidaungsu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(290, 7);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(143, 40);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "&Search";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // txt_searchbox
            // 
            txt_searchbox.Location = new Point(960, 9);
            txt_searchbox.Name = "txt_searchbox";
            txt_searchbox.PlaceholderText = "Search Product";
            txt_searchbox.Size = new Size(243, 28);
            txt_searchbox.TabIndex = 4;
            txt_searchbox.TextChanged += txt_searchbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 47);
            label2.Name = "label2";
            label2.Size = new Size(23, 21);
            label2.TabIndex = 5;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 11);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 4;
            label1.Text = "From";
            // 
            // export_excel
            // 
            export_excel.IconChar = FontAwesome.Sharp.IconChar.Download;
            export_excel.IconColor = Color.Green;
            export_excel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            export_excel.IconSize = 30;
            export_excel.ImageAlign = ContentAlignment.MiddleLeft;
            export_excel.Location = new Point(450, 7);
            export_excel.Name = "export_excel";
            export_excel.Size = new Size(143, 40);
            export_excel.TabIndex = 6;
            export_excel.Text = "&Export Excel";
            export_excel.UseVisualStyleBackColor = true;
            export_excel.Click += export_excel_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.DimGray;
            label3.Location = new Point(-4, 86);
            label3.Name = "label3";
            label3.Size = new Size(1400, 2);
            label3.TabIndex = 7;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_shop_preview
            // 
            txt_shop_preview.Location = new Point(294, 51);
            txt_shop_preview.Name = "txt_shop_preview";
            txt_shop_preview.Size = new Size(100, 28);
            txt_shop_preview.TabIndex = 8;
            // 
            // txt_form_perview
            // 
            txt_form_perview.Location = new Point(434, 51);
            txt_form_perview.Name = "txt_form_perview";
            txt_form_perview.Size = new Size(100, 28);
            txt_form_perview.TabIndex = 9;
            // 
            // test2
            // 
            test2.Location = new Point(561, 51);
            test2.Name = "test2";
            test2.Size = new Size(100, 28);
            test2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(735, 57);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // preview
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1239, 551);
            Controls.Add(label4);
            Controls.Add(test2);
            Controls.Add(txt_form_perview);
            Controls.Add(txt_shop_preview);
            Controls.Add(label3);
            Controls.Add(export_excel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(startdate);
            Controls.Add(enddate);
            Controls.Add(iconButton1);
            Controls.Add(txt_searchbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.Close;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "preview";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Black;
            Load += preview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker startdate;
        private DateTimePicker enddate;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txt_searchbox;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton export_excel;
        private Label label3;
        private SaveFileDialog saveFileDialog1;
        private TextBox txt_shop_preview;
        private TextBox txt_form_perview;
        private TextBox test2;
        private Label label4;
    }
}