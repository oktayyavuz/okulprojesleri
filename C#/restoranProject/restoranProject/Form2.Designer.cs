namespace restoranProject
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
            this.button1 = new System.Windows.Forms.Button();
            this.adsoyadtxt = new System.Windows.Forms.TextBox();
            this.tcnotxt = new System.Windows.Forms.TextBox();
            this.teltxt = new System.Windows.Forms.TextBox();
            this.epostatxt = new System.Windows.Forms.TextBox();
            this.adresstxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC Kimlik Numarası*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon Numarası*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-Posta Adresi*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adress*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adsoyadtxt
            // 
            this.adsoyadtxt.Location = new System.Drawing.Point(145, 27);
            this.adsoyadtxt.Name = "adsoyadtxt";
            this.adsoyadtxt.Size = new System.Drawing.Size(100, 20);
            this.adsoyadtxt.TabIndex = 0;
            // 
            // tcnotxt
            // 
            this.tcnotxt.Location = new System.Drawing.Point(145, 53);
            this.tcnotxt.Name = "tcnotxt";
            this.tcnotxt.Size = new System.Drawing.Size(100, 20);
            this.tcnotxt.TabIndex = 1;
            this.tcnotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // teltxt
            // 
            this.teltxt.Location = new System.Drawing.Point(145, 79);
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(100, 20);
            this.teltxt.TabIndex = 2;
            this.teltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // epostatxt
            // 
            this.epostatxt.Location = new System.Drawing.Point(145, 105);
            this.epostatxt.Name = "epostatxt";
            this.epostatxt.Size = new System.Drawing.Size(100, 20);
            this.epostatxt.TabIndex = 3;
            // 
            // adresstxt
            // 
            this.adresstxt.Location = new System.Drawing.Point(145, 131);
            this.adresstxt.Name = "adresstxt";
            this.adresstxt.Size = new System.Drawing.Size(100, 20);
            this.adresstxt.TabIndex = 4;
            this.adresstxt.Tag = "";
            // 
            // Form2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 201);
            this.Controls.Add(this.adresstxt);
            this.Controls.Add(this.epostatxt);
            this.Controls.Add(this.teltxt);
            this.Controls.Add(this.tcnotxt);
            this.Controls.Add(this.adsoyadtxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Çalışan Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox adsoyadtxt;
        private System.Windows.Forms.TextBox tcnotxt;
        private System.Windows.Forms.TextBox teltxt;
        private System.Windows.Forms.TextBox epostatxt;
        private System.Windows.Forms.TextBox adresstxt;
    }
}