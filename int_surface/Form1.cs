using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.VisualStyles;

namespace int_surface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

            Thread.Sleep(1000);

            this.Close();
        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

            Thread.Sleep(1000);

            this.Close();

        }
    }
}
