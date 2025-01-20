using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dersislicez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cacik, turlu, pilav, baklava, kunefe;
            cacik = 37;
            turlu = 50;
            pilav = 55;
            baklava =110;
            kunefe = 400;
            int cacikadet,turluadet,pilavadet,baklavaadet,kunefeadet;
            cacikadet = int.Parse(caciklbl.Text);
            turluadet = int.Parse(turlulbl.Text);
            pilavadet = int.Parse(pilavlbl.Text);
            baklavaadet = int.Parse(baklavalbl.Text);
            kunefeadet = int.Parse(kunefelbl.Text);
            if (cacikadet == 0 && turluadet == 0 && pilavadet == 0 && baklavaadet == 0 && kunefeadet == 0)
            {
                MessageBox.Show("En az bir şeyi satın alınız.", "eksik veri", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
            }
            else
            {
                int toplam = cacik * cacikadet + turlu * turluadet + pilav * pilavadet + baklava * baklavaadet + kunefe * kunefeadet;
                textBox6.Text = toplam.ToString();
            }
        }

        private void cacikeksi_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(caciklbl.Text);
            if (i > 0)
            {
                i--;
                caciklbl.Text = i.ToString();
            }
            else
            {
                MessageBox.Show("adet sıfırdan az olamaz.");
            }
        }

        private void cacikarti_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(caciklbl.Text);
            i++;
            caciklbl.Text = i.ToString();
        }

        private void turlueksi_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(turlulbl.Text);
            if (i > 0)
            {
                i--;
                turlulbl.Text = i.ToString();
            }
            else
            {
                MessageBox.Show("adet sıfırdan az olamaz.");
            }
        }


        private void pilaveksi_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(pilavlbl.Text);
            if (i > 0)
            {
                i--;
                pilavlbl.Text = i.ToString();
            }
            else
            {
                MessageBox.Show("adet sıfırdan az olamaz.");
            }

        }

        private void pilavarti_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(pilavlbl.Text);
            i++;
            pilavlbl.Text = i.ToString();
        }

        private void baklavaeksi_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(baklavalbl.Text);
            if (i > 0)
            {
                i--;
                baklavalbl.Text = i.ToString();
            }
            else
            {
                MessageBox.Show("adet sıfırdan az olamaz.");
            }
        }

        private void baklavaarti_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(baklavalbl.Text);
            i++;
            baklavalbl.Text = i.ToString();
        }

        private void kunefeeksi_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(kunefelbl.Text);
            if (i > 0)
            {
                i--;
                kunefelbl.Text = i.ToString();
            }
            else
            {
                MessageBox.Show("adet sıfırdan az olamaz.");
            }
        }

        private void kunefearti_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(kunefelbl.Text);
            i++;
            kunefelbl.Text = i.ToString();
        }

        private void turluarti_Click_1(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(turlulbl.Text);
            i++;
            turlulbl.Text = i.ToString();
        }





    }
}
