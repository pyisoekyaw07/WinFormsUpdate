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

namespace GHF
{
    public partial class gform : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds;
        string sql;

        public gform()
        {
            InitializeComponent();
            goldprice();
            counter();

        }
        DataTable dtb = new DataTable();
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

            invoiceid();
            pid();
            dtb.Columns.Add("SaleVoucher", Type.GetType("System.String"));
            dtb.Columns.Add("ProductID", Type.GetType("System.String"));
            DGW_register.DataSource = dtb;
            DGW_register.AllowUserToAddRows = false;

        }
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
            comboBox4.Items.Clear();
            comboBox3.Items.Clear();

            string sqlquery = "select * from golditem";
            SqlCommand cmd = new SqlCommand(sqlquery, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox3.Items.Add(reader["Golditem"].ToString());
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
        public void Gtype()/*function Gold type */
        {
            comboBox2.Items.Clear();
            string sqlquery = "select * from g_type";
            SqlCommand cmd = new SqlCommand(sqlquery, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["Gold_Type"].ToString());
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
        public void sourceremark()/*function source remark */
        {
            comboBox1.Items.Clear();
            string sqlquery = "select * from source_remark";
            SqlCommand cmd = new SqlCommand(sqlquery, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Source_Remark"].ToString());
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
            string sqlquery = "select * from goldprice";
            SqlCommand cmd = new SqlCommand(sqlquery, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox8.Text = reader["Gold_Price"].ToString();
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
        public void counter()/*function counter */
        {
            string sqlquery = "select * from counter";
            SqlCommand cmd = new SqlCommand(sqlquery, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox27.Text = reader["Gold"].ToString();
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
            label22.Text = "စုစုပေါင်းတန်ဖိုး";
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
            label22.Text = "Total Amount";
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
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                sql = "select * from g_register";
                cmd = new SqlCommand(sql, con);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)

                {
                    string form = "GR";
                    /*string shop = login.shoptext;*/
                    string shop = "A";
                    string date = DateTime.Now.ToString("ddMMyy");
                    string id = "0001";
                    textBox25.Text = form + shop + date + "-" + id;

                }
                else
                {

                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader sr = null;
                    cmd.Connection = con;
                    cmd.CommandText = "select top(1) SaleVoucher from g_register order by SaleVoucher desc";
                    sr = cmd.ExecuteReader();
                    if (sr.Read())

                    {
                        string form = "GR";
                        string num = textBox29.Text;
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
                        textBox25.Text = autoid;

                    }

                }

                con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void show_reg_piddata()/*Show Register Data To Table Function*/
        {
           /* pid();*/
            /* string invoiceno = textBox25.Text;
             string productid = textBox29.Text;*/
            for(int i=0; i < DGW_register.Rows.Count; i++)
            {
                
                cmd = new SqlCommand("insert into g_register(SaleVoucher,ProductID) " +
                     "values('"+ DGW_register.Rows[i].Cells[0].Value + "','"+ DGW_register.Rows[i].Cells[1].Value + "') ",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("success");
                
            }
            

            /*adpt = new SqlDataAdapter("select * from g_register", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;*/

        }
        public void pid()/*function Product Number*/
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                sql = "select * from g_register";
                cmd = new SqlCommand(sql, con);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)

                {
                    /*string shop = login.shoptext;*/
                    string shop = "A";
                    string date = DateTime.Now.ToString("ddMMyy");
                    string id = "0001";
                    textBox29.Text = shop + date + "-" + id;

                }
                else
                {
                   
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader sr = null;
                    cmd.Connection = con;
                    cmd.CommandText = "select top(1) ProductID from g_register order by ProductID desc";
                    sr = cmd.ExecuteReader();
                    if (sr.Read())
                    {
                        string shop = "A";
                        string date = DateTime.Now.ToString("ddMMyy");
                        string pid = sr.GetValue(0).ToString();
                        txt_result_pid.Text = pid;
                        string[] temparray = txt_result_pid.Text.Split('-');
                        txt_temparay_pid.Text= shop + date;
                        txt_Dece_pid.Text = temparray[1];
                        int i = Convert.ToInt32(txt_Dece_pid.Text);
                        i++;
                        txt_Dece_pid.Text = i.ToString();
                        string autoid = txt_temparay_pid.Text + "-" + String.Format("{0:0000}", i);
                        txt_Dece_pid.Text = autoid;
                        textBox29.Text = autoid;
                    }        
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
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
            show_reg_piddata();
            pid();
            invoiceid();

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
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)/*Item ComboBox*/
        {
            comboBox4.Items.Clear();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from gold_itemname where Item=N'" + comboBox3.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox4.Items.Add(dr["Itemname"].ToString());
            }
            con.Close();
        }
        private void comboBox1_Click(object sender, EventArgs e)
        {
            sourceremark();
        }
        private void comboBox2_Click(object sender, EventArgs e)
        {
            Gtype();
        }
        private void comboBox3_Click(object sender, EventArgs e)
        {
            item();
        }
        private void textBox8_DoubleClick(object sender, EventArgs e)
        {

            textBox8.ReadOnly = false;
        }

        public static string language = "";
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

        private void txt_gm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
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
                txt_mcost.Text = string.Format("{0:n}", double.Parse(txt_mcost.Text));
            }

        }

        private void txt_rep_Leave(object sender, EventArgs e)
        {
            if (txt_rep.Text == "")
            {
                txt_rep.Text = "0";
            }
            else
            {
                txt_rep.Text = string.Format("{0:n}", double.Parse(txt_rep.Text));
            }

        }

        private void txt_remark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                show_reg_piddata();
                txt_gm.Focus();
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox1.DroppedDown = true;
            sourceremark();
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox2.DroppedDown = true;
            Gtype();
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox3.DroppedDown = true;
            item();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            /*show_reg_piddata();*/
            comboBox3.Focus();
            dtb.Rows.Add(textBox25.Text, textBox29.Text);
            DGW_register.AllowUserToAddRows = false;
            string shop = "A";
            string date = DateTime.Now.ToString("ddMMyy");
            txt_ince_proid.Text = textBox29.Text;
            string[] temparray = txt_ince_proid.Text.Split('-');
            txt_temparray_proid.Text = shop + date;
            txt_incre_pid.Text = temparray[1];
            int i = Convert.ToInt32(txt_incre_pid.Text);
            i++;
            string autopoid = txt_temparray_proid.Text + "-" + String.Format("{0:0000}", i);
            textBox29.Text = autopoid;

        }

        private void btn_save_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}

