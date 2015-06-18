using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempConverter
{
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox11.Text = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox12.Text = string.Empty;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double Inch = 1;
                Inch = AreaConvert.SantimToInch(Double.Parse(textBox1.Text));
                textBox2.Text = String.Format("{0}", Inch);
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
                double sMetr = 1;
                sMetr = AreaConvert.InchToSantim(Double.Parse(textBox3.Text));
                textBox4.Text = String.Format("{0}", sMetr);
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
                double Mile = 1;
                Mile = AreaConvert.KilomToMile(Double.Parse(textBox5.Text));
                textBox6.Text = String.Format("{0}", Mile);
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
                double Kilom = 1;
                Kilom = AreaConvert.MileToKilom(Double.Parse(textBox7.Text));
                textBox8.Text = String.Format("{0}", Kilom);
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
                double Acr = 1;
                Acr = AreaConvert.GektToAcr(Double.Parse(textBox9.Text));
                textBox10.Text = String.Format("{0}", Acr);
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
                double Gek = 1;
                Gek = AreaConvert.AcrToGekt(Double.Parse(textBox11.Text));
                textBox12.Text = String.Format("{0}", Gek);
            }
            catch
            {
                MessageBox.Show(" - To convert, first enter the data.\n - Fractional part administered by commas.");
            }
        }
    }
}
