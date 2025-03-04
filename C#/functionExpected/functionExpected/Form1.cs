using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace functionExpected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eksikVeri()
        {
            String mesaj, hata;
            mesaj = "Lütfen Tüm Kutucukları doldurunuz.";
            hata = "EKSİK VERİ";
            MessageBoxButtons ok = MessageBoxButtons.OK;
            MessageBoxIcon error = MessageBoxIcon.Error;
            MessageBox.Show(mesaj, hata, ok, error);
        }


        private void checkBoxChecked()
        {
            String mesaj, hata;
            mesaj = "1000 TL eş yardımı yapılacaktır.";
            hata = "Bilgi";
            MessageBoxButtons ok = MessageBoxButtons.OK;
            MessageBoxIcon info = MessageBoxIcon.Information;
            MessageBox.Show(mesaj, hata, ok, info);
        }


        private void gunSayisi()
        {
            String mesaj, hata;
            mesaj = "Gün sayısı 0 ve 30 gün aralığında olmak zorunda";
            hata = "Hatalı veri!";
            MessageBoxButtons ok = MessageBoxButtons.OK;
            MessageBoxIcon war = MessageBoxIcon.Warning;
            MessageBox.Show(mesaj, hata, ok, war);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxChecked();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                int gun, yev, toplam;
                yev = int.Parse(textBox2.Text);
                gun = int.Parse(textBox3.Text);

                if (gun > 0 && gun <= 30)
                {
                    if (checkBox1.Checked)
                    {
                        toplam = yev * gun + 1000;
                    }
                    else
                    {
                        toplam = yev * gun;
                    }
                    textBox4.Text = toplam.ToString();
                }
                else
                {
                    gunSayisi();
                }
            }
            else
            {
                eksikVeri();
            }
        }
    }
}
