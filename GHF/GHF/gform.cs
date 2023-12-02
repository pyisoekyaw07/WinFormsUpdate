using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using Azure.Identity;
using System.Web;
using System.Windows.Media.Converters;
using System.Xml.Linq;
using System.Windows.Media;
using System.Configuration;
using System.Runtime;
using System.Runtime.InteropServices;

namespace GHF
{

    public partial class gform : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");

        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds;
        string sql;

        public gform()
        {
            InitializeComponent();
            /* string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;*/

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (true)//check new order
            {
                timer2.Stop();
                int Desc;
                string check = "";
                check = (InternetGetConnectedState(out Desc, 0).ToString());
                if (check == "True")
                {
                    invoiceid();
                    pid();
                    goldprice();
                    counter();
                }
                else
                {
                    MessageBox.Show("Check Your Internet Connection");
                    this.Enabled = false;
                    this.BackColor = System.Drawing.Color.GhostWhite;
                }
            }
        }
       
        private void gform_Load(object sender, EventArgs e)
        {

            /*check_language.Text = Form2.setvalueformyan;
            if (check_language.Text == "myanmar")
            {
                myanmar();
            }
            else if (check_language.Text == "eng")
            {
                eng();
            }*/
            timer2.Interval = 200;
            timer2.Start();

            {
                this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                this.dataGridView1.ColumnHeadersHeight = this.dataGridView1.ColumnHeadersHeight * 2;
                this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                this.dataGridView1.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);
                this.dataGridView1.Paint += new PaintEventHandler(dataGridView1_Paint);
                this.dataGridView1.Paint += new PaintEventHandler(dataGridView1_Paint2);
                this.dataGridView1.Paint += new PaintEventHandler(dataGridView1_Paint3);
                this.dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);
                this.dataGridView1.ColumnWidthChanged += new DataGridViewColumnEventHandler(dataGridView1_ColumnWidthChanged);
            }

        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;
            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 2;
            this.dataGridView1.Invalidate(rtHeader);
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;
            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 2;
            this.dataGridView1.Invalidate(rtHeader);
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r1 = dataGridView1.GetCellDisplayRectangle(11, -1, true);
            int w2 = dataGridView1.GetCellDisplayRectangle(11, -1, true).Width;
            int w3 = dataGridView1.GetCellDisplayRectangle(11, -1, true).Width;
            int w4 = dataGridView1.GetCellDisplayRectangle(11, -1, true).Width;
            r1.X += 1;
            r1.Y += 1;
            r1.Width = r1.Width + w2 + w3 + w4;
            r1.Height = r1.Height / 2 - 2;
            e.Graphics.FillRectangle(new SolidBrush(dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor), r1);

            StringFormat format = new StringFormat();

            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("ရွှေအသားတင်", dataGridView1.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r1, format);

        }

        private void dataGridView1_Paint2(object sender, PaintEventArgs e)
        {
            Rectangle r1 = dataGridView1.GetCellDisplayRectangle(15, -1, true);
            int w2 = dataGridView1.GetCellDisplayRectangle(20, -1, true).Width;
            int w3 = dataGridView1.GetCellDisplayRectangle(20, -1, true).Width;
            int w4 = dataGridView1.GetCellDisplayRectangle(20, -1, true).Width;
            r1.X += 1;
            r1.Y += 1;
            r1.Width = r1.Width + w2 + w3 + w4;
            r1.Height = r1.Height / 2 - 2;
            e.Graphics.FillRectangle(new SolidBrush(dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r1);

            StringFormat format = new StringFormat();

            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("အလျော့တွက်", dataGridView1.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor), r1, format);
        }

        private void dataGridView1_Paint3(object sender, PaintEventArgs e)
        {
            Rectangle r1 = dataGridView1.GetCellDisplayRectangle(19, -1, true);
            int w2 = dataGridView1.GetCellDisplayRectangle(20, -1, true).Width;
            int w3 = dataGridView1.GetCellDisplayRectangle(20, -1, true).Width;
            int w4 = dataGridView1.GetCellDisplayRectangle(20, -1, true).Width;
            r1.X += 1;
            r1.Y += 1;
            r1.Width = r1.Width + w2 + w3 + w4;
            r1.Height = r1.Height / 2 - 2;
            e.Graphics.FillRectangle(new SolidBrush(dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor), r1);

            StringFormat format = new StringFormat();

            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("စုစုပေါင်းရွှေချိန်", dataGridView1.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r1, format);
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle r2 = e.CellBounds;
                r2.Y += e.CellBounds.Height / 2;
                r2.Height = e.CellBounds.Height / 2;
                e.PaintBackground(r2, true);
                e.PaintContent(r2);
                e.Handled = true;
            }
        }


        /*-------------------------------------------Function Group----------------------------------------------*/
        public void timer1_Tick_1(object sender, EventArgs e)/*Date and Time*/
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            txt_date.Text = d.ToString("dd/MMM/yyyy");
            txt_time.Text = DateTime.Now.ToLongTimeString();

            /*txt_result_id.Text = (txt_form.Text) + (txt_shop.Text) + (txt_date2.Text) + "-" + (txt_code.Text).ToString();*/

        }
        public void item()/*function item*/
        {
            cmb_itemname.Items.Clear();
            cmb_item.Items.Clear();

            string sqlquery = "select * from golditem";
            SqlCommand cmd = new SqlCommand(sqlquery, Con1);

            try
            {
                Con1.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmb_item.Items.Add(reader["Golditem"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con1.Close();
            }

        }
        public void Gtype()/*function Gold type */
        {
            cmb_gt.Items.Clear();
            string sqlquery = "select * from g_type";
            SqlCommand cmd = new SqlCommand(sqlquery, Con1);

            try
            {
                Con1.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmb_gt.Items.Add(reader["Gold_Type"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con1.Close();
            }
        }
        public void sourceremark()/*function source remark */
        {
            cmb_remark.Items.Clear();
            string sqlquery = "select * from source_remark";
            SqlCommand cmd = new SqlCommand(sqlquery, Con1);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmb_remark.Items.Add(reader["Source_Remark"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void goldprice()/*function goldprice */
        {
            string goldprice = "0";
            string sqlquery = "select * from goldprice";
            SqlCommand cmd = new SqlCommand(sqlquery, Con1);

            try
            {
                Con1.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    goldprice = reader["Gold_Price"].ToString();
                    txt_goldprice.Text = string.Format("{0:n0}", double.Parse(goldprice));

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con1.Close();
            }
        }
        public void counter()/*function counter */
        {
            string sqlquery = "select * from counter";
            SqlCommand cmd = new SqlCommand(sqlquery, Con1);

            try
            {
                Con1.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txt_counter.Text = reader["Gold"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con1.Close();
            }
        }
        public void myanmar()/*function myanmar language*/
        {
            label1.Text = "ရက်စွဲ";
            label2.Text = "အချိန်";
            label3.Text = "အ၀င်စာရင်းမှတ်ချက်";
            label4.Text = "ပစ္စည်းအမျိုးအမည်";
            label5.Text = "အလေးချိန်(ဂရမ်)";
            label6.Text = "ရွှေအသားတင်";
            label7.Text = "အလျော့တွက်";
            label8.Text = "ရွှေစျေး";
            label9.Text = "ရွှေရည်";
            label10.Text = "ပစ္စည်းအမျိုးအစား";
            label11.Text = "";
            label12.Text = "အ၀ယ်ဘောက်ချာနံပါတ်";
            label14.Text = "အရောင်းကောင်တာ";
            label15.Text = "ဘားကုဒ်နံပါတ်";
            label16.Text = "စုစုပေါင်းရွှေချိန်";
            label17.Text = "လက်ခ";
            label18.Text = "ပြန်လဲအရှုံးတန်ဖိုး";
            label19.Text = "စုစုပေါင်းတန်ဖိုး";
            label20.Text = "မှတ်ချက်";
            label21.Text = "စုစုပေါင်းအခုရေ";

            label23.Text = "စက်ဘောက်ချာနံပါတ်";
            btn_save.Text = "သိမ်းဆည်းမည်";
            btn_cancel.Text = "ပယ်ဖျက်မည်";
            btn_review.Text = "ပြန်ကြည့်မည်";
            btn_add_photo.Text = "ပုံထည့်သွင်းရန်";
        }
        public void eng()/*function english language*/
        {
            label1.Text = "Date";
            label2.Text = "Time";
            label3.Text = "Source Remark";
            label4.Text = "Item";
            label5.Text = "Gm";
            label6.Text = "ရွှေအသားတင်";
            label7.Text = "အလျော့တွက်";
            label8.Text = "Gold Price";
            label9.Text = "Gold Type";
            label10.Text = "Item Name";
            label11.Text = "";
            label12.Text = "Purchase Voc.No";
            label14.Text = "Sale Counter";
            label15.Text = "Barcode";
            label16.Text = "စုစုပေါင်းရွှေချိန်";
            label17.Text = "MarkingCharges";
            label18.Text = "Repurchase Amount";
            label19.Text = "Total Amount";
            label20.Text = "Remark";
            label21.Text = "Total Qty";

            label23.Text = "Voucher No";
            btn_save.Text = "Save";
            btn_cancel.Text = "Cancel";
            btn_review.Text = "Review";
            btn_add_photo.Text = "Add Photo";
        }
        public void invoiceid()/*function Invoice Number*/
        {

            try
            {
                /*if (Con1.State == ConnectionState.Closed)
                {
                    Con1.Open();
                }*/
                con.Open();
                sql = "SELECT SaleVoucher FROM reg_gold";
                cmd = new SqlCommand(sql, Con1);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)

                {
                    string form = "GR";
                    /*string shop = login.shoptext;*/
                    string shop = "A";
                    string date = DateTime.Now.ToString("ddMMyy");
                    string id = "0001";
                    txt_voucher.Text = form + shop + date + "-" + id;

                }
                else
                {

                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader sr = null;
                    cmd.Connection = Con1;
                    cmd.CommandText = "SELECT SaleVoucher FROM reg_gold ORDER BY SaleVoucher DESC";
                    sr = cmd.ExecuteReader();
                    if (sr.Read())

                    {
                        string form = "GR";
                        string num = txt_barcode.Text;
                        string shop = "A";
                        string date = DateTime.Now.ToString("ddMMyy");
                        string pid = sr.GetValue(0).ToString();
                        txt_result_id.Text = pid;
                        string[] temparray = txt_result_id.Text.Split('-');
                        txt_temparay.Text = form + shop + date;
                        txt_Dece.Text = temparray[1];
                        int i = Convert.ToInt32(txt_Dece.Text);
                        i++;
                        txt_Dece.Text = i.ToString();
                        string autoid = txt_temparay.Text + "-" + String.Format("{0:0000}", i);
                        /* txt_Dece.Text = autoid;*/
                        txt_voucher.Text = autoid;

                    }

                }

                con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void pid()/*function Product Number*/
        {

            try
            {
                /* if (Con1.State == ConnectionState.Closed)
                 {
                     Con1.Open();
                 }*/
                con.Open();
                sql = "SELECT ProductID FROM reg_gold";
                cmd = new SqlCommand(sql, Con1);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)

                {
                    /*string shop = login.shoptext;*/
                    string shop = "A";
                    string date = DateTime.Now.ToString("ddMMyy");
                    string id = "0001";
                    txt_barcode.Text = shop + date + "-" + id;

                }
                else
                {

                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader sr = null;
                    cmd.Connection = Con1;
                    cmd.CommandText = "SELECT ProductID FROM reg_gold ORDER BY ProductID DESC";
                    sr = cmd.ExecuteReader();
                    if (sr.Read())
                    {
                        string shop = "A";
                        string date = DateTime.Now.ToString("ddMMyy");
                        string pid = sr.GetValue(0).ToString();
                        txt_result_pid.Text = pid;
                        string[] temparray = txt_result_pid.Text.Split('-');
                        txt_temparay_pid.Text = shop + date;
                        txt_Dece_pid.Text = temparray[1];
                        int i = Convert.ToInt32(txt_Dece_pid.Text);
                        i++;
                        txt_Dece_pid.Text = i.ToString();
                        string autoid = txt_temparay_pid.Text + "-" + String.Format("{0:0000}", i);
                        txt_Dece_pid.Text = autoid;
                        txt_barcode.Text = autoid;
                    }
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                /* MessageBox.Show(ex.Message);*/
            }
        }
        public void resetinvoice()
        {
            sql = "SELECT Date FROM reg_gold";
            cmd = new SqlCommand(sql, Con1);
            string maxid = cmd.ExecuteScalar() as string;
            DateTime sysdate = DateTime.Now;
            if (maxid == null)

            {
                string form = "GR";
                /*string shop = login.shoptext;*/
                string shop = "A";
                string date = DateTime.Now.ToString("ddMMyy");
                string id = "0001";
                txt_voucher.Text = form + shop + date + "-" + id;

            }
        }
        public void show_reg_piddata()/*Show Register Data To Table Function*/
        {
            /* pid();*/
            /* string invoiceno = textBox25.Text;
             string productid = textBox29.Text;*/
            int primarykey;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                con.Open();
                sql = "SELECT ProductID FROM reg_gold";
                cmd = new SqlCommand(sql, Con1);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == dataGridView1.Rows[i].Cells[6].Value)
                {
                    MessageBox.Show("ProductID Is Already Have");
                }
                else
                {
                    cmd = new SqlCommand("insert into reg_gold(Image,Date,Time,SaleVoucher,Enter_Remark,PurVoucher,ProductID,GoldType,GoldPrice,Item," +
                    "ItemName,Gm,K,P,Y,S,WK,WP,WY,WS,TK,TP,TY,TS,Mcost,Repamt,Totalamt,Remark,Employee) values(@Image,@Date,@Time,@SaleVoucher,@Enter_Remark,@PurVoucher,@ProductID,@GoldType,@GoldPrice,@Item," +
                    "@ItemName,@Gm,@K,@P,@Y,@S,@WK,@WP,@WY,@WS,@TK,@TP,@TY,@TS,@Mcost,@Repamt,@Totalamt,@Remark,@Employee)", con);

                    byte[] img = (byte[])dataGridView1.Rows[i].Cells[0].Value;
                    cmd.Parameters.AddWithValue("@Image", img);
                    cmd.Parameters.AddWithValue("@Date", dataGridView1.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@Time", dataGridView1.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@SaleVoucher", dataGridView1.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@Enter_Remark", dataGridView1.Rows[i].Cells[4].Value);
                    cmd.Parameters.AddWithValue("@PurVoucher", dataGridView1.Rows[i].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@ProductID", dataGridView1.Rows[i].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@GoldType", dataGridView1.Rows[i].Cells[7].Value);
                    cmd.Parameters.AddWithValue("@GoldPrice", dataGridView1.Rows[i].Cells[8].Value);
                    cmd.Parameters.AddWithValue("@Item", dataGridView1.Rows[i].Cells[9].Value);
                    cmd.Parameters.AddWithValue("@ItemName", dataGridView1.Rows[i].Cells[10].Value);
                    cmd.Parameters.AddWithValue("@Gm", dataGridView1.Rows[i].Cells[11].Value);
                    cmd.Parameters.AddWithValue("@K", dataGridView1.Rows[i].Cells[12].Value);
                    cmd.Parameters.AddWithValue("@P", dataGridView1.Rows[i].Cells[13].Value);
                    cmd.Parameters.AddWithValue("@Y", dataGridView1.Rows[i].Cells[14].Value);
                    cmd.Parameters.AddWithValue("@S", dataGridView1.Rows[i].Cells[15].Value);
                    cmd.Parameters.AddWithValue("@WK", dataGridView1.Rows[i].Cells[16].Value);
                    cmd.Parameters.AddWithValue("@WP", dataGridView1.Rows[i].Cells[17].Value);
                    cmd.Parameters.AddWithValue("@WY", dataGridView1.Rows[i].Cells[18].Value);
                    cmd.Parameters.AddWithValue("@WS", dataGridView1.Rows[i].Cells[19].Value);
                    cmd.Parameters.AddWithValue("@TK", dataGridView1.Rows[i].Cells[20].Value);
                    cmd.Parameters.AddWithValue("@TP", dataGridView1.Rows[i].Cells[21].Value);
                    cmd.Parameters.AddWithValue("@TY", dataGridView1.Rows[i].Cells[22].Value);
                    cmd.Parameters.AddWithValue("@TS", dataGridView1.Rows[i].Cells[23].Value);
                    cmd.Parameters.AddWithValue("@Mcost", dataGridView1.Rows[i].Cells[24].Value);
                    cmd.Parameters.AddWithValue("@Repamt", dataGridView1.Rows[i].Cells[25].Value);
                    cmd.Parameters.AddWithValue("@Totalamt", dataGridView1.Rows[i].Cells[26].Value);
                    cmd.Parameters.AddWithValue("@Remark", dataGridView1.Rows[i].Cells[27].Value);
                    cmd.Parameters.AddWithValue("@Employee", dataGridView1.Rows[i].Cells[28].Value);

                    primarykey = Convert.ToInt32(cmd.ExecuteScalar());

                    /*cmd.ExecuteNonQuery();*/
                    
                }

                con.Close();

            }
            dataGridView1.Rows.Clear();
            MessageBox.Show("success");

            /*adpt = new SqlDataAdapter("select * from g_register", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;*/

        }
        private void validatefunction()
        {
            bool ok = true;
            if (cmb_remark.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmb_remark, "required");
            }
            else
            {
                errorProvider1.SetError(cmb_remark, null);

            }
            if (cmb_gt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmb_gt, "Plese Select Gold Type");
            }
            else
            {
                errorProvider1.SetError(cmb_gt, null);

            }
            if (cmb_item.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmb_item, "Plese Select Item");
            }
            else
            {
                errorProvider1.SetError(cmb_item, null);

            }
            if (cmb_itemname.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmb_itemname, "Plese Select Itemname");
            }
            else
            {
                errorProvider1.SetError(cmb_itemname, null);

            }
            if (txt_gm.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txt_gm, "Plese Insert Gm");
            }
            else if (txt_gm.Text == "0")
            {
                errorProvider1.SetError(txt_gm, "Plese Insert Gm");

            }
            else
            {
                errorProvider1.SetError(txt_gm, null);
            }
            if (txt_totalamt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txt_totalamt, "Not Set Value");
            }
            else if (txt_totalamt.Text == "0")
            {
                errorProvider1.SetError(txt_totalamt, "Not Set Value");

            }
            else
            {
                errorProvider1.SetError(txt_totalamt, null);
            }


        }/*Validate Form*/

        public void clearform()
        {
            cmb_item.Items.Clear();
            cmb_itemname.Items.Clear();
            txt_gm.Text = "0";
            txt_WK.Text = "0";
            txt_WP.Text = "0";
            txt_WY.Text = "0";
            txt_WC.Text = "0";
            txt_mcost.Text = "0";
            txt_rep.Text = "0";
            txt_remark.Text = "";

        }
        public void calculategm()/*function claculation TOTAL AMOUNT*/
        {
            double intk, intp, inty, ints, tk, tp, ty, ts, totalK, totalP, totalY, totalS, resultP, resultP2, resultP3, resultP4,
                resultY, resultY2, resultY3, resultY4, resultS, resultS2, resultS3, resultS4, T_wastageK, T_wastageP,
                T_wastageY, T_wastageS, wastageamount, mcost, reploss, totalamt = 0;
            string chks = "0";
            string svalue = "0";
            double gm = 0;
            /*---------------------- Gm To KPY Method------------------------*/
            if (txt_gm.Text == "")
            {
                txt_s.Text = "0";
                txt_gm.Text = "0";
                txt_gm.SelectionStart = 0;
                txt_gm.SelectionLength = txt_gm.Text.Length;
            }
            if (txt_mcost.Text == "")
            {
                txt_mcost.Text = "0";
                txt_mcost.SelectionStart = 0;
                txt_mcost.SelectionLength = txt_mcost.Text.Length;
            }
            if (txt_rep.Text == "")
            {
                txt_rep.Text = "0";
                txt_rep.SelectionStart = 0;
                txt_rep.SelectionLength = txt_rep.Text.Length;
            }
            if (txt_WK.Text == "")
            {
                txt_WK.Text = "0";
                txt_WK.SelectionStart = 0;
                txt_WK.SelectionLength = txt_WK.Text.Length;
            }
            if (txt_WP.Text == "")
            {
                txt_WP.Text = "0";
                txt_WP.SelectionStart = 0;
                txt_WP.SelectionLength = txt_WP.Text.Length;
            }
            if (txt_WY.Text == "")
            {
                txt_WY.Text = "0";
                txt_WY.SelectionStart = 0;
                txt_WY.SelectionLength = txt_WY.Text.Length;
            }
            if (txt_WC.Text == "")
            {
                txt_WC.Text = "0";
                txt_WC.SelectionStart = 0;
                txt_WC.SelectionLength = txt_WC.Text.Length;
            }
            intk = Math.Floor(double.Parse(txt_gm.Text) / double.Parse("16.6"));
            tk = double.Parse(txt_gm.Text) / double.Parse("16.6");
            txt_k.Text = intk.ToString();

            tp = (tk - intk) * 16;
            intp = Math.Floor((tk - intk) * 16);
            txt_p.Text = intp.ToString();

            ty = (tp - intp) * 8;
            inty = Math.Floor((tp - intp) * 8);
            txt_y.Text = inty.ToString();

            ts = ty - inty;
            chks = ts.ToString("0.##");
            if (double.Parse(chks) >= 0.25 && double.Parse(chks) <= 0.49)
            {
                txt_s.Text = "1";

            }
            else if (double.Parse(chks) >= 0.50 && double.Parse(chks) <= 0.74)
            {
                txt_s.Text = "2";

            }
            else if (double.Parse(chks) >= 0.75 && double.Parse(chks) <= 0.9)
            {
                txt_s.Text = "3";

            }
            else if (double.Parse(chks) >= 0.9 && double.Parse(chks) <= 1)
            {
                txt_s.Text = "0";
                txt_y.Text = (inty + 1).ToString();
            }
            else
            {
                if (double.Parse(chks) < 0.25)
                {
                    txt_s.Text = "0";

                }
            }
            /*---------------------- Total KPYS Method------------------------*/

            if (txt_WK.Text != "" || txt_WK.Text != "0" || txt_WP.Text != "" || txt_WP.Text != "0" || txt_WY.Text != "" || txt_WY.Text != "0" || txt_WC.Text != "" || txt_WC.Text != "0")
            {
                if (txt_WK.Text != "")
                {
                    double sumK1 = double.Parse(txt_k.Text);
                    double sumK2 = double.Parse(txt_WK.Text);
                    totalK = sumK1 + sumK2;
                    total_K.Text = totalK.ToString();
                    T_wastageK = double.Parse(total_K.Text);
                }

                if (txt_WP.Text != "")
                {
                    totalP = double.Parse(txt_p.Text) + double.Parse(txt_WP.Text);
                    if (totalP >= 16)
                    {
                        resultP = Math.Floor(totalP / 16);
                        resultP2 = totalP / 16;
                        resultP3 = Math.Floor((resultP2 - resultP) * 16);
                        resultP4 = double.Parse(total_K.Text) + resultP;
                        total_P.Text = resultP3.ToString();
                        total_K.Text = resultP4.ToString();
                        T_wastageP = double.Parse(total_P.Text);
                        T_wastageK = double.Parse(total_K.Text);
                    }
                    else
                    {
                        total_P.Text = totalP.ToString();
                        T_wastageP = double.Parse(total_P.Text);
                    }
                }

                if (txt_WY.Text != "")
                {
                    totalY = double.Parse(txt_y.Text) + double.Parse(txt_WY.Text);
                    if (totalY >= 8)
                    {
                        resultY = Math.Floor(totalY / 8);
                        resultY2 = totalY / 8;
                        resultY3 = Math.Floor((resultY2 - resultY) * 8);
                        resultY4 = double.Parse(total_P.Text) + resultY;
                        total_Y.Text = resultY3.ToString();
                        total_P.Text = resultY4.ToString();
                        T_wastageY = double.Parse(total_Y.Text);
                        T_wastageP = double.Parse(total_P.Text);
                    }
                    else
                    {
                        total_Y.Text = totalY.ToString();
                        T_wastageY = double.Parse(total_Y.Text);
                    }
                }

                if (txt_WC.Text != "")
                {
                    totalS = double.Parse(txt_s.Text) + double.Parse(txt_WC.Text);
                    if (totalS >= 4)
                    {
                        resultS = Math.Floor(totalS / 4);
                        resultS2 = totalS / 4;
                        resultS3 = Math.Floor((resultS2 - resultS) * 4);
                        resultS4 = double.Parse(total_Y.Text) + resultS;
                        total_S.Text = resultS3.ToString();
                        total_Y.Text = resultS4.ToString();
                        T_wastageS = double.Parse(total_S.Text);
                        T_wastageY = double.Parse(total_Y.Text);
                    }
                    else
                    {
                        total_S.Text = totalS.ToString();
                        T_wastageS = double.Parse(total_S.Text);
                    }
                }
            }
            /*------------------------------------------------Total Amount------------------------------------------------*/
            if (total_K.Text != "" && total_P.Text != "" && total_Y.Text != "" && total_S.Text != "")
            {

                T_wastageK = double.Parse(total_K.Text); T_wastageP = double.Parse(total_P.Text);
                T_wastageY = double.Parse(total_Y.Text); T_wastageS = double.Parse(total_S.Text);
                mcost = double.Parse(txt_mcost.Text); reploss = double.Parse(txt_rep.Text);
                wastageamount = Math.Round(((((T_wastageS / 4) + T_wastageY) / 8 + T_wastageP) / 16 + T_wastageK) * double.Parse(txt_goldprice.Text));

                totalamt = (wastageamount + mcost) - reploss;
                txt_totalamt.Text = totalamt.ToString();
            }

        }

        /*--------------------------------------------------------------------------------------------------------------------*/
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)/*Item ComboBox*/
        {
            cmb_itemname.Items.Clear();
            Con1.Open();
            SqlCommand cmd = Con1.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from gold_itemname where Item=N'" + cmb_item.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmb_itemname.Items.Add(dr["Itemname"].ToString());
            }
            Con1.Close();
            errorProvider1.SetError(cmb_item, null);
        }
        private void comboBox1_Click(object sender, EventArgs e)
        {

            sourceremark();
        }/*Source Remark*/
        private void comboBox2_Click(object sender, EventArgs e)
        {
            Gtype();
        }/*Gtype*/
        private void comboBox3_Click(object sender, EventArgs e)
        {
            item();
        }/*Item*/
        private void textBox8_DoubleClick(object sender, EventArgs e)
        {

            txt_goldprice.ReadOnly = false;
        }/*Change Gold Price*/
        /*--------------------------------------------Change Language------------------------------------------------------------*/
        public static string language = "";

        public SqlConnection Con { get => Con1; set => Con1 = value; }
        public SqlConnection Con1 { get => con; set => con = value; }

        public void lan()
        {
            check_language.Text = language;
            if (check_language.Text == "myanmar")
            {
                myanmar();
            }
            else if (check_language.Text == "eng")
            {
                eng();
            }
        }
        private void check_language_TextChanged_1(object sender, EventArgs e)
        {
            lan();
        }
        /*--------------------------------------------Validate Textbox and Focus-------------------------------------------------*/
        private void txt_gm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }

        private void txt_gm_TextChanged(object sender, EventArgs e)
        {
            validatefunction();
            calculategm();
            errorProvider1.SetError(txt_gm, null);

        }

        private void txt_YK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_YP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_YY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_YC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_mcost_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;


            }
        }

        private void txt_rep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_mcost_Leave(object sender, EventArgs e)
        {
            if (txt_mcost.Text == "")
            {
                txt_mcost.Text = "0";
            }
            else
            {
                txt_mcost.Text = string.Format("{0:n0}", double.Parse(txt_mcost.Text));
            }
            calculategm();
        }

        private void txt_rep_Leave(object sender, EventArgs e)
        {
            if (txt_rep.Text == "")
            {
                txt_rep.Text = "0";
            }
            else
            {
                txt_rep.Text = string.Format("{0:n0}", double.Parse(txt_rep.Text));
            }
            calculategm();
        }

        private void txt_remark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                show_reg_piddata();
                txt_gm.Focus();
            }
        }

        /*---------------------------------------------Get Data Combobox------------------------------------------------------*/
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmb_remark.DroppedDown = true;
            sourceremark();
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmb_gt.DroppedDown = true;
            Gtype();
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmb_item.DroppedDown = true;
            item();
        }
        /*--------------------------------------------------------------------------------------------------------------------*/

        private void History_addGrid(string date, string time, string Voucher, string enter_remark, string purvoc, string barcode,
            string goldtype, string gold_price, string items, string itemname, string gm, string k, string p, string y, string s,
            string wk, string wp, string wy, string ws, string totalk, string totalp, string totaly, string totals, string mcost,
            string repamt, string totalamt, string remark, string employee)
        {
            try
            {
                int no = 0;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[1].Value = date; newRow.Cells[2].Value = time; newRow.Cells[3].Value = Voucher; newRow.Cells[4].Value = enter_remark;
                newRow.Cells[5].Value = purvoc; newRow.Cells[6].Value = barcode; newRow.Cells[7].Value = goldtype; newRow.Cells[8].Value = gold_price;
                newRow.Cells[9].Value = items; newRow.Cells[10].Value = itemname; newRow.Cells[11].Value = gm; newRow.Cells[12].Value = k;
                newRow.Cells[13].Value = p; newRow.Cells[14].Value = y; newRow.Cells[15].Value = s; newRow.Cells[16].Value = wk;
                newRow.Cells[17].Value = wp; newRow.Cells[18].Value = wy; newRow.Cells[19].Value = ws; newRow.Cells[20].Value = totalk;
                newRow.Cells[21].Value = totalp; newRow.Cells[22].Value = totaly; newRow.Cells[23].Value = totals; newRow.Cells[24].Value = mcost;
                newRow.Cells[25].Value = repamt; newRow.Cells[26].Value = totalamt; newRow.Cells[27].Value = remark; newRow.Cells[28].Value = employee;
                dataGridView1.Rows.Add(newRow);
                MemoryStream mmst = new MemoryStream();
                pictureBox.Image.Save(mmst, pictureBox.Image.RawFormat);
                byte[] img = mmst.ToArray();
                newRow.Cells[0].Value = img;

            }
            catch { }
        }
        private void btn_add_Click(object sender, EventArgs e)/*Add Button*/
        {
            if (cmb_remark.Text == "" || cmb_gt.Text == "" || cmb_item.Text == "" || cmb_itemname.Text == "" || txt_gm.Text == "" || txt_gm.Text == "0" || txt_totalamt.Text == "" || txt_totalamt.Text == "0")
            {
                validatefunction();
            }
            else
            {
                string empolyee = "";
                empolyee = Form2.setvalueemployee;

                History_addGrid(txt_date.Text, txt_time.Text, txt_voucher.Text, cmb_remark.Text, txt_pur_no.Text, txt_barcode.Text, cmb_gt.Text, txt_goldprice.Text,
                    cmb_item.Text, cmb_itemname.Text, txt_gm.Text, txt_k.Text, txt_p.Text, txt_y.Text, txt_s.Text, txt_WK.Text, txt_WP.Text, txt_WY.Text, txt_WC.Text,
                    total_K.Text, total_P.Text, total_Y.Text, total_S.Text, txt_mcost.Text, txt_rep.Text, txt_totalamt.Text, txt_remark.Text, empolyee);



                /*show_reg_piddata();*/
                cmb_item.Focus();
                clearform();
                /* DGW_register.Rows.Add(textBox25.Text, textBox29.Text);*/
                /*DGW_register.AllowUserToAddRows = false;*/
                string shop = "A";
                string date = DateTime.Now.ToString("ddMMyy");
                txt_ince_proid.Text = txt_barcode.Text;
                string[] temparray = txt_ince_proid.Text.Split('-');
                txt_temparray_proid.Text = shop + date;
                txt_incre_pid.Text = temparray[1];
                int i = Convert.ToInt32(txt_incre_pid.Text);
                i++;
                string autopoid = txt_temparray_proid.Text + "-" + String.Format("{0:0000}", i);
                txt_barcode.Text = autopoid;
            }


        }

        private void button1_Click(object sender, EventArgs e)/*Save Button*/
        {
            /*string checkvalue = textBox25.Text;
            if (textBox25.Text == checkvalue)
            {
                MessageBox.Show("Invoice Number Is Save");
            }
            else
            {
                MessageBox.Show("Invoice Number Is Not Save");
            }*/
            /*if (txt_gm.Text == "")
            {
                MessageBox.Show("အချက်အလက်များပြန်လည်စစ်ဆေးပေးပါ");
            }
            else
            {
                invoiceid();
                MessageBox.Show("သိမ်းဆည်းပြီးပါပြီ");
            }*/

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Check You Data Input");
                validatefunction();
            }
            else
            {
                show_reg_piddata();
                pid();
                invoiceid();
            }
            
        }
        private void btn_add_photo_Click_1(object sender, EventArgs e)/*Add Photo*/
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(open.FileName);
                // image file path  
                /* textBox1.Text = open.FileName;*/
            }

        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            /*using Form frm3 = new g_reg_preview();
            {
                //create an overlay form  
                Form overlayForm = new Form();
                overlayForm.StartPosition = FormStartPosition.Manual;
                overlayForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                overlayForm.Opacity =.10d;
                overlayForm.BackColor = System.Drawing.Color.Black;
                overlayForm.Size = this.Size;
                overlayForm.Location = this.Location;
                overlayForm.ShowInTaskbar = true;
                overlayForm.Show();

                //Show the dialog  
                frm3.Owner = overlayForm;
                frm3.ShowDialog();

                //Get rid of the overlay form  
                overlayForm.Dispose();
            }*/
            Form frm3 = new g_reg_preview();
            frm3.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)

        {
            pid();
            invoiceid();
            dataGridView1.Rows.Clear();
        }

        private void txt_YP_TextChanged(object sender, EventArgs e)
        {

            double p = 16;
            if (txt_WP.Text == "")
            {
                txt_WP.Text = "";

            }
            else if (double.Parse(txt_WP.Text) > p)
            {
                MessageBox.Show(" အလျော့တွက် 16 \"ပဲ\" နှင့်အထက် ဖြစ်နေပါသည်");
                txt_WP.Text = "0";
                txt_WP.SelectionStart = 0;
                txt_WP.SelectionLength = txt_WP.Text.Length;
            }
            calculategm();
        }

        private void txt_YY_TextChanged(object sender, EventArgs e)
        {
            double p = 8;
            if (txt_WY.Text == "")
            {
                txt_WY.Text = "";

            }
            else if (double.Parse(txt_WY.Text) > p)
            {
                MessageBox.Show(" အလျော့တွက် 8 \"ရွေး\" နှင့်အထက် ဖြစ်နေပါသည်");
                txt_WY.Text = "0";
                txt_WY.SelectionStart = 0;
                txt_WY.SelectionLength = txt_WY.Text.Length;
            }
            calculategm();
        }

        private void txt_YC_TextChanged(object sender, EventArgs e)
        {
            double p = 4;
            if (txt_WC.Text == "")
            {
                txt_WC.Text = "";

            }
            else if (double.Parse(txt_WC.Text) > p)
            {
                MessageBox.Show("အလျော့တွက် 4 \"စိတ်\" နှင့်အထက် ဖြစ်နေပါသည်");
                txt_WC.Text = "0";
                txt_WC.SelectionStart = 0;
                txt_WC.SelectionLength = txt_WC.Text.Length;
            }
            calculategm();
        }

        private void txt_YK_Leave(object sender, EventArgs e)
        {

            calculategm();

        }
        private void txt_YP_Leave(object sender, EventArgs e)
        {

            calculategm();
        }
        private void txt_YY_Leave(object sender, EventArgs e)
        {

            calculategm();
        }
        private void txt_YC_Leave(object sender, EventArgs e)
        {

            calculategm();
        }

        private void txt_gm_Leave(object sender, EventArgs e)
        {
            calculategm();
        }

        private void txt_YK_TextChanged(object sender, EventArgs e)
        {
            calculategm();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cmb_remark, null);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cmb_gt, null);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cmb_itemname, null);
        }

        private void txt_mcost_TextChanged(object sender, EventArgs e)
        {
            calculategm();
        }

        private void txt_rep_TextChanged(object sender, EventArgs e)
        {
            calculategm();
        }

        private void txt_totalamt_TextChanged(object sender, EventArgs e)
        {
            validatefunction();
            txt_totalamt.Text = string.Format("{0:n0}", double.Parse(txt_totalamt.Text));
        }

       
    }
}

