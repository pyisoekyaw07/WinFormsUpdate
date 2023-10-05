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
    public partial class Gold : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");

        public Gold()
        {
            InitializeComponent();
            sourceremark();
            Gtype();
            item();
            goldprice();

        }

        private void timer1_Tick(object sender, EventArgs e)/*Date and Time Format*/
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            txt_date.Text = d.ToString("dd/MMM/yyyy");
            txt_time.Text = DateTime.Now.ToLongTimeString();
           
        }


        private void btn_add_photo_Click(object sender, EventArgs e)/*Photo Upload Button*/
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

        private void comboBox3_Click(object sender, EventArgs e)/*Show Item*/
        {
            item();
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)/*when Item Select get Itemname*/
        {
            comboBox4.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from gold_itemname where Item='" + comboBox3.SelectedItem.ToString() + "'";
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

        private void comboBox2_Click(object sender, EventArgs e)/*show Goldtype*/
        {
            Gtype();
        }
        public void Gtype()/*function Gold type */
        {
            comboBox2.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from gold_type";
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

        private void comboBox1_Click(object sender, EventArgs e)/*show source remark*/
        {
            sourceremark();
          /*  Gtype();
            item();
            goldprice();*/
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
                comboBox1.Items.Add(dr["source_remark"].ToString());
            }
            con.Close();
        }
        public void goldprice()/*function goldprice */
        {
            comboBox1.Items.Clear();
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

    }
}
