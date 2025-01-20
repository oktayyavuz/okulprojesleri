using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace teksayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sayi1txt.Text != "" && sayi2txt.Text != "")
            {
                int sayi1, sayi2;
                sayi1 = int.Parse(sayi1txt.Text);
                sayi2 = int.Parse(sayi2txt.Text);

                for (int i = sayi1; i < sayi2; i++)
                {
                    if (i % 2 != 0 )
                    {
                        sayilarbox.Items.Add(i);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Boş Yerleri Doldurunuz.","Eksik bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
