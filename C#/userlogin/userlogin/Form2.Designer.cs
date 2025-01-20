namespace userlogin
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yevmiye = new System.Windows.Forms.TextBox();
            this.gunsayisi = new System.Windows.Forms.TextBox();
            this.brutmaas = new System.Windows.Forms.TextBox();
            this.netmaas = new System.Windows.Forms.TextBox();
            this.kesinti = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yevmiye:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gün sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brüt Maaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kesinti %:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Net Maaş:";
            // 
            // yevmiye
            // 
            this.yevmiye.Location = new System.Drawing.Point(101, 46);
            this.yevmiye.Name = "yevmiye";
            this.yevmiye.Size = new System.Drawing.Size(100, 20);
            this.yevmiye.TabIndex = 5;
            // 
            // gunsayisi
            // 
            this.gunsayisi.Location = new System.Drawing.Point(101, 72);
            this.gunsayisi.Name = "gunsayisi";
            this.gunsayisi.Size = new System.Drawing.Size(100, 20);
            this.gunsayisi.TabIndex = 6;
            // 
            // brutmaas
            // 
            this.brutmaas.Enabled = false;
            this.brutmaas.Location = new System.Drawing.Point(101, 99);
            this.brutmaas.Name = "brutmaas";
            this.brutmaas.Size = new System.Drawing.Size(100, 20);
            this.brutmaas.TabIndex = 7;
            // 
            // netmaas
            // 
            this.netmaas.Enabled = false;
            this.netmaas.Location = new System.Drawing.Point(101, 152);
            this.netmaas.Name = "netmaas";
            this.netmaas.Size = new System.Drawing.Size(100, 20);
            this.netmaas.TabIndex = 9;
            // 
            // kesinti
            // 
            this.kesinti.Location = new System.Drawing.Point(101, 125);
            this.kesinti.Name = "kesinti";
            this.kesinti.Size = new System.Drawing.Size(44, 20);
            this.kesinti.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.netmaas);
            this.Controls.Add(this.kesinti);
            this.Controls.Add(this.brutmaas);
            this.Controls.Add(this.gunsayisi);
            this.Controls.Add(this.yevmiye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Maaş Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yevmiye;
        private System.Windows.Forms.TextBox gunsayisi;
        private System.Windows.Forms.TextBox brutmaas;
        private System.Windows.Forms.TextBox netmaas;
        private System.Windows.Forms.TextBox kesinti;
        private System.Windows.Forms.Button button1;
    }
}