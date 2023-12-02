namespace GHF
{
    partial class g_reg_preview
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
            panel3 = new Panel();
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label3 = new Label();
            txt_searchbox = new TextBox();
            dataGridView1 = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // startdate
            // 
            startdate.Location = new Point(99, 12);
            startdate.Name = "startdate";
            startdate.Size = new Size(200, 28);
            startdate.TabIndex = 1;
            startdate.Value = new DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // enddate
            // 
            enddate.Location = new Point(370, 13);
            enddate.Name = "enddate";
            enddate.Size = new Size(200, 28);
            enddate.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(iconButton2);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txt_searchbox);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(startdate);
            panel3.Controls.Add(enddate);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1175, 470);
            panel3.TabIndex = 209;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(3, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 1);
            panel1.TabIndex = 215;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconButton2.IconColor = Color.SteelBlue;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleRight;
            iconButton2.Location = new Point(596, 49);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(122, 31);
            iconButton2.TabIndex = 214;
            iconButton2.Text = "Print";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            iconButton1.IconColor = Color.SteelBlue;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleRight;
            iconButton1.Location = new Point(596, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(122, 31);
            iconButton1.TabIndex = 213;
            iconButton1.Text = "Search";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 15);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 212;
            label4.Text = "To Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 15);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 211;
            label3.Text = "From Date";
            // 
            // txt_searchbox
            // 
            txt_searchbox.Location = new Point(953, 16);
            txt_searchbox.Name = "txt_searchbox";
            txt_searchbox.PlaceholderText = "Search ProductID";
            txt_searchbox.Size = new Size(180, 28);
            txt_searchbox.TabIndex = 210;
            txt_searchbox.TextChanged += txt_searchbox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(173, 199, 217);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(1101, 345);
            dataGridView1.TabIndex = 0;
            // 
            // g_reg_preview
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1175, 470);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "g_reg_preview";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gold Register Preview";
            Load += g_reg_preview_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker startdate;
        private DateTimePicker enddate;
        private Panel panel3;
        private TextBox txt_searchbox;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}