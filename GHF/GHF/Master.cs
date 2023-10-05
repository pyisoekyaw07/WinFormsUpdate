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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Win32.SafeHandles;
using Microsoft.VisualBasic.ApplicationServices;

namespace GHF
{
    public partial class Master : System.Windows.Forms.UserControl
    {
        private object connn; /*SQL Connection*/
        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");

        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)/*user control form load*/
        {
            Parentitem_combo.Hide();
            Pan_item.Hide();
            groupBox1.Hide();
        }
        private void Master_Leave(object sender, EventArgs e)/*user control form leave*/
        {
            chk_parent.Checked = false;
            Pan_item.Hide();
            groupBox1.Hide();
            /*comboBox1.Items.Clear();*/
        }
        private void button1_Click(object sender, EventArgs e)/*Save button; insert Item,Goldtype,Source Remark*/

        {
            if (comboBox1.SelectedIndex == 0)/*choose main master type (item/itemname)*/
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
            else if (comboBox1.SelectedIndex == 1)/*choose main master type (GoldType)*/
            {
                if (itemtype_combo.SelectedIndex == 0 && txt_master_item.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into gold_type values('" + txt_master_item.Text + "')";
                    cmd.ExecuteNonQuery();

                    txt_master_item.Text = "";

                    con.Close();
                    MessageBox.Show("Success");
                }
                else if (itemtype_combo.SelectedIndex == 1 && txt_master_item.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into whitegold_type values('" + txt_master_item.Text + "')";
                    cmd.ExecuteNonQuery();

                    txt_master_item.Text = "";

                    con.Close();
                    MessageBox.Show("Success");
                }
                else if (itemtype_combo.SelectedIndex == 2 && txt_master_item.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into gem_type values('" + txt_master_item.Text + "')";
                    cmd.ExecuteNonQuery();

                    txt_master_item.Text = "";

                    con.Close();
                    MessageBox.Show("Success");
                }

            }else if (comboBox1.SelectedIndex == 2)
            {
                if (itemtype_combo.SelectedIndex==0 && txt_master_item.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into gold_price values('" + txt_master_item.Text + "')";
                    cmd.ExecuteNonQuery();

                    txt_master_item.Text = "";

                    con.Close();
                    MessageBox.Show("Success");
                }

            }
            else if (comboBox1.SelectedIndex == 3) /*choose main master type (source remark)*/
            {
                if (txt_master_item.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into source_remark values('" + txt_master_item.Text + "')";
                    cmd.ExecuteNonQuery();

                    txt_master_item.Text = "";

                    con.Close();
                    MessageBox.Show("Success");
                }

            }
            else
            {
                MessageBox.Show("check");
            }


        }
        private void chk_parent_CheckedChanged(object sender, EventArgs e)/*check box*/
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

        private void Parentitem_combo_Click(object sender, EventArgs e)/*insert itemname*/
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)/*choose master input type*/
        {
            if (comboBox1.SelectedIndex == 0)
            {
                groupBox1.Show();
                Pan_item.Show();
                label1.Text = "Item";
                chk_parent.Show();
                itemtype_combo.Show();
                label2.Show();
                groupBox1.Text = "Item";
                itemtype_combo.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                groupBox1.Show();
                label1.Text = "Gold Type";
                chk_parent.Hide();
                Pan_item.Show();
                groupBox1.Text = "Gold Type";
                itemtype_combo.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                groupBox1.Show();
                groupBox1.Text = "Gold Price";
                label1.Text = "Gold Price";
                chk_parent.Hide();
                Pan_item.Show();
                itemtype_combo.Enabled = true;

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                itemtype_combo.Enabled = false;
                label1.Text = "Source Remark";
                groupBox1.Text = "Source Remark";
                groupBox1.Show();
                Pan_item.Show();
                chk_parent.Hide();
            }
        }
    }

}


