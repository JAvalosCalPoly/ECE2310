using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //read and validate inputs
            bool addv1 = Double.TryParse(txtnum1.Text, out double num1);
            bool addv2 = Double.TryParse(txtnum2.Text, out double num2);
            if (addv1 && addv2)
            {
                //calculate result (num1 + num2 = ans)
                double ans = num1 + num2;
                //output result to txtans
                txtans.Text = Convert.ToString(ans);
            } else if (!addv1)
            {
                MessageBox.Show("1st input is invalid. It may not be a number, please re-enter.");
            } else
            {
                MessageBox.Show("2nd input is invalid. It may not be a number, please re-enter.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //read and validate inputs
            bool subv1 = Double.TryParse(txtnum1.Text, out double num1);
            bool subv2 = Double.TryParse(txtnum2.Text, out double num2);
            if (subv1 && subv2)
            {
                //calculate result (num1 - num2 = ans)
                double ans = num1 - num2;
                //output to txtans
                txtans.Text = Convert.ToString(ans);
            } else if (!subv1)
            {
                MessageBox.Show("1st input is invalid. It may not be a number, please re-enter.");
            }
            else
            {
                MessageBox.Show("2nd input is invalid. It may not be a number, please re-enter.");
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            //read and validate inputs
            bool modv1 = Double.TryParse(txtnum1.Text, out double num1);
            bool modv2 = Double.TryParse(txtnum2.Text, out double num2);
            if (modv1 && modv2)
            {
                //calculate result (num1 % num2 = ans)
                double ans = num1 % num2;
                //output to txtans
                txtans.Text = Convert.ToString(ans);
            } else if (!modv1)
            {
                MessageBox.Show("1st input is invalid. It may not be a number, please re-enter.");
            }
            else
            {
                MessageBox.Show("2nd input is invalid. It may not be a number, please re-enter.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtans.Text = "";
        }
    }
}
