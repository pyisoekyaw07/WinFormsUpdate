using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GHF
{
    public partial class payment_form : Form
    {
       
        public payment_form()
        {
            InitializeComponent();
        }

        private void cash_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = true;
            foreign_group.Visible = false;
            Bank_group.Visible = false;
            Mobile_group.Visible = false;

        }

        private void bank_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = false;
            foreign_group.Visible = false;
            Bank_group.Visible = true;
            Mobile_group.Visible = false;
        }

        private void foreign_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = false;
            foreign_group.Visible = true;
            Bank_group.Visible = false;
            Mobile_group.Visible = false;
        }

        private void MB_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = false;
            foreign_group.Visible = false;
            Bank_group.Visible = false;
            Mobile_group.Visible = true;
        }

        private void payment_form_Load(object sender, EventArgs e)
        {
            cash_rdo_btn.Checked=true;
        }
    }
}
