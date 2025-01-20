namespace WindowsFormsApplication2
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
            this.vizebox = new System.Windows.Forms.TextBox();
            this.finalbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hesapla = new System.Windows.Forms.Button();
            this.ortbox = new System.Windows.Forms.TextBox();
            this.kgbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.harfbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vizebox
            // 
            this.vizebox.Location = new System.Drawing.Point(118, 67);
            this.vizebox.Name = "vizebox";
            this.vizebox.Size = new System.Drawing.Size(100, 20);
            this.vizebox.TabIndex = 0;
            this.vizebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // finalbox
            // 
            this.finalbox.Location = new System.Drawing.Point(118, 93);
            this.finalbox.Name = "finalbox";
            this.finalbox.Size = new System.Drawing.Size(100, 20);
            this.finalbox.TabIndex = 1;
            this.finalbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final";
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(143, 128);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(75, 23);
            this.hesapla.TabIndex = 4;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // ortbox
            // 
            this.ortbox.Location = new System.Drawing.Point(118, 179);
            this.ortbox.Name = "ortbox";
            this.ortbox.ReadOnly = true;
            this.ortbox.Size = new System.Drawing.Size(100, 20);
            this.ortbox.TabIndex = 5;
            this.ortbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kgbox
            // 
            this.kgbox.Location = new System.Drawing.Point(118, 206);
            this.kgbox.Name = "kgbox";
            this.kgbox.ReadOnly = true;
            this.kgbox.Size = new System.Drawing.Size(100, 20);
            this.kgbox.TabIndex = 6;
            this.kgbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ortalama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "K/G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Harf";
            // 
            // harfbox
            // 
            this.harfbox.Location = new System.Drawing.Point(118, 233);
            this.harfbox.Name = "harfbox";
            this.harfbox.ReadOnly = true;
            this.harfbox.Size = new System.Drawing.Size(100, 20);
            this.harfbox.TabIndex = 10;
            this.harfbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.hesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 321);
            this.Controls.Add(this.harfbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kgbox);
            this.Controls.Add(this.ortbox);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalbox);
            this.Controls.Add(this.vizebox);
            this.Name = "Form1";
            this.Text = "Vize/Final Hesap makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vizebox;
        private System.Windows.Forms.TextBox finalbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.TextBox ortbox;
        private System.Windows.Forms.TextBox kgbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox harfbox;
    }
}

