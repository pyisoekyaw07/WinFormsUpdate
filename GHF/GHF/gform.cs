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

namespace GHF
{
    public partial class gform : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");
        public gform()
        {
            InitializeComponent();
            goldprice();
            counter();
            item();
            sourceremark();
            Gtype();

        }

        private void gform_Load(object sender, EventArgs e)
        {

            check_language.Text = Form2.setvalueformyan;
            if (check_language.Text == "myanmar")
            {
                myanmar();
            }
            else if (check_language.Text == "eng")
            {
                eng();
            }
            
           

        }
        private void timer1_Tick_1(object sender, EventArgs e)/*Date and Time*/
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            txt_date.Text = d.ToString("dd/MMM/yyyy");
            txt_time.Text = DateTime.Now.ToLongTimeString();
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
            label13.Text = "စာရင်းသွင်းသူအမည်";
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
            button1.Text = "သိမ်းဆည်းမည်";
            button2.Text = "ပယ်ဖျက်မည်";
            button3.Text = "ပြန်ကြည့်မည်";
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
            label13.Text = "Register Name";
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
            button1.Text = "Save";
            button2.Text = "Cancel";
            button3.Text = "Review";
            btn_add_photo.Text = "Add Photo";
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
    }
}
