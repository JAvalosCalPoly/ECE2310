using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject_BMI_2_1
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

        private void Comp_Click(object sender, EventArgs e)
        {
            bool Fver = Int32.TryParse(Ft.Text, out int F);
            bool Inchver = Double.TryParse(In.Text, out double Inch);
            bool Wver = Double.TryParse(Lbs.Text, out double W);
            if (!Fver || !Inchver || !Wver)
            {
                MessageBox.Show("One of you inputs may not be a number\ndouble check and try again");
            }
            if (Fver && Inchver  && Wver)
            {
                if (Math.Min(F, Math.Min(Inch, W)) >= 0)
                {
                    double FtoI = F * 12;
                    double Height = FtoI + Inch;
                    double BMIval = Math.Round(((703 * W) / Height) / Height, 1);
                    BMI.Text = BMIval.ToString();
                    if (BMIval < 18.5)
                    {
                        Hres.Text = "Underwight";
                    }
                    else if (18.5 < BMIval && BMIval < 24.9)
                    {
                        Hres.Text = "Normal Weight";
                    }
                    else if (24.9 < BMIval && BMIval < 29.9)
                    {
                        Hres.Text = "Overweight";
                    }
                    else if (BMIval >= 30)
                    {
                        Hres.Text = "Obese";
                    }
                }
                if (Math.Min(F, Math.Min(Inch, W)) < 0)
                {
                    MessageBox.Show("Please make sure the inputs are not negative...");
                }
            }
        }

        private void Ft_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
