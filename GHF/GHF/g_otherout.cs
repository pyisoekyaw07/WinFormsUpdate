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
            /* if (showdata.Rows.Count > 0)
             {
                 try
                 {
                     con.Close();
                     con.Open();
                     string sql = "delete from closing_stock where ProductID='" + showdata.Rows[0].Cells[6].Value.ToString() + "'";
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
             }*/


            // Iterate through all rows in the DataGridView
            for (int i = store_data.Rows.Count - 1; i >= 0; i--)
            {
                // Extract the value from cell at column index 2 (assuming 0-based index)
                string valueToCheck = store_data.Rows[i].Cells[6].Value.ToString();

                // Delete the row if the value matches
                if (!string.IsNullOrEmpty(valueToCheck))
                {
                    // Delete from database
                    DeleteRowFromDatabase(valueToCheck);

                    // Remove row from DataGridView
                    store_data.Rows.RemoveAt(i);
                }
            }
        }
        private void DeleteRowFromDatabase(string value)
        {
            con.Close();
            {
                con.Open();

                // Construct SQL DELETE query
                string query = "DELETE FROM closing_stock WHERE ProductID = @Value";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Value", value);

                    // Execute the DELETE query
                    command.ExecuteNonQuery();
                }
            }
        }


        public void show()
        {
            con.Close();
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


        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void ico_add_btn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < store_data.Rows.Count; i++)
            {
                if (txt_out_no.Text == store_data.Rows[i].Cells[6].Value.ToString())
                {
                    MessageBox.Show("Already have data insert!");
                    return;
                }
            }

            try
            {

                string date, time, OutVoucher, Outremark, purvoc, barcode, goldtype, gold_price, items, itemname,
                gm, k, p, y, s, wk, wp, wy, ws, totalk, totalp, totaly, totals, mcost, repamt, totalamt, remark,
                 employee, shop, form, type;

                date = txt_date.Text; time = txt_time.Text;
                OutVoucher = txt_outvoucher.Text; Outremark = txt_outremark.Text;
                employee = Form2.setvalueemployee;
                shop = login.shopvalue;
                form = txt_form.Text;
                type = txt_counter.Text;


                int no = 0;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(store_data);
                newRow.Cells[1].Value = date;

                /*Add To Store Table for Save
                /*store_data.Rows[selectedRowIndex].Cells[0].Value = img;*/
                newRow.Cells[1].Value = date;
                newRow.Cells[2].Value = time;
                newRow.Cells[3].Value = OutVoucher;
                newRow.Cells[4].Value = Outremark;
                newRow.Cells[5].Value = showdata.Rows[0].Cells[5].Value.ToString();
                newRow.Cells[6].Value = showdata.Rows[0].Cells[6].Value.ToString();
                newRow.Cells[7].Value = showdata.Rows[0].Cells[7].Value.ToString();
                newRow.Cells[8].Value = showdata.Rows[0].Cells[8].Value.ToString();
                newRow.Cells[9].Value = showdata.Rows[0].Cells[9].Value.ToString();
                newRow.Cells[10].Value = showdata.Rows[0].Cells[10].Value.ToString();
                newRow.Cells[11].Value = showdata.Rows[0].Cells[11].Value.ToString();
                newRow.Cells[12].Value = showdata.Rows[0].Cells[12].Value.ToString();
                newRow.Cells[13].Value = showdata.Rows[0].Cells[13].Value.ToString();
                newRow.Cells[14].Value = showdata.Rows[0].Cells[14].Value.ToString();
                newRow.Cells[15].Value = showdata.Rows[0].Cells[15].Value.ToString();
                newRow.Cells[16].Value = showdata.Rows[0].Cells[16].Value.ToString();
                newRow.Cells[17].Value = showdata.Rows[0].Cells[17].Value.ToString();
                newRow.Cells[18].Value = showdata.Rows[0].Cells[18].Value.ToString();
                newRow.Cells[19].Value = showdata.Rows[0].Cells[19].Value.ToString();
                newRow.Cells[20].Value = showdata.Rows[0].Cells[20].Value.ToString();
                newRow.Cells[21].Value = showdata.Rows[0].Cells[21].Value.ToString();
                newRow.Cells[22].Value = showdata.Rows[0].Cells[22].Value.ToString();
                newRow.Cells[23].Value = showdata.Rows[0].Cells[23].Value.ToString();
                newRow.Cells[24].Value = showdata.Rows[0].Cells[24].Value.ToString();
                newRow.Cells[25].Value = showdata.Rows[0].Cells[25].Value.ToString();
                newRow.Cells[26].Value = showdata.Rows[0].Cells[26].Value.ToString();
                newRow.Cells[27].Value = showdata.Rows[0].Cells[27].Value.ToString();
                newRow.Cells[28].Value = employee;
                newRow.Cells[29].Value = shop;
                newRow.Cells[30].Value = form;
                newRow.Cells[31].Value = type;

                store_data.Rows.Add(newRow);

                txt_out_no.Text = "";
                showdata.DataSource = null;
                Totalamt2();
                Totalgm2();
                Totalgm2();
            }

            catch
            {

            }

        }

        public void Totalamt2()
        {
            decimal amt = 0;
            for (int i = 0; i < store_data.Rows.Count; ++i)
            {
                amt += Convert.ToDecimal(store_data.Rows[i].Cells[26].Value);
                lbl_totalamt.Text = amt.ToString();
            }
        }
        public void Totalgm2()
        {
            decimal amt = 0;
            for (int i = 0; i < store_data.Rows.Count; ++i)
            {
                amt += Convert.ToDecimal(store_data.Rows[i].Cells[11].Value);
                lbl_gm.Text = amt.ToString();
            }
        }
        public void Totalqty2()
        {
            lbl_qty.Text = store_data.Rows.Count.ToString();
        }

    }

    
}
