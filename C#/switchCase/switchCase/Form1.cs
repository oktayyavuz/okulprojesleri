using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace switchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kucukSayi, buyukSayi;
            string secenek;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (int.TryParse(textBox1.Text, out kucukSayi) && int.TryParse(textBox2.Text, out buyukSayi))
                {
                    secenek = textBox3.Text;
                    listBox1.Items.Clear();
                    switch (secenek)
                    {
                        case "for":
                            for (int i = kucukSayi; i <= buyukSayi; i++)
                            {
                                if (i % 2 != 0)
                                {
                                    listBox1.Items.Add(i);
                                }
                            }
                            break;
                        case "while":
                            int sayi = kucukSayi;
                            while (sayi <= buyukSayi)
                            {
                                if (sayi % 2 != 0)
                                {
                                    listBox1.Items.Add(sayi);
                                }
                                sayi++;
                            }
                            break;
                        default:
                            MessageBox.Show("Lütfen geçerli bir seçenek belirtin. e.g. 'for' & 'while'", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            textBox3.Text = "";
                            textBox3.Focus();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen belirtilen kutulara sadece sayı değerlerini giriniz.", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox1.Focus();
                }
                
                
            }
            else
            {
                MessageBox.Show("Lütfen tüm kutuları doldurun.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox1.Focus();
            }

        }
    }
}
