using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace restoranProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void hmbgreksi_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(hmbgrtxt.Text);
            if (sayi >= 1)
            {
                sayi--;
                hmbgrtxt.Text = sayi.ToString();
            }
            else
            {
                MessageBox.Show("Adet 0'dan az olamaz.");
            }
        }

        private void pizzaeksi_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(pizzatxt.Text);
            if (sayi >= 1)
            {
                sayi--;
                pizzatxt.Text = sayi.ToString();
            }
            else
            {
                MessageBox.Show("Adet 0'dan az olamaz.");
            }
        }

        private void donereksi_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(donertxt.Text);
            if (sayi >= 1)
            {
                sayi--;
                donertxt.Text = sayi.ToString();
            }
            else
            {
                MessageBox.Show("Adet 0'dan az olamaz.");
            }
        }

        private void kvrmeksi_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(kvrmtxt.Text);
            if (sayi >= 1)
            {
                sayi--;
                kvrmtxt.Text = sayi.ToString();
            }
            else
            {
                MessageBox.Show("Adet 0'dan az olamaz.");
            }
        }

        private void crbeksi_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(crbtxt.Text);
            if (sayi >= 1)
            {
                sayi--;
                crbtxt.Text = sayi.ToString();
            }
            else
            {
                MessageBox.Show("Adet 0'dan az olamaz.");
            }
        }

        private void cayeksi_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(caytxt.Text);
            if (sayi >= 1)
            {
                sayi--;
                caytxt.Text = sayi.ToString();
            }
            else
            {
                MessageBox.Show("Adet 0'dan az olamaz.");
            }
        }

        private void khveksi_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(khvtxt.Text);
            if (sayi >= 1)
            {
                sayi--;
                khvtxt.Text = sayi.ToString();
            }
            else
            {
                MessageBox.Show("Adet 0'dan az olamaz.");
            }
        }

        private void hmbgrarti_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(hmbgrtxt.Text);
            sayi++;
            hmbgrtxt.Text = sayi.ToString();
        }

        private void pizzaarti_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(pizzatxt.Text);
            sayi++;
            pizzatxt.Text = sayi.ToString();
        }

        private void donerarti_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(donertxt.Text);
            sayi++;
            donertxt.Text = sayi.ToString();
        }

        private void kvrmarti_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(kvrmtxt.Text);
            sayi++;
            kvrmtxt.Text = sayi.ToString();
        }

        private void crbarti_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(crbtxt.Text);
            sayi++;
            crbtxt.Text = sayi.ToString();
        }

        private void cayarti_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(caytxt.Text);
            sayi++;
            caytxt.Text = sayi.ToString();
        }

        private void khvarti_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(caytxt.Text);
            sayi++;
            caytxt.Text = sayi.ToString();
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            int hmbgradet, hmbgrfiyat, hmbgrtutar, pizzaadet, pizzafiyat, pizzatutar, doneradet, donerfiyat , donertutar , kvrmadet, kvrmfiyat , kvrmtutar , crbadet, crbfiyat , crbtutar , cayadet, cayfiyat , caytutar ,khvadet , khvfiyat , khvtutar ;

            hmbgradet = int.Parse(hmbgrtxt.Text);
            pizzaadet = int.Parse(pizzatxt.Text);
            doneradet = int.Parse(donertxt.Text);
            kvrmadet = int.Parse(kvrmtxt.Text);
            crbadet = int.Parse(crbtxt.Text);
            cayadet = int.Parse(caytxt.Text);
            khvadet = int.Parse(khvtxt.Text);

            hmbgrfiyat = int.Parse(hmbgrfiyattxt.Text);
            pizzafiyat = int.Parse(pizzafiyattxt.Text);
            donerfiyat = int.Parse(donerfiyattxt.Text);
            kvrmfiyat = int.Parse(kvrmfiyattxt.Text);
            crbfiyat = int.Parse(crbfiyattxt.Text);
            cayfiyat = int.Parse(cayfiyattxt.Text);
            khvfiyat = int.Parse(khvfiyattxt.Text);

            hmbgrtutar = hmbgradet * hmbgrfiyat;
            pizzatutar = pizzaadet * pizzafiyat;
            donertutar = doneradet * donerfiyat;
            kvrmtutar = kvrmadet * kvrmfiyat;
            crbtutar = crbadet * crbfiyat;
            caytutar = cayadet * cayfiyat;
            khvtutar = khvadet * khvfiyat;

            hmbgrttr.Text = hmbgrtutar.ToString();
            pizzattr.Text = pizzatutar.ToString();
            donerttr.Text = donertutar.ToString();
            kvrmttr.Text = kvrmtutar.ToString();
            crbttr.Text = crbtutar.ToString();
            cayttr.Text = caytutar.ToString();
            khvttr.Text = khvtutar.ToString();

            int toplam = hmbgrtutar + pizzatutar + donertutar + kvrmtutar + crbtutar + caytutar + khvtutar;
            toplamttr.Text = toplam.ToString();
        }


    }
}
