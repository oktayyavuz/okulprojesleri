namespace teksayilar
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
            this.sayi1txt = new System.Windows.Forms.TextBox();
            this.sayi2txt = new System.Windows.Forms.TextBox();
            this.sayilarbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sayi1txt
            // 
            this.sayi1txt.Location = new System.Drawing.Point(32, 36);
            this.sayi1txt.Name = "sayi1txt";
            this.sayi1txt.Size = new System.Drawing.Size(75, 20);
            this.sayi1txt.TabIndex = 1;
            // 
            // sayi2txt
            // 
            this.sayi2txt.Location = new System.Drawing.Point(32, 67);
            this.sayi2txt.Name = "sayi2txt";
            this.sayi2txt.Size = new System.Drawing.Size(75, 20);
            this.sayi2txt.TabIndex = 2;
            // 
            // sayilarbox
            // 
            this.sayilarbox.FormattingEnabled = true;
            this.sayilarbox.Location = new System.Drawing.Point(139, 36);
            this.sayilarbox.Name = "sayilarbox";
            this.sayilarbox.Size = new System.Drawing.Size(120, 199);
            this.sayilarbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sayilarbox);
            this.Controls.Add(this.sayi2txt);
            this.Controls.Add(this.sayi1txt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Tek Sayılar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sayi1txt;
        private System.Windows.Forms.TextBox sayi2txt;
        private System.Windows.Forms.ListBox sayilarbox;

    }
}

