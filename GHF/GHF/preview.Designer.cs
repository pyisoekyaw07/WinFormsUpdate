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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // startdate
            // 
            startdate.Location = new Point(73, 39);
            startdate.Name = "startdate";
            startdate.Size = new Size(200, 28);
            startdate.TabIndex = 0;
            // 
            // enddate
            // 
            enddate.Location = new Point(339, 39);
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
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(569, 39);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(118, 28);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Search";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // txt_searchbox
            // 
            txt_searchbox.Location = new Point(965, 43);
            txt_searchbox.Name = "txt_searchbox";
            txt_searchbox.Size = new Size(243, 28);
            txt_searchbox.TabIndex = 4;
            txt_searchbox.TextChanged += txt_searchbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 39);
            label2.Name = "label2";
            label2.Size = new Size(23, 21);
            label2.TabIndex = 5;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 43);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 4;
            label1.Text = "From";
            // 
            // preview
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1239, 533);
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
    }
}