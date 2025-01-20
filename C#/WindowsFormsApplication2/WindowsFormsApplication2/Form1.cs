using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            if (vizebox.Text != "" && finalbox.Text != "")
            {
                int vize, final;
                vize = int.Parse(vizebox.Text);
                final = int.Parse(finalbox.Text);

                int ortalama = (vize * 40 / 100) + (final * 60 / 100);


                if (vize >= 0 && final >= 0)
                {

                    if (vize <= 100 && final <= 100)
                    {
                        if (final > 50)
                        {

                            if (ortalama >= 0 && ortalama <= 40)
                            {
                                kgbox.Text = "Kaldı";
                                ortbox.Text = ortalama.ToString();
                                harfbox.Text = "FF";
                            }
                            else if (ortalama >= 41 && ortalama <= 60)
                            {
                                kgbox.Text = "Kaldı";
                                ortbox.Text = ortalama.ToString();
                                harfbox.Text = "DD";
                            }
                            else if (ortalama >= 61 && ortalama <= 80)
                            {
                                kgbox.Text = "Geçti";
                                ortbox.Text = ortalama.ToString();
                                harfbox.Text = "CC";
                            }
                            else if (ortalama >= 81 && ortalama <= 90)
                            {
                                kgbox.Text = "Geçti";
                                ortbox.Text = ortalama.ToString();
                                harfbox.Text = "BB";
                            }
                            else if (ortalama >= 91 && ortalama <= 100)
                            {
                                kgbox.Text = "Geçti";
                                ortbox.Text = ortalama.ToString();
                                harfbox.Text = "AA";
                            }
                            else
                            {
                                MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                                vizebox.Text = "";
                                finalbox.Text = "";
                            }
                        }
                        else
                        {
                            kgbox.Text = "Kaldı";
                            ortbox.Text = ortalama.ToString();
                            harfbox.Text = "---";
                            MessageBox.Show("Finalde 50 puanı geçemediğniz için kaldınız.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sınav sonucu 100 den büyük olamaz.");
                        vizebox.Text = "";
                        finalbox.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Sınav sonucu 0 dan küçük olamaz.");
                    vizebox.Text = "";
                    finalbox.Text = "";
                }
            }
            else {
                MessageBox.Show("Kutulardan biri veya ikisi birden boş.");
                vizebox.Text = "";
                finalbox.Text = "";
            
            }
        }


    }
}
