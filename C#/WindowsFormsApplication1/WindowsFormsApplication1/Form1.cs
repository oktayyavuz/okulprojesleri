using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yazili1, yazili2;
            yazili1 = int.Parse(textBox1.Text);
            yazili2 = int.Parse(textBox2.Text);
            int ortalama = (yazili1+yazili2)/2;


            if (yazili1 >= 0 && yazili2 >= 0) {

                if (yazili1 <= 100 && yazili2 <= 100)
                {

                    if (ortalama >= 50 && ortalama <= 100)
                    {
                        textBox4.Text = "Geçti";
                        textBox3.Text = ortalama.ToString();
                    }
                    else if (ortalama >= 0 && ortalama <= 49)
                    {
                        textBox4.Text = "Kaldı";
                        textBox3.Text = ortalama.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                }
                else {
                    MessageBox.Show("Sınav sonucu 100 den büyük olamaz.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            
            }
            else
            {
                MessageBox.Show("Sınav sonucu 0 dan küçük olamaz.");
                textBox1.Text = "";
                textBox2.Text = "";
            }

        }


    }
}
