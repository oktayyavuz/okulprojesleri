using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace finalsinavinecalisma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                sayi1 = int.Parse(textBox1.Text);
                sayi2 = int.Parse(textBox2.Text);

                if (radioButton1.Checked == true)
                {
                    int sonuc = sayi1 + sayi2;

                    textBox3.Text = sonuc.ToString();
                }
                else if (radioButton2.Checked == true)
                {
                    int sonuc = sayi1 - sayi2;

                    textBox3.Text = sonuc.ToString();
                }
                else
                {
                    MessageBox.Show("Lütfen bir işlem tipi seçin.", "Seçenek belirtilmedi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Kutucukları doldurunuz.", "Eksik bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
