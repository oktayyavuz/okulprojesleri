using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace finalvize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vizetxt.Text != "" && finaltxt.Text != "")
            {
                int vize, final, ortalama;
                vize = int.Parse(vizetxt.Text);
                final = int.Parse(finaltxt.Text);
                if (vize >= 0 && vize <=100 && final >= 0 && final <=100)
                {
                    ortalama = (vize * 40 / 100)+(final * 60 / 100);
                    orttxt.Text = ortalama.ToString();
                    if (final >= 60)
                    {
                        if (ortalama >= 0 && ortalama <= 60)
                        {
                            kgtxt.Text = "Kaldı";
                            harftxt.Text = "FF";
                        }
                        else if (ortalama >= 61 && ortalama <= 70)
                        {
                            kgtxt.Text = "Geçti";
                            harftxt.Text = "DD";
                        }
                        else if (ortalama >= 71 && ortalama <= 80)
                        {
                            kgtxt.Text = "Geçti";
                            harftxt.Text = "CC";
                        }
                        else if (ortalama >= 81 && ortalama <= 90)
                        {
                            kgtxt.Text = "Geçti";
                            harftxt.Text = "BB";
                        }
                        else if (ortalama >= 91 && ortalama <= 100)
                        {
                            kgtxt.Text = "Geçti";
                            harftxt.Text = "AA";
                        }
                        else
                        {
                            MessageBox.Show("Hatalı hesap.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            orttxt.Text = "";
                            finaltxt.Text = "";
                            vizetxt.Text = "";
                        }
                    }
                    else
                    {
                        kgtxt.Text = "Kaldı";
                        MessageBox.Show("Final notun 60 tan düşük olduğu için hükmen kaldın.", "Geçmiş olsun..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vize ve final notu 0 ve 100 aralığında olmalıdır.", "Yanlış bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    finaltxt.Text = "";
                    vizetxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Boş Yerleri Doldurunuz.", "Eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                finaltxt.Text = "";
                vizetxt.Text = "";
            }
        }
    }
}
