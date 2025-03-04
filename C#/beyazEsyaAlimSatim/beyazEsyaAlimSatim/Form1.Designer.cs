namespace beyazEsyaAlimSatim
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buzFiyat = new System.Windows.Forms.TextBox();
            this.camFiyat = new System.Windows.Forms.TextBox();
            this.bulFiyat = new System.Windows.Forms.TextBox();
            this.firFiyat = new System.Windows.Forms.TextBox();
            this.buzAdet = new System.Windows.Forms.TextBox();
            this.camAdet = new System.Windows.Forms.TextBox();
            this.bulAdet = new System.Windows.Forms.TextBox();
            this.firAdet = new System.Windows.Forms.TextBox();
            this.buzIsc = new System.Windows.Forms.CheckBox();
            this.camIsc = new System.Windows.Forms.CheckBox();
            this.bulIsc = new System.Windows.Forms.CheckBox();
            this.firIsc = new System.Windows.Forms.CheckBox();
            this.buzTutar = new System.Windows.Forms.TextBox();
            this.camTutar = new System.Windows.Forms.TextBox();
            this.bulTutar = new System.Windows.Forms.TextBox();
            this.firTutar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Top = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.aciklamalbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(290, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buzdolabı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Çamaşır Mak.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bulaşık Mak.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fırın";
            // 
            // buzFiyat
            // 
            this.buzFiyat.Location = new System.Drawing.Point(101, 60);
            this.buzFiyat.Name = "buzFiyat";
            this.buzFiyat.Size = new System.Drawing.Size(60, 20);
            this.buzFiyat.TabIndex = 0;
            this.buzFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // camFiyat
            // 
            this.camFiyat.Location = new System.Drawing.Point(101, 86);
            this.camFiyat.Name = "camFiyat";
            this.camFiyat.Size = new System.Drawing.Size(60, 20);
            this.camFiyat.TabIndex = 3;
            this.camFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bulFiyat
            // 
            this.bulFiyat.Location = new System.Drawing.Point(101, 112);
            this.bulFiyat.Name = "bulFiyat";
            this.bulFiyat.Size = new System.Drawing.Size(60, 20);
            this.bulFiyat.TabIndex = 6;
            this.bulFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // firFiyat
            // 
            this.firFiyat.Location = new System.Drawing.Point(101, 138);
            this.firFiyat.Name = "firFiyat";
            this.firFiyat.Size = new System.Drawing.Size(60, 20);
            this.firFiyat.TabIndex = 9;
            this.firFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buzAdet
            // 
            this.buzAdet.Location = new System.Drawing.Point(167, 60);
            this.buzAdet.Name = "buzAdet";
            this.buzAdet.Size = new System.Drawing.Size(60, 20);
            this.buzAdet.TabIndex = 1;
            this.buzAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // camAdet
            // 
            this.camAdet.Location = new System.Drawing.Point(167, 86);
            this.camAdet.Name = "camAdet";
            this.camAdet.Size = new System.Drawing.Size(60, 20);
            this.camAdet.TabIndex = 4;
            this.camAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bulAdet
            // 
            this.bulAdet.Location = new System.Drawing.Point(167, 112);
            this.bulAdet.Name = "bulAdet";
            this.bulAdet.Size = new System.Drawing.Size(60, 20);
            this.bulAdet.TabIndex = 7;
            this.bulAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // firAdet
            // 
            this.firAdet.Location = new System.Drawing.Point(167, 138);
            this.firAdet.Name = "firAdet";
            this.firAdet.Size = new System.Drawing.Size(60, 20);
            this.firAdet.TabIndex = 10;
            this.firAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buzIsc
            // 
            this.buzIsc.AutoSize = true;
            this.buzIsc.Location = new System.Drawing.Point(233, 62);
            this.buzIsc.Name = "buzIsc";
            this.buzIsc.Size = new System.Drawing.Size(83, 17);
            this.buzIsc.TabIndex = 2;
            this.buzIsc.Text = "%10 isconto";
            this.buzIsc.UseVisualStyleBackColor = true;
            // 
            // camIsc
            // 
            this.camIsc.AutoSize = true;
            this.camIsc.Location = new System.Drawing.Point(233, 88);
            this.camIsc.Name = "camIsc";
            this.camIsc.Size = new System.Drawing.Size(83, 17);
            this.camIsc.TabIndex = 5;
            this.camIsc.Text = "%10 isconto";
            this.camIsc.UseVisualStyleBackColor = true;
            // 
            // bulIsc
            // 
            this.bulIsc.AutoSize = true;
            this.bulIsc.Location = new System.Drawing.Point(233, 114);
            this.bulIsc.Name = "bulIsc";
            this.bulIsc.Size = new System.Drawing.Size(83, 17);
            this.bulIsc.TabIndex = 8;
            this.bulIsc.Text = "%10 isconto";
            this.bulIsc.UseVisualStyleBackColor = true;
            // 
            // firIsc
            // 
            this.firIsc.AutoSize = true;
            this.firIsc.Location = new System.Drawing.Point(233, 140);
            this.firIsc.Name = "firIsc";
            this.firIsc.Size = new System.Drawing.Size(83, 17);
            this.firIsc.TabIndex = 11;
            this.firIsc.Text = "%10 isconto";
            this.firIsc.UseVisualStyleBackColor = true;
            // 
            // buzTutar
            // 
            this.buzTutar.Enabled = false;
            this.buzTutar.Location = new System.Drawing.Point(331, 59);
            this.buzTutar.Name = "buzTutar";
            this.buzTutar.Size = new System.Drawing.Size(60, 20);
            this.buzTutar.TabIndex = 13;
            this.buzTutar.Text = "0";
            this.buzTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // camTutar
            // 
            this.camTutar.Enabled = false;
            this.camTutar.Location = new System.Drawing.Point(331, 85);
            this.camTutar.Name = "camTutar";
            this.camTutar.Size = new System.Drawing.Size(60, 20);
            this.camTutar.TabIndex = 14;
            this.camTutar.Text = "0";
            this.camTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bulTutar
            // 
            this.bulTutar.Enabled = false;
            this.bulTutar.Location = new System.Drawing.Point(331, 111);
            this.bulTutar.Name = "bulTutar";
            this.bulTutar.Size = new System.Drawing.Size(60, 20);
            this.bulTutar.TabIndex = 15;
            this.bulTutar.Text = "0";
            this.bulTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // firTutar
            // 
            this.firTutar.Enabled = false;
            this.firTutar.Location = new System.Drawing.Point(331, 137);
            this.firTutar.Name = "firTutar";
            this.firTutar.Size = new System.Drawing.Size(60, 20);
            this.firTutar.TabIndex = 16;
            this.firTutar.Text = "0";
            this.firTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tutar";
            // 
            // Top
            // 
            this.Top.Enabled = false;
            this.Top.Location = new System.Drawing.Point(331, 214);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(60, 20);
            this.Top.TabIndex = 17;
            this.Top.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(279, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Toplam";
            // 
            // aciklamalbl
            // 
            this.aciklamalbl.AutoSize = true;
            this.aciklamalbl.Location = new System.Drawing.Point(45, 268);
            this.aciklamalbl.Name = "aciklamalbl";
            this.aciklamalbl.Size = new System.Drawing.Size(50, 13);
            this.aciklamalbl.TabIndex = 4;
            this.aciklamalbl.Text = "Açıklama";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(412, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 238);
            this.listBox1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Font = new System.Drawing.Font("Impact", 8.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(290, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(568, 306);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.aciklamalbl);
            this.Controls.Add(this.firIsc);
            this.Controls.Add(this.bulIsc);
            this.Controls.Add(this.camIsc);
            this.Controls.Add(this.buzIsc);
            this.Controls.Add(this.firAdet);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.firTutar);
            this.Controls.Add(this.firFiyat);
            this.Controls.Add(this.bulAdet);
            this.Controls.Add(this.bulTutar);
            this.Controls.Add(this.bulFiyat);
            this.Controls.Add(this.camAdet);
            this.Controls.Add(this.camTutar);
            this.Controls.Add(this.camFiyat);
            this.Controls.Add(this.buzAdet);
            this.Controls.Add(this.buzTutar);
            this.Controls.Add(this.buzFiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Beyaz Eşya Alım Satım";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox buzFiyat;
        private System.Windows.Forms.TextBox camFiyat;
        private System.Windows.Forms.TextBox bulFiyat;
        private System.Windows.Forms.TextBox firFiyat;
        private System.Windows.Forms.TextBox buzAdet;
        private System.Windows.Forms.TextBox camAdet;
        private System.Windows.Forms.TextBox bulAdet;
        private System.Windows.Forms.TextBox firAdet;
        private System.Windows.Forms.CheckBox buzIsc;
        private System.Windows.Forms.CheckBox camIsc;
        private System.Windows.Forms.CheckBox bulIsc;
        private System.Windows.Forms.CheckBox firIsc;
        private System.Windows.Forms.TextBox buzTutar;
        private System.Windows.Forms.TextBox camTutar;
        private System.Windows.Forms.TextBox bulTutar;
        private System.Windows.Forms.TextBox firTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Top;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label aciklamalbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

