using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw1Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //read values
            double hwg = Double.Parse(hwk.Text);
            double qzg = Double.Parse(quz.Text);
            double prg = Double.Parse(prj.Text);
            double exg = Double.Parse(exm.Text);
            double feg = Double.Parse(fex.Text);
            //calculates grade
            double Cal = (hwg*(0.1)) + (qzg*(0.2)) + (prg*(0.25))+(exg*(0.2)) + (feg*(0.25));
            //outputs
            grd.Text = Convert.ToString(Cal);
        }
    }
}
