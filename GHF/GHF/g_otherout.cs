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
    public partial class g_otherout : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");
        public g_otherout()
        {
            InitializeComponent();
            showdata.AutoGenerateColumns = true;
        }

        private void g_otherout_Load(object sender, EventArgs e)
        {
            txt_shop.Text = login.shopvalue;
        }

        private void txt_pur_no_TextChanged(object sender, EventArgs e)
        {
            show();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            if (showdata.Rows.Count > 0)
            {
                try
                {
                    con.Close();
                    con.Open();
                    string sql = "delete from closing_stock where ProductID='" + txt_out_no.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_out_no.Text = "";
                    MessageBox.Show("Product Out Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }

        }

        public void show()
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM closing_stock Where ProductID='" + txt_out_no.Text.ToString() + "'";
                SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    check_shop.Text = dt.Rows[0]["Shop"].ToString();
                    if (check_shop.Text == txt_shop.Text)
                    {
                        showdata.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Product ID Not Found");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            txt_date.Text = d.ToString("dd/MMM/yyyy");
            txt_time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
