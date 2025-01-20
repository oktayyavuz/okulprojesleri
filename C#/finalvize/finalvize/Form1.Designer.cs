namespace finalvize
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vizetxt = new System.Windows.Forms.TextBox();
            this.finaltxt = new System.Windows.Forms.TextBox();
            this.kgtxt = new System.Windows.Forms.TextBox();
            this.orttxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.harftxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final";
            // 
            // vizetxt
            // 
            this.vizetxt.Location = new System.Drawing.Point(81, 37);
            this.vizetxt.Name = "vizetxt";
            this.vizetxt.Size = new System.Drawing.Size(100, 20);
            this.vizetxt.TabIndex = 2;
            // 
            // finaltxt
            // 
            this.finaltxt.Location = new System.Drawing.Point(81, 70);
            this.finaltxt.Name = "finaltxt";
            this.finaltxt.Size = new System.Drawing.Size(100, 20);
            this.finaltxt.TabIndex = 3;
            // 
            // kgtxt
            // 
            this.kgtxt.Enabled = false;
            this.kgtxt.Location = new System.Drawing.Point(81, 140);
            this.kgtxt.Name = "kgtxt";
            this.kgtxt.Size = new System.Drawing.Size(100, 20);
            this.kgtxt.TabIndex = 7;
            // 
            // orttxt
            // 
            this.orttxt.Enabled = false;
            this.orttxt.Location = new System.Drawing.Point(81, 107);
            this.orttxt.Name = "orttxt";
            this.orttxt.Size = new System.Drawing.Size(100, 20);
            this.orttxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "K/G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ortalama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Harf Notu";
            // 
            // harftxt
            // 
            this.harftxt.Enabled = false;
            this.harftxt.Location = new System.Drawing.Point(81, 176);
            this.harftxt.Name = "harftxt";
            this.harftxt.Size = new System.Drawing.Size(100, 20);
            this.harftxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.harftxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kgtxt);
            this.Controls.Add(this.orttxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finaltxt);
            this.Controls.Add(this.vizetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Final Vize Hesabı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vizetxt;
        private System.Windows.Forms.TextBox finaltxt;
        private System.Windows.Forms.TextBox kgtxt;
        private System.Windows.Forms.TextBox orttxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox harftxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

