using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tempConverter
{
    public partial class Temperature : Form
    {
        public Temperature()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double F = 1;
                F = TempConvert.CelsToFaren(Double.Parse(celsius1.Text));
                fahrenheit3.Text = String.Format("{0}", F);
            }
            catch
            {
                MessageBox.Show(" - To convert, first enter the data.\n - Fractional part administered by commas.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double C = 1;
                C = TempConvert.FarenToCels(Double.Parse(fahrenheit1.Text));
                celsius3.Text = String.Format("{0}", C);
            }
            catch
            {
                MessageBox.Show(" - To convert, first enter the data.\n - Fractional part administered by commas.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double F = 1;
                F = TempConvert.FarenToKelv(Double.Parse(fahrenheit2.Text));
                kelvin3.Text = String.Format("{0}", F);
            }
            catch
            {
                MessageBox.Show(" - To convert, first enter the data.\n - Fractional part administered by commas.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double K = 1;
                K = TempConvert.KelvinToFaren(Double.Parse(kelvin1.Text));
                fahrenheit4.Text = String.Format("{0}", K);
            }
            catch
            {
                MessageBox.Show(" - To convert, first enter the data.\n - Fractional part administered by commas.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double С = 1;
                С = TempConvert.CelsToKelvin(Double.Parse(celsius2.Text));
                kelvin4.Text = String.Format("{0}", С);
            }
            catch
            {
                MessageBox.Show(" - To convert, first enter the data.\n - Fractional part administered by commas.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double K = 1;
                K = TempConvert.KelvinToCels(Double.Parse(kelvin2.Text));
                celsius4.Text = String.Format("{0}", K);
            }
            catch
            {
                MessageBox.Show(" - To convert, first enter the data.\n - Fractional part administered by commas.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            celsius1.Text = string.Empty;
            fahrenheit1.Text = string.Empty;
            fahrenheit2.Text = string.Empty;
            kelvin1.Text = string.Empty;
            celsius2.Text = string.Empty;
            kelvin2.Text = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fahrenheit3.Text = string.Empty;
            celsius3.Text = string.Empty;
            kelvin3.Text = string.Empty;
            fahrenheit4.Text = string.Empty;
            kelvin4.Text = string.Empty;
            celsius4.Text = string.Empty;          
        }

    }
}
