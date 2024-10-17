using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp0_huchani_ConversorTemperaturasGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1;
            v1 = double.Parse(camptext.Text);

            pas_kelvin(v1);
            pas_farenheit(v1);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        void pas_kelvin(double v1)
        {
            num_k.Text = v1 + 273 + " °K";
        }

        void pas_farenheit(double v1)
        {
            num_F.Text = v1 * 18 / 10 + 32 + " °F";
        }
    }
}
