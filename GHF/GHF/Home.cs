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
            /*formload(new wallpaper());*/
            panel1.Show();
            panel1.BackColor = Color.White;
            /*lbl_username.Text = login.username;*/
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
            panel1.Hide();
            formload(new master2());

        }



        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Show();
            formload(new wallpaper());
            panel1.BackColor = Color.White;



        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
        /*-----------------Change language----------------------------------*/
        public static string setvalueformyan = "";

        private void radioButton1_Click(object sender, EventArgs e)
        {
            setvalueformyan = "myanmar";
            gform.language = setvalueformyan;

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            setvalueformyan = "eng";
            gform.language = setvalueformyan;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login showlogin = new login();
            showlogin.Show();
        }


        /*-----------------------------------------------------------------------------*/
    }
}
