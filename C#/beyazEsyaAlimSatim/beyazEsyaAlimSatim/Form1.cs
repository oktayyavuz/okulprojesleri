using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace beyazEsyaAlimSatim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((buzFiyat.Text != "" && buzAdet.Text != "") ||
                (camFiyat.Text != "" && camAdet.Text != "") ||
                (bulFiyat.Text != "" && bulAdet.Text != "") ||  
                (firFiyat.Text != "" && firAdet.Text != ""))
            {
                int toplam = 0;
                if (buzFiyat.Text != "" && buzAdet.Text != "")
                {
                    int buzfiyat = int.Parse(buzFiyat.Text);
                    int buzadet = int.Parse(buzAdet.Text);
                    if (buzadet < 0 || buzadet > 50)
                    {
                        aciklamalbl.Text = "Buzdolabı adedi 0 ile 50 arasında olmalıdır.";
                        return;
                    }
                    int buztutar = (buzIsc.Checked)
                        ? buzfiyat * buzadet - (buzfiyat * buzadet * 10 / 100)
                        : buzfiyat * buzadet;
                    buzTutar.Text = buztutar.ToString();
                    toplam += buztutar;
                }
                if (camFiyat.Text != "" && camAdet.Text != "")
                {
                    int camfiyat = int.Parse(camFiyat.Text);
                    int camadet = int.Parse(camAdet.Text);
                    if (camadet < 0 || camadet > 50)
                    {
                        aciklamalbl.Text = "Çamaşır Makinesi adedi 0 ile 50 arasında olmalıdır.";
                        return;
                    }
                    int camtutar = (camIsc.Checked)
                        ? camfiyat * camadet - (camfiyat * camadet * 10 / 100)
                        : camfiyat * camadet;
                    camTutar.Text = camtutar.ToString();
                    toplam += camtutar;
                }
                if (bulFiyat.Text != "" && bulAdet.Text != "")
                {
                    int bulfiyat = int.Parse(bulFiyat.Text);
                    int buladet = int.Parse(bulAdet.Text);
                    if (buladet < 0 || buladet > 50)
                    {
                        aciklamalbl.Text = "Bulaşık makinesi adedi 0 ile 50 arasında olmalıdır.";
                        return;
                    }
                    int bultutar = (bulIsc.Checked)
                        ? bulfiyat * buladet - (bulfiyat * buladet * 10 / 100)
                        : bulfiyat * buladet;
                    bulTutar.Text = bultutar.ToString();
                    toplam += bultutar;
                }
                if (firFiyat.Text != "" && firAdet.Text != "")
                {
                    int firfiyat = int.Parse(firFiyat.Text);
                    int firadet = int.Parse(firAdet.Text);
                    if (firadet < 0 || firadet > 50)
                    {
                        aciklamalbl.Text = "Fırın adedi 0 ile 50 arasında olmalıdır.";
                        return;
                    }
                    int firtutar = (firIsc.Checked)
                        ? firfiyat * firadet - (firfiyat * firadet * 10 / 100)
                        : firfiyat * firadet;
                    firTutar.Text = firtutar.ToString();
                    toplam += firtutar;
                }
                Top.Text = toplam.ToString();
                listBox1.Items.Add(toplam);
            }
            else
            {
                aciklamalbl.Text = "Lütfen en az 1 veri giriniz.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buzFiyat.Text = "";
            buzAdet.Text = "";
            buzIsc.Checked = false;
            buzTutar.Text = "0";
            camFiyat.Text = "";
            camAdet.Text = "";
            camIsc.Checked = false;
            camTutar.Text = "0";
            bulFiyat.Text = "";
            bulAdet.Text = "";
            bulIsc.Checked = false;
            bulTutar.Text = "0";
            firFiyat.Text = "";
            firAdet.Text = "";
            firIsc.Checked = false;
            firTutar.Text = "0";
            Top.Text = "";
            

        }
    }
}
