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
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // startdate
            // 
            startdate.Location = new Point(39, 29);
            startdate.Name = "startdate";
            startdate.Size = new Size(200, 28);
            startdate.TabIndex = 1;
            // 
            // enddate
            // 
            enddate.Location = new Point(264, 29);
            enddate.Name = "enddate";
            enddate.Size = new Size(200, 28);
            enddate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(841, 404);
            label1.Name = "label1";
            label1.Size = new Size(48, 22);
            label1.TabIndex = 3;
            label1.Text = "Search";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(927, 403);
            label2.Name = "label2";
            label2.Size = new Size(36, 22);
            label2.TabIndex = 4;
            label2.Text = "Print";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(39, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(924, 326);
            panel3.TabIndex = 209;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(891, 287);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(765, 32);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(180, 28);
            textBox1.TabIndex = 210;
            // 
            // g_reg_preview
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(987, 435);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(enddate);
            Controls.Add(startdate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "g_reg_preview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gold Register Preview";
            Load += g_reg_preview_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker startdate;
        private DateTimePicker enddate;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}