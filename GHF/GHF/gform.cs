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

            item();
            Gtype();
            sourceremark();
            goldprice();
            counter();

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            txt_date.Text = d.ToString("dd/MMM/yyyy");
            txt_time.Text = DateTime.Now.ToLongTimeString();
        }
        private void btn_add_photo_Click(object sender, EventArgs e)/*Photo Upload Button*/
        {


        }

        public void item()/*function item*/
        {
            comboBox4.Items.Clear();
            comboBox3.Items.Clear();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from golditem";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox3.Items.Add(dr["gold"].ToString());
            }
            con.Close();
        }
        public void Gtype()/*function Gold type */
        {
            comboBox2.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from g_type";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["gold"].ToString());
            }
            con.Close();
        }
        public void sourceremark()/*function source remark */
        {
            comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from source_remark";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["remark"].ToString());
            }
            con.Close();
        }
        public void goldprice()/*function goldprice */
        {
            /* comboBox1.Items.Clear();*/
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from gold_price";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox8.Text = dr["gold_price"].ToString();
            }
            con.Close();
        }

        private void btn_add_photo_Click_1(object sender, EventArgs e)
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
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
        public void counter()/*function goldprice */
        {
            /* comboBox1.Items.Clear();*/
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from counter";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox27.Text = dr["gold"].ToString();
            }
            con.Close();
        }
        public void myanmar()
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
        public void eng()
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


    }
}
