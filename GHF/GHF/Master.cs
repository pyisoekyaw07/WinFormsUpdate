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
using System.Windows.Controls;

namespace GHF
{
    public partial class Master : System.Windows.Forms.UserControl
    {
        private object connn;
        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");

        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            Parentitem_combo.Hide();
            Pan_item.Hide();
        }
        private void Master_Leave(object sender, EventArgs e)
        {
            chk_parent.Checked = false;
            Pan_item.Hide();
        }
        private void button1_Click(object sender, EventArgs e)

        {
            if (itemtype_combo.SelectedIndex == 0 && txt_master_item.Text != "" && chk_parent.Checked == false)
            {
                con.Open();
                SqlCommand goldcmd = new SqlCommand("insert into golditem values(@gold)", con);
                goldcmd.Parameters.AddWithValue("@gold", txt_master_item.Text);
                goldcmd.ExecuteNonQuery();
                {
                    MessageBox.Show("success");
                    txt_master_item.Text = "";
                }
                con.Close();
            }
            else if (itemtype_combo.SelectedIndex == 1 && txt_master_item.Text != "" && chk_parent.Checked == false)
            {
                con.Open();
                SqlCommand goldcmd = new SqlCommand("insert into whitegold_item values(@whitegold)", con);
                goldcmd.Parameters.AddWithValue("@whitegold", txt_master_item.Text);
                goldcmd.ExecuteNonQuery();
                {
                    MessageBox.Show("success");
                    txt_master_item.Text = "";
                }
                con.Close();
            }
            else if (itemtype_combo.SelectedIndex == 2 && txt_master_item.Text != "" && chk_parent.Checked == false)
            {
                con.Open();
                SqlCommand goldcmd = new SqlCommand("insert into gems_item values(@gems)", con);
                goldcmd.Parameters.AddWithValue("@gems", txt_master_item.Text);
                goldcmd.ExecuteNonQuery();
                {
                    MessageBox.Show("success");
                    txt_master_item.Text = "";
                }
                con.Close();

            }
            else if (itemtype_combo.SelectedIndex == 0 && txt_master_item.Text != "" && chk_parent.Checked == true)
            {
                con.Open();
                SqlCommand goldcmd = new SqlCommand("insert into gold_itemname values(@Item,@Itemname)", con);
                goldcmd.Parameters.AddWithValue("@Item", Parentitem_combo.Text);
                goldcmd.Parameters.AddWithValue("@Itemname", txt_master_item.Text);
                goldcmd.ExecuteNonQuery();
                {
                    MessageBox.Show("success");
                    txt_master_item.Text = "";
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Check Item");
            }

        }
        private void chk_parent_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_parent.Checked)
            {
                Parentitem_combo.Show();
            }
            else
            {
                Parentitem_combo.Hide();
            }
        }
        private void btn_item_Click(object sender, EventArgs e)
        {
            Pan_item.Show();
            label1.Text = "Item";
            chk_parent.Show();
            itemtype_combo.Show();
            label2.Show();
        }

        private void Parentitem_combo_Click(object sender, EventArgs e)
        {
            if (itemtype_combo.SelectedIndex == 0)
            {
                con.Open();
                SqlCommand itemcmd = new SqlCommand("Select gold from golditem", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = itemcmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Parentitem_combo.DataSource = dt;
                Parentitem_combo.DisplayMember = "gold";
                Parentitem_combo.ValueMember = "";
                if (Parentitem_combo.Items.Count > 0)
                {
                    Parentitem_combo.SelectedIndex = -1;
                    Parentitem_combo.SelectedText = "---Select Item---";
                }
                con.Close();
            }
            else if (itemtype_combo.SelectedIndex == 1)
            {
                con.Open();
                SqlCommand itemcmd = new SqlCommand("Select whitegold from whitegold_item", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = itemcmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Parentitem_combo.DataSource = dt;
                Parentitem_combo.DisplayMember = "whitegold";
                Parentitem_combo.ValueMember = "";

                if (Parentitem_combo.Items.Count > 0)
                {
                    Parentitem_combo.SelectedIndex = -1;
                    Parentitem_combo.SelectedText = "---Select Item---";
                }
                con.Close();
            }
            else if (itemtype_combo.SelectedIndex == 2)
            {
                con.Open();
                SqlCommand itemcmd = new SqlCommand("Select gems from gems_item", con);
                SqlDataAdapter dc = new SqlDataAdapter();
                dc.SelectCommand = itemcmd;
                DataTable dt = new DataTable();
                dc.Fill(dt);
                Parentitem_combo.DataSource = dt;
                Parentitem_combo.DisplayMember = "gems";
                Parentitem_combo.ValueMember = "";
                if (Parentitem_combo.Items.Count > 0)
                {
                    Parentitem_combo.SelectedIndex = -1;
                    Parentitem_combo.SelectedText = "---Select Item---";
                }
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Gold Type";
            chk_parent.Hide();
            itemtype_combo.Hide();
            label2.Hide();
        }
    }

}


