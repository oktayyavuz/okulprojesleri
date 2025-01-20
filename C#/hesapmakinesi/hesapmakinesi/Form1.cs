using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hesapmakinesi
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

        private void topbtn_Click(object sender, EventArgs e)
        {
            if (sayi1txt.Text != "" && sayi2txt.Text != "")
            {
                int sayi1, sayi2, sonuc;

                sayi1 = int.Parse(sayi1txt.Text);
                sayi2 = int.Parse(sayi2txt.Text);
                sonuc = sayi1 + sayi2;
                sonuctxt.Text = sonuc.ToString();
                sayi1txt.Text = "";
                sayi2txt.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Kutucukları Doldurun!","Boş Kutu",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            }
        }

        private void cikbtn_Click(object sender, EventArgs e)
        {
            if (sayi1txt.Text != "" && sayi2txt.Text != "")
            {
                int sayi1, sayi2, sonuc;

                sayi1 = int.Parse(sayi1txt.Text);
                sayi2 = int.Parse(sayi2txt.Text);
                sonuc = sayi1 - sayi2;
                sonuctxt.Text = sonuc.ToString();
                sayi1txt.Text = "";
                sayi2txt.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Kutucukları Doldurun!", "Boş Kutu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
        }

        private void carpbtn_Click(object sender, EventArgs e)
        {
            if (sayi1txt.Text != "" && sayi2txt.Text != "")
            {
                int sayi1, sayi2, sonuc;

                sayi1 = int.Parse(sayi1txt.Text);
                sayi2 = int.Parse(sayi2txt.Text);
                sonuc = sayi1 * sayi2;
                sonuctxt.Text = sonuc.ToString();
                sayi1txt.Text = "";
                sayi2txt.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Kutucukları Doldurun!", "Boş Kutu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
        }

        private void bolbtn_Click(object sender, EventArgs e)
        {
            if (sayi1txt.Text != "" && sayi2txt.Text != "")
            {
                int sayi1, sayi2, sonuc;

                sayi1 = int.Parse(sayi1txt.Text);
                sayi2 = int.Parse(sayi2txt.Text);
                sonuc = sayi1 / sayi2;
                sonuctxt.Text = sonuc.ToString();
                sayi1txt.Text = "";
                sayi2txt.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Kutucukları Doldurun!", "Boş Kutu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
        }
    }
}
