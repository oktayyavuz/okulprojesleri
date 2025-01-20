using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oktayyavuz_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (bfiyat.Text != ""&& badet.Text != "")
            {
                int fiyat, adet, toplam;
                fiyat = int.Parse(bfiyat.Text);
                adet = int.Parse(badet.Text);
                if (fiyat >= 0 && adet >= 0)
                {
                    toplam = fiyat * adet ;
                    btoplam.Text = toplam.ToString();
                    bfiyat.Text = "";
                    badet.Text = "";

                }
                else
                {
                    MessageBox.Show("Fiyat ve adet 0 dan küçük olamaz.","Hatalı veri!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    bfiyat.Text = "";
                    badet.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tüm kutucukları doldurunuz.", "Eksik veri!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bfiyat.Text = "";
                badet.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cfiyat.Text != "" && cadet.Text != "")
            {
                int fiyat, adet, toplam;
                fiyat = int.Parse(cfiyat.Text);
                adet = int.Parse(cadet.Text);
                if (fiyat >= 0 && adet >= 0)
                {
                    toplam = fiyat * adet;
                    ctoplam.Text = toplam.ToString();
                    cfiyat.Text = "";
                    cadet.Text = "";

                }
                else
                {
                    MessageBox.Show("Fiyat ve adet 0 dan küçük olamaz.", "Hatalı veri!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cfiyat.Text = "";
                    cadet.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tüm kutucukları doldurunuz.", "Eksik veri!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cfiyat.Text = "";
                cadet.Text = "";
            }
        }

    }
}
