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
            openFileDialog1.ShowDialog();
            string filepath = openFileDialog1.FileName;
            pictureBox.Image = Image.FromFile(filepath);

        }

      

      

        private void Gold_Load(object sender, EventArgs e)
        {
            con.Open();
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
            con.Close();
        }
    }
}
