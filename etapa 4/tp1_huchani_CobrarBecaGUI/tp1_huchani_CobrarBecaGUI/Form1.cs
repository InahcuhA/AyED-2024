using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1_huchani_CobrarBecaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int v1;
            v1 = int.Parse(textBox1.Text);

            if(textBox1 == " ")
            {

            }
       
            if (v1 >= 19 && ("100,001 - 200,000" == comboBox1.Text || "Más de 200,000" == comboBox1.Text))
            {
                MessageBox.Show ("¡Felicidades!Puedes cobrar la beca");
            }
            else
            {
                MessageBox.Show ("No cumples con los requisitos para cobrar la beca");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
