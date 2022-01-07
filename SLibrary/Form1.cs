using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqLibrary;

namespace SLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);
            int c = Convert.ToInt32(textBox4.Text);
            int r = Convert.ToInt32(textBox5.Text);
            Square.triangle(a, b, c);
            Square.circle(r);

        }
    }
}
