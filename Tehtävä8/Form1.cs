using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laske_button_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(paino_textBox.Text);
            pituus = Convert.ToDouble(pituus_textBox.Text);
            double bmi = Math.Round(paino / (pituus * pituus),2);
            if(bmi < 18.5)
            {
                vastaus_label.Text = "Painoindeksisi on: " + bmi;
                vastaus_label.ForeColor = Color.Aqua;
                kuvaus_label.Text = "Alipaino";
                kuvaus_label.ForeColor = Color.Aqua;
                kuvaus_label.Visible = true;
                vastaus_label.Visible = true;
            }
            else if(bmi < 25)
            {
                vastaus_label.Text = "Painoindeksisi on: " + bmi;
                vastaus_label.ForeColor = Color.Green;
                kuvaus_label.Text = "Normaalipaino";
                kuvaus_label.ForeColor = Color.Green;
                kuvaus_label.Visible = true;
                vastaus_label.Visible = true;
            }
            else if (bmi < 40)
            {
                vastaus_label.Text = "Painoindeksisi on: " + bmi;
                vastaus_label.ForeColor = Color.Gold;
                kuvaus_label.Text = "Ylipaino";
                kuvaus_label.ForeColor = Color.Gold;
                kuvaus_label.Visible = true;
                vastaus_label.Visible = true;
            }
            else
            {
                vastaus_label.Text = "Painoindeksisi on: " + bmi;
                vastaus_label.ForeColor = Color.Red;
                kuvaus_label.Text = "Huomattava Ylipaino";
                kuvaus_label.ForeColor = Color.Red;
                kuvaus_label.Visible = true;
                vastaus_label.Visible = true;
            }
        }
    }
}
