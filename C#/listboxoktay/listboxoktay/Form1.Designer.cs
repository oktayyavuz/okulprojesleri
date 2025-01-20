namespace listboxoktay
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
            this.eklemekutusu = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lstboxekle = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // eklemekutusu
            // 
            this.eklemekutusu.Location = new System.Drawing.Point(80, 42);
            this.eklemekutusu.Name = "eklemekutusu";
            this.eklemekutusu.Size = new System.Drawing.Size(100, 20);
            this.eklemekutusu.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(91, 68);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lstboxekle
            // 
            this.lstboxekle.FormattingEnabled = true;
            this.lstboxekle.Location = new System.Drawing.Point(70, 133);
            this.lstboxekle.Name = "lstboxekle";
            this.lstboxekle.Size = new System.Drawing.Size(120, 95);
            this.lstboxekle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstboxekle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.eklemekutusu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eklemekutusu;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ListBox lstboxekle;
    }
}

