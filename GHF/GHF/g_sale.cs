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
    public partial class g_sale : Form
    {
        public g_sale()
        {
            InitializeComponent();
        }
        private void g_sale_Load(object sender, EventArgs e)
        {
            txt_shop.Text = login.shopvalue;
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
