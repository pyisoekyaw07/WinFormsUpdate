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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dataGridView2 = new DataGridView();
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
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(39, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 28);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(264, 29);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 28);
            dateTimePicker2.TabIndex = 2;
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
            panel3.Controls.Add(dataGridView2);
            panel3.Location = new Point(39, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(924, 326);
            panel3.TabIndex = 209;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = Color.FromArgb(173, 199, 217);
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new Font("Pyidaungsu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(24, 47, 81);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { image, date, time, Voucher, enter_remark, purvoc, barcode, goldtype, gold_price, Items, item_name, gm, K, P, Y, S, wk, wp, wy, ws, tk, tp, ty, ts, mcost, repamt, total_amt, remark, employee });
            dataGridView2.Location = new Point(21, 14);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Pyidaungsu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView2.RowTemplate.Height = 30;
            dataGridView2.Size = new Size(881, 300);
            dataGridView2.TabIndex = 201;
            // 
            // image
            // 
            image.HeaderText = "ဓါတ်ပုံ";
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            image.Name = "image";
            // 
            // date
            // 
            date.HeaderText = "ရက်စွဲ";
            date.Name = "date";
            // 
            // time
            // 
            time.HeaderText = "အချိန်";
            time.Name = "time";
            // 
            // Voucher
            // 
            Voucher.HeaderText = "ဘောက်ချာနံပါတ်";
            Voucher.Name = "Voucher";
            Voucher.Width = 150;
            // 
            // enter_remark
            // 
            enter_remark.HeaderText = "အ၀င်စာရင်းမှတ်ချက်";
            enter_remark.Name = "enter_remark";
            enter_remark.Width = 132;
            // 
            // purvoc
            // 
            purvoc.HeaderText = "အ၀ယ်ဘောက်ချာနံပါတ်";
            purvoc.Name = "purvoc";
            purvoc.Width = 148;
            // 
            // barcode
            // 
            barcode.HeaderText = "ဘားကုဒ်နံပါတ်";
            barcode.Name = "barcode";
            barcode.Width = 105;
            // 
            // goldtype
            // 
            goldtype.HeaderText = "ရွှေရည်";
            goldtype.Name = "goldtype";
            goldtype.Width = 68;
            // 
            // gold_price
            // 
            gold_price.HeaderText = "ရွှေစျေး";
            gold_price.Name = "gold_price";
            gold_price.Width = 68;
            // 
            // Items
            // 
            Items.HeaderText = "ပစ္စည်းအမျိုးအစား";
            Items.Name = "Items";
            Items.Width = 119;
            // 
            // item_name
            // 
            item_name.HeaderText = "ပစ္စည်းအမျိုးအမည်";
            item_name.Name = "item_name";
            item_name.Width = 122;
            // 
            // gm
            // 
            gm.HeaderText = "ဂရမ်ချိန်";
            gm.Name = "gm";
            gm.Width = 72;
            // 
            // K
            // 
            K.HeaderText = "ကျပ်";
            K.Name = "K";
            K.Width = 57;
            // 
            // P
            // 
            P.HeaderText = "ပဲ";
            P.Name = "P";
            P.Width = 57;
            // 
            // Y
            // 
            Y.HeaderText = "ရွေး";
            Y.Name = "Y";
            Y.Width = 57;
            // 
            // S
            // 
            S.HeaderText = "စိတ်";
            S.Name = "S";
            S.Width = 57;
            // 
            // wk
            // 
            wk.HeaderText = "ကျပ်";
            wk.Name = "wk";
            wk.Width = 57;
            // 
            // wp
            // 
            wp.HeaderText = "ပဲ";
            wp.Name = "wp";
            wp.Width = 57;
            // 
            // wy
            // 
            wy.HeaderText = "ရွေး";
            wy.Name = "wy";
            wy.Width = 57;
            // 
            // ws
            // 
            ws.HeaderText = "စိတ်";
            ws.Name = "ws";
            ws.Width = 57;
            // 
            // tk
            // 
            tk.HeaderText = "ကျပ်";
            tk.Name = "tk";
            tk.Width = 57;
            // 
            // tp
            // 
            tp.HeaderText = "ပဲ";
            tp.Name = "tp";
            tp.Width = 57;
            // 
            // ty
            // 
            ty.HeaderText = "ရွေး";
            ty.Name = "ty";
            ty.Width = 57;
            // 
            // ts
            // 
            ts.HeaderText = "စိတ်";
            ts.Name = "ts";
            ts.Width = 57;
            // 
            // mcost
            // 
            mcost.HeaderText = "လက်ခ";
            mcost.Name = "mcost";
            // 
            // repamt
            // 
            repamt.HeaderText = "ပြန်လဲအရှုံးတန်ဖိုး";
            repamt.Name = "repamt";
            // 
            // total_amt
            // 
            total_amt.HeaderText = "စုစုပေါင်းတန်ဖိုး";
            total_amt.Name = "total_amt";
            // 
            // remark
            // 
            remark.HeaderText = "မှတ်ချက်";
            remark.Name = "remark";
            remark.Width = 200;
            // 
            // employee
            // 
            employee.HeaderText = "စာရင်းသွင်းသူအမည်";
            employee.Name = "employee";
            employee.Width = 150;
            // 
            // g_reg_preview
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(987, 435);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "g_reg_preview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gold Register Preview";
            Load += g_reg_preview_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private DataGridView dataGridView2;
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
    }
}