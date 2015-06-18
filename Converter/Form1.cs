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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            typeSelect.BeginUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void typeSelect_SelectedIndexChanged(object sender, EventArgs e) // Select categories
        {

            if (typeSelect.SelectedIndex == 0)
            {
                panelSelect.Controls.Clear();
                Temperature tempConverForm = new Temperature(); // Create child form
                tempConverForm.TopLevel = false;
                tempConverForm.Show();
                panelSelect.Controls.Add(tempConverForm);
            }

            if (typeSelect.SelectedIndex == 1)
            {
                panelSelect.Controls.Clear();
                Distance distConverForm = new Distance(); // Create child form
                distConverForm.TopLevel = false;
                distConverForm.Show();
                panelSelect.Controls.Add(distConverForm);
            }

            if (typeSelect.SelectedIndex == 2)
            {
                panelSelect.Controls.Clear();
                Area areaConverForm = new Area(); // Create child form
                areaConverForm.TopLevel = false;
                areaConverForm.Show();
                panelSelect.Controls.Add(areaConverForm);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e) // Open info form
        {
            InfoForm infoDetail = new InfoForm();
            infoDetail.Show();
        }

    }
}