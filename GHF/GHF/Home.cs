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
using Microsoft.Identity.Client;

namespace GHF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void formload(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*  gold1.Hide();
              master1.Hide();*/
            /*this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/
            radioButton1.Checked = true;
            this.WindowState = FormWindowState.Maximized;
        }


        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*  gold1.Show();*/
            /* master1.Hide();*/
            formload(new gform());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*  master1.Show();
              gold1.Hide();*/
            /* panel1.Hide();*/
            formload(new master2());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* panel1.Show();
             master1.Hide();*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            formload(new gform());
        }
        /*-----------------Change language----------------------------------*/
        public static string setvalueformyan = "";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            setvalueformyan = "myanmar";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            setvalueformyan = "eng";
        }
        /*-----------------------------------------------------------------------------*/
    }
}
