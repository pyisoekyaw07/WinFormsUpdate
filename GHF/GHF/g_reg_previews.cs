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
    public partial class g_reg_preview : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");
        public g_reg_preview()
        {
            InitializeComponent();

        }

        private void g_reg_preview_Load(object sender, EventArgs e)
        {
            /*  showdata();*/
        }

        private void showdata()
        {
            try
            {
                con.Open();
                string query = "Select * From reg_gold ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

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
        private void iconButton1_Click(object sender, EventArgs e)
        {

            datefilter();
        }

        public void datefilter()
        {
            con.Open();
            string sql = "SELECT * FROM reg_gold Where Date BETWEEN @date1 and @date2";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@date1", startdate.Value);
            adp.SelectCommand.Parameters.AddWithValue("@date2", enddate.Value);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txt_searchbox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM reg_gold Where SaleVoucher='" + txt_searchbox.Text.ToString() + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            /*            if (dataGridView1.Rows.Count <1)
                        {
                            MessageBox.Show("Product မရှိပါ");
                        }*/
            con.Close();
        }

    }
}



