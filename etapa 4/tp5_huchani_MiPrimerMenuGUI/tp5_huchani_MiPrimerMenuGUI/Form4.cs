using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp5_huchani_MiPrimerMenuGUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v2 = int.Parse(textBox1.Text);
            string igual = (v2 + " * 1 = " + v2 * 1) + "\n" +
                (v2 + " * 2 = " + v2 * 2) + "\n" +
                (v2 + " * 3 = " + v2 * 3) + "\n" +
                (v2 + " * 4 = " + v2 * 4) + "\n" +
                (v2 + " * 5 = " + v2 * 5) + "\n" +
                (v2 + " * 6 = " + v2 * 6) + "\n" +
                (v2 + " * 7 = " + v2 * 7) + "\n" +
                (v2 + " * 8 = " + v2 * 8) + "\n" +
                (v2 + " * 9 = " + v2 * 9) + "\n" +
                (v2 + " * 10 = " + v2 * 10) + "\n" ;
            label3.Text = igual;
            
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 win1 = new Form1();
            win1.Show();
            this.Close();
        }
    }
}
