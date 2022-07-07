
namespace OOP_InheritanceOrnek
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
            this.lstAnakart = new System.Windows.Forms.ListBox();
            this.lstIslemci = new System.Windows.Forms.ListBox();
            this.lstEkranKarti = new System.Windows.Forms.ListBox();
            this.lstMasaustu = new System.Windows.Forms.ListBox();
            this.lstLaptop = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAnakart
            // 
            this.lstAnakart.FormattingEnabled = true;
            this.lstAnakart.Location = new System.Drawing.Point(8, 12);
            this.lstAnakart.Name = "lstAnakart";
            this.lstAnakart.Size = new System.Drawing.Size(423, 82);
            this.lstAnakart.TabIndex = 0;
            this.lstAnakart.DoubleClick += new System.EventHandler(this.lstAnakart_DoubleClick);
            // 
            // lstIslemci
            // 
            this.lstIslemci.FormattingEnabled = true;
            this.lstIslemci.Location = new System.Drawing.Point(8, 100);
            this.lstIslemci.Name = "lstIslemci";
            this.lstIslemci.Size = new System.Drawing.Size(423, 82);
            this.lstIslemci.TabIndex = 0;
            this.lstIslemci.DoubleClick += new System.EventHandler(this.lstIslemci_DoubleClick);
            // 
            // lstEkranKarti
            // 
            this.lstEkranKarti.FormattingEnabled = true;
            this.lstEkranKarti.Location = new System.Drawing.Point(6, 276);
            this.lstEkranKarti.Name = "lstEkranKarti";
            this.lstEkranKarti.Size = new System.Drawing.Size(425, 82);
            this.lstEkranKarti.TabIndex = 0;
            this.lstEkranKarti.DoubleClick += new System.EventHandler(this.lstEkranKarti_DoubleClick);
            // 
            // lstMasaustu
            // 
            this.lstMasaustu.FormattingEnabled = true;
            this.lstMasaustu.Location = new System.Drawing.Point(8, 188);
            this.lstMasaustu.Name = "lstMasaustu";
            this.lstMasaustu.Size = new System.Drawing.Size(423, 82);
            this.lstMasaustu.TabIndex = 0;
            this.lstMasaustu.DoubleClick += new System.EventHandler(this.lstMasaustu_DoubleClick);
            // 
            // lstLaptop
            // 
            this.lstLaptop.FormattingEnabled = true;
            this.lstLaptop.Location = new System.Drawing.Point(6, 364);
            this.lstLaptop.Name = "lstLaptop";
            this.lstLaptop.Size = new System.Drawing.Size(425, 82);
            this.lstLaptop.TabIndex = 0;
            this.lstLaptop.DoubleClick += new System.EventHandler(this.lstLaptop_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Fiyat:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(438, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(522, 394);
            this.listBox1.TabIndex = 3;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(850, 418);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(29, 13);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "0 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEkranKarti);
            this.Controls.Add(this.lstIslemci);
            this.Controls.Add(this.lstLaptop);
            this.Controls.Add(this.lstMasaustu);
            this.Controls.Add(this.lstAnakart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAnakart;
        private System.Windows.Forms.ListBox lstIslemci;
        private System.Windows.Forms.ListBox lstEkranKarti;
        private System.Windows.Forms.ListBox lstMasaustu;
        private System.Windows.Forms.ListBox lstLaptop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblFiyat;
    }
}

