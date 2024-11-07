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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);

            string result = ("en este año (2024), tienes o tendras" + (2024 - year) + " años." );

            label2.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 win1 = new Form1();
            win1.Show();
            this.Close();
        }
    
    }
}
