﻿
namespace OOP_McAdam
{
    partial class EkstraOlustur
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
            this.nudEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraAdi = new System.Windows.Forms.TextBox();
            this.btnEkstraEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ekstra Bilgiler:";
            // 
            // nudEkstraFiyat
            // 
            this.nudEkstraFiyat.Location = new System.Drawing.Point(177, 118);
            this.nudEkstraFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudEkstraFiyat.Name = "nudEkstraFiyat";
            this.nudEkstraFiyat.Size = new System.Drawing.Size(160, 22);
            this.nudEkstraFiyat.TabIndex = 2;
            // 
            // txtEkstraAdi
            // 
            this.txtEkstraAdi.Location = new System.Drawing.Point(177, 79);
            this.txtEkstraAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEkstraAdi.Name = "txtEkstraAdi";
            this.txtEkstraAdi.Size = new System.Drawing.Size(159, 22);
            this.txtEkstraAdi.TabIndex = 3;
            // 
            // btnEkstraEkle
            // 
            this.btnEkstraEkle.Location = new System.Drawing.Point(195, 176);
            this.btnEkstraEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkstraEkle.Name = "btnEkstraEkle";
            this.btnEkstraEkle.Size = new System.Drawing.Size(100, 28);
            this.btnEkstraEkle.TabIndex = 4;
            this.btnEkstraEkle.Text = "Ekle";
            this.btnEkstraEkle.UseVisualStyleBackColor = true;
            this.btnEkstraEkle.Click += new System.EventHandler(this.btnEkstraEkle_Click);
            // 
            // EkstraOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 293);
            this.Controls.Add(this.btnEkstraEkle);
            this.Controls.Add(this.txtEkstraAdi);
            this.Controls.Add(this.nudEkstraFiyat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EkstraOlustur";
            this.Text = "EkstraOlustur";
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudEkstraFiyat;
        private System.Windows.Forms.TextBox txtEkstraAdi;
        private System.Windows.Forms.Button btnEkstraEkle;
    }
}