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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        public void branch()
        {
            combo_shop.Items.Clear();
            string sqlquery = "select * from shop";
            SqlCommand cmd = new SqlCommand(sqlquery, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo_shop.Items.Add(reader["Branchname"].ToString());
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

        private void comboBox1_Click(object sender, EventArgs e)
        {
            branch();
        }

        public static string shoptext = "";
        public static string username = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (combo_shop.SelectedIndex == 0 && txt_username.Text == "flyer" && txt_password.Text == "admin")
            {
                this.Hide();
                shoptext = combo_shop.Text;
                username = txt_username.Text;
                Form2 frm2 = new Form2();
                frm2.Show();
                combo_shop.Text = "";
                txt_username.Text = "";
                txt_password.Text = "";
            }
            else
            {
                MessageBox.Show("check");
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
