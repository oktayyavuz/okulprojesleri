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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adsoyadtxt.Text != "" && tcnotxt.Text != "" && teltxt.Text != "" && epostatxt.Text != "" && adresstxt.Text != "")
            {
                String adsoyad, eposta,tcno,telno, adress;
                adsoyad = adsoyadtxt.Text;
                eposta = epostatxt.Text;
                tcno = tcnotxt.Text;
                telno = teltxt.Text;
                adress = adresstxt.Text;

                MessageBox.Show("Adı soyadı: " +adsoyad+ "\nEposta Adresi: " +eposta+ "\nTc Kimlik numarası: " +tcno+ "\nTelefon Numarası: " +telno+ "\nAdress: " +adress , "Kaydedilsin mi?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Lütfen tüm kutucukları doldurunuz.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
