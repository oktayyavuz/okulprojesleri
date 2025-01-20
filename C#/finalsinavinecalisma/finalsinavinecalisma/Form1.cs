using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace finalsinavinecalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;
            username = "oktay";
            password = "12345";

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                String girilenkadi , girilenpass;
                girilenkadi = textBox1.Text;
                girilenpass = textBox2.Text;

                if (girilenkadi== username && girilenpass == password)
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hatalı veri", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Kutucukları doldurunuz." , "Eksik bilgi" , MessageBoxButtons.OKCancel , MessageBoxIcon.Exclamation );
            }
        }
    }
}
