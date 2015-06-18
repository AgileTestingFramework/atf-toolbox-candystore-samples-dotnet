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
    public partial class Distance : Form
    {
        public Distance()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double Foot = 1;
                Foot = DistConvert.MeterToFoot(Double.Parse(meter1.Text));
                foot2.Text = String.Format("{0}", Foot);
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
                double Metr = 1;
                Metr = DistConvert.FootToMeter(Double.Parse(foot1.Text));
                meter3.Text = String.Format("{0}", Metr);
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
                double Yard = 1;
                Yard = DistConvert.MeterToYard(Double.Parse(meter2.Text));
                yard2.Text = String.Format("{0}", Yard);
            }
            catch
            {
                MessageBox.Show(" - To convert, first enter the data.\n - Fractional part administered by commas.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double Metr = 1;
                Metr = DistConvert.YardToMeter(Double.Parse(yard1.Text));
                meter4.Text = String.Format("{0}", Metr);
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
                double Mile = 1;
                Mile = DistConvert.KilometToMile(Double.Parse(kilo1.Text));
                mile2.Text = String.Format("{0}", Mile);
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
                double Kilom = 1;
                Kilom = DistConvert.MileToKilomet(Double.Parse(mile1.Text));
                kilo2.Text = String.Format("{0}", Kilom);
            }
            catch
            {
                MessageBox.Show(" - To convert, first enter the data.\n - Fractional part administered by commas.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            meter1.Text = string.Empty;
            foot1.Text = string.Empty;
            meter2.Text = string.Empty;
            yard1.Text = string.Empty;
            kilo1.Text = string.Empty;
            mile1.Text = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foot2.Text = string.Empty;
            meter3.Text = string.Empty;
            yard2.Text = string.Empty;
            meter4.Text = string.Empty;
            mile2.Text = string.Empty;
            kilo2.Text = string.Empty;
        }

    }
}
