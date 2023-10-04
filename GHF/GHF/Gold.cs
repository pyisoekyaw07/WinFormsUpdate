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

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            txt_date.Text = d.ToString("dd/MMM/yyyy");
            txt_time.Text = DateTime.Now.ToLongTimeString();
        }


        private void btn_add_photo_Click(object sender, EventArgs e)
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
        public void cc2()
        {
            /*  con.Open();
              SqlCommand itemcmd = new SqlCommand("Select gold from golditem", con);
              SqlDataAdapter da = new SqlDataAdapter();
              da.SelectCommand = itemcmd;
              DataTable dt = new DataTable();
              da.Fill(dt);
              comboBox3.DataSource = dt;
              comboBox3.DisplayMember = "gold";
              comboBox3.ValueMember = "";

              if (comboBox3.Items.Count > 0)
              {
                  comboBox3.SelectedIndex = -1;
                  comboBox3.SelectedText = "---Select Item---";
              }
              con.Close();*/
        }


        private void comboBox3_Click(object sender, EventArgs e)
        {
            cc();
        }

        private void Gold_Load(object sender, EventArgs e)
        {
            cc();
        }
        public void cc()
        {
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

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
