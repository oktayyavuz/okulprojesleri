using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace userlogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yevmiye.Text != "" && gunsayisi.Text != ""&& kesinti.Text != "")
            {
                int yev, gun, brut, kes, net;
                yev = int.Parse(yevmiye.Text);
                gun = int.Parse(gunsayisi.Text);
                kes = int.Parse(kesinti.Text);

                if (yev > 0 && gun > 0 && kes > 0)
                {
                    if (gun > 0 && gun<= 30)
                    {

                        if (kes > 0 && kes <= 100)
                        {

                            brut = yev * gun;
                            net = brut - (brut * kes / 100);
                            brutmaas.Text = brut.ToString();
                            netmaas.Text = net.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Kesinti miktarı 0 ve 1000 aralığında olmalıdır", "Hatalı kesinti hesabı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            yevmiye.Text = "";
                            gunsayisi.Text = "";
                            kesinti.Text = "";
                            yevmiye.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gün sayısı 0 ve 30 gün arasında olmalıdır", "Hatalı ay hesabı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        yevmiye.Text = "";
                        gunsayisi.Text = "";
                        kesinti.Text = "";
                        yevmiye.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("0 dan az veri girilemez", "Hatalı veri!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    yevmiye.Text = "";
                    gunsayisi.Text = "";
                    kesinti.Text = "";
                    yevmiye.Focus();
                
                }

            }
            else
            {
                MessageBox.Show("Eksik bilgi girişi gerçekleşti tüm kutuları doldurun", "Eksik veri!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                yevmiye.Text = "";
                gunsayisi.Text = "";
                kesinti.Text = "";
                yevmiye.Focus();
            }
        }
    }
}
