using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oktayyavuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a, b;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            int toplam = a + b;

            textBox3.Text = toplam.ToString();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                int a, b;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                int cikar = a - b;

                textBox3.Text = cikar.ToString();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {

                int a, b;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                int carp = a * b;

                textBox3.Text = carp.ToString();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {

                int a, b;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                int bol = a / b;

                textBox3.Text = bol.ToString();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
