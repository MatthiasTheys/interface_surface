using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace int_surface
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

            Thread.Sleep(1000);

            this.Close();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

            Thread.Sleep(1000);

            this.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

            Thread.Sleep(1000);

            this.Close();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

            Thread.Sleep(1000);

            this.Close();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

            Thread.Sleep(1000);
            this.Dispose();
        }
    }
}
