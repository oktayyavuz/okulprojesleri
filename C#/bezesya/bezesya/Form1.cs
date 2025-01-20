using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bezesya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bHesapla_Click(object sender, EventArgs e)
        {
            if (bFiyat.Text != "" && bAdet.Text != ""){

                int fiyat, adet ,tutar;
                fiyat = int.Parse(bFiyat.Text);
                adet = int.Parse(bAdet.Text);
                if (fiyat >0 && adet > 0) {
                    tutar = fiyat * adet;
                    bTutar.Text = tutar.ToString();
                    bFiyat.Text = "";
                    bAdet.Text = "";
                }
                else
                {
                    MessageBox.Show("Fiyat ve adet Geçersiz.","Geçersiz!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    bFiyat.Text = "";
                    bAdet.Text = "";
                }
               
            }
            else
            {
                MessageBox.Show("Fiyat ve adet Girilmedi.", "Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bFiyat.Text = "";
                bAdet.Text = "";
            }
        }

        private void cHesapla_Click(object sender, EventArgs e)
        {
            if (cFiyat.Text != "" && cAdet.Text != "")
            {

                int fiyat, adet, tutar;
                fiyat = int.Parse(cFiyat.Text);
                adet = int.Parse(cAdet.Text);
                if (fiyat > 0 && adet > 0)
                {
                    tutar = fiyat * adet;
                    cTutar.Text = tutar.ToString();
                    bFiyat.Text = "";
                    bAdet.Text = "";
                }
                else
                {
                    MessageBox.Show("Fiyat ve adet Geçersiz.", "Geçersiz Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cFiyat.Text = "";
                    cAdet.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Fiyat ve adet Girilmedi.", "Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cFiyat.Text = "";
                cAdet.Text = "";
            }
        }

        private void tHesapla_Click(object sender, EventArgs e)
        {
            if (bTutar.Text != "" && cTutar.Text != "")
            {

                int btutar, ctutar , toptutar;
                btutar = int.Parse(bTutar.Text);
                ctutar = int.Parse(cTutar.Text);
                toptutar = ctutar + btutar;
                tFiyat.Text = toptutar.ToString();

            }
            else
            {
                MessageBox.Show("Önce ürünlerin fiyatlarını hesaplayın.", "Mantık Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        }








    }

