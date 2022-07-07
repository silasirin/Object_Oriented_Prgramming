
namespace OOP_McAdam
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparislerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisToolStripMenuItem,
            this.siparisYonetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparisToolStripMenuItem
            // 
            this.siparisToolStripMenuItem.Name = "siparisToolStripMenuItem";
            this.siparisToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.siparisToolStripMenuItem.Text = "Siparis Olustur";
            this.siparisToolStripMenuItem.Click += new System.EventHandler(this.siparisToolStripMenuItem_Click);
            // 
            // siparisYonetimiToolStripMenuItem
            // 
            this.siparisYonetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOlusturToolStripMenuItem,
            this.ekstraOlusturToolStripMenuItem,
            this.siparislerToolStripMenuItem});
            this.siparisYonetimiToolStripMenuItem.Name = "siparisYonetimiToolStripMenuItem";
            this.siparisYonetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparisYonetimiToolStripMenuItem.Text = "Siparis Yonetimi";
            // 
            // menuOlusturToolStripMenuItem
            // 
            this.menuOlusturToolStripMenuItem.Name = "menuOlusturToolStripMenuItem";
            this.menuOlusturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menuOlusturToolStripMenuItem.Text = "Menu Olustur";
            this.menuOlusturToolStripMenuItem.Click += new System.EventHandler(this.menuOlusturToolStripMenuItem_Click);
            // 
            // ekstraOlusturToolStripMenuItem
            // 
            this.ekstraOlusturToolStripMenuItem.Name = "ekstraOlusturToolStripMenuItem";
            this.ekstraOlusturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekstraOlusturToolStripMenuItem.Text = "Ekstra Olustur";
            this.ekstraOlusturToolStripMenuItem.Click += new System.EventHandler(this.ekstraOlusturToolStripMenuItem_Click);
            // 
            // siparislerToolStripMenuItem
            // 
            this.siparislerToolStripMenuItem.Name = "siparislerToolStripMenuItem";
            this.siparislerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparislerToolStripMenuItem.Text = "Siparisler";
            this.siparislerToolStripMenuItem.Click += new System.EventHandler(this.siparislerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparislerToolStripMenuItem;
    }
}

