using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kucuksayibuyuksayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi1, sayi2;
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                sayi1 = int.Parse(textBox1.Text);
                sayi2 = int.Parse(textBox2.Text);
                if (sayi1 < sayi2)
                {
                    if (radioButton1.Checked == true)
                    {
                        for (int i = sayi1; i <= sayi2; i++)
                        {
                            if (i % 2 != 0)
                            {
                                listBox1.Items.Add(i);
                            }
                        }
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        int i = sayi1;
                        while (i <= sayi2)
                        {
                            if (i % 2 != 0)
                            {
                                listBox1.Items.Add(i);
                            }
                            i++;
                        }
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir işlem türü seçiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("1. sayı küçük olmalıdır.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm kutuları doldurunuz.");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
