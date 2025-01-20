namespace hesapmakinesi
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
            this.topbtn = new System.Windows.Forms.Button();
            this.cikbtn = new System.Windows.Forms.Button();
            this.bolbtn = new System.Windows.Forms.Button();
            this.carpbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sayi1txt = new System.Windows.Forms.TextBox();
            this.sayi2txt = new System.Windows.Forms.TextBox();
            this.sonuctxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // topbtn
            // 
            this.topbtn.Location = new System.Drawing.Point(68, 102);
            this.topbtn.Name = "topbtn";
            this.topbtn.Size = new System.Drawing.Size(51, 23);
            this.topbtn.TabIndex = 0;
            this.topbtn.Text = "Topla";
            this.topbtn.UseVisualStyleBackColor = true;
            this.topbtn.Click += new System.EventHandler(this.topbtn_Click);
            // 
            // cikbtn
            // 
            this.cikbtn.Location = new System.Drawing.Point(125, 102);
            this.cikbtn.Name = "cikbtn";
            this.cikbtn.Size = new System.Drawing.Size(51, 23);
            this.cikbtn.TabIndex = 1;
            this.cikbtn.Text = "Çıkar";
            this.cikbtn.UseVisualStyleBackColor = true;
            this.cikbtn.Click += new System.EventHandler(this.cikbtn_Click);
            // 
            // bolbtn
            // 
            this.bolbtn.Location = new System.Drawing.Point(125, 131);
            this.bolbtn.Name = "bolbtn";
            this.bolbtn.Size = new System.Drawing.Size(51, 23);
            this.bolbtn.TabIndex = 3;
            this.bolbtn.Text = "Böl";
            this.bolbtn.UseVisualStyleBackColor = true;
            this.bolbtn.Click += new System.EventHandler(this.bolbtn_Click);
            // 
            // carpbtn
            // 
            this.carpbtn.Location = new System.Drawing.Point(68, 131);
            this.carpbtn.Name = "carpbtn";
            this.carpbtn.Size = new System.Drawing.Size(51, 23);
            this.carpbtn.TabIndex = 2;
            this.carpbtn.Text = "Çarp";
            this.carpbtn.UseVisualStyleBackColor = true;
            this.carpbtn.Click += new System.EventHandler(this.carpbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sayı 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sonuç";
            // 
            // sayi1txt
            // 
            this.sayi1txt.Location = new System.Drawing.Point(68, 35);
            this.sayi1txt.Name = "sayi1txt";
            this.sayi1txt.Size = new System.Drawing.Size(108, 20);
            this.sayi1txt.TabIndex = 7;
            // 
            // sayi2txt
            // 
            this.sayi2txt.Location = new System.Drawing.Point(68, 64);
            this.sayi2txt.Name = "sayi2txt";
            this.sayi2txt.Size = new System.Drawing.Size(108, 20);
            this.sayi2txt.TabIndex = 8;
            // 
            // sonuctxt
            // 
            this.sonuctxt.Enabled = false;
            this.sonuctxt.Location = new System.Drawing.Point(239, 31);
            this.sonuctxt.Name = "sonuctxt";
            this.sonuctxt.Size = new System.Drawing.Size(108, 20);
            this.sonuctxt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 177);
            this.Controls.Add(this.sonuctxt);
            this.Controls.Add(this.sayi2txt);
            this.Controls.Add(this.sayi1txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bolbtn);
            this.Controls.Add(this.carpbtn);
            this.Controls.Add(this.cikbtn);
            this.Controls.Add(this.topbtn);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topbtn;
        private System.Windows.Forms.Button cikbtn;
        private System.Windows.Forms.Button bolbtn;
        private System.Windows.Forms.Button carpbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sayi1txt;
        private System.Windows.Forms.TextBox sayi2txt;
        private System.Windows.Forms.TextBox sonuctxt;
    }
}

