using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp4_huchani_CreadorPersonajeRol
{
    public partial class Form2 : Form
    {

        public Form2(string recepcionTexto1, string recepcionTexto2, string raza, bool check1, bool check2, bool check3)
        {
            InitializeComponent();
            label1.Text = recepcionTexto1;
            label2.Text = recepcionTexto2;
            label7.Text = raza;
            label9.Visible = check1;
            label10.Visible = check2;
            label11.Visible = check3;

            if (check1)
            {
                label9.Text = "invisibilidad";
            }
            if (check2)
            {
                label10.Text = "Fuerza Sobrehumana";
            }
            if (check3)
            {
                label11.Text = "Curación Rápida";
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 win1 = new Form1();

            win1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
