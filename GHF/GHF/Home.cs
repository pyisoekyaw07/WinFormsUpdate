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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gold1.Hide();
            master1.Hide();
            /*this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/
            this.WindowState = FormWindowState.Maximized;
          

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gold1.Show();
            master1.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            master1.Show();
            gold1.Hide();
            panel1.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Show();
            master1.Hide();

        }
    }
}
