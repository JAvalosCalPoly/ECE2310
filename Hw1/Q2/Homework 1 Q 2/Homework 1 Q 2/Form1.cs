using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1_Q_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //converts text to double
            double UserIn = double.Parse(miles.Text);
            //Converts and Rounds
            double km = UserIn * 1.609344;
            km = Math.Round(km,2);
            //outputs
            ans.Text = Convert.ToString(km);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
