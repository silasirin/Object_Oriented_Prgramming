namespace OOP_Bakiye
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
            this.lstIslem = new System.Windows.Forms.ListBox();
            this.grpParaYatir = new System.Windows.Forms.GroupBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.nudParaYatir = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.grpParaCek = new System.Windows.Forms.GroupBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.nudParaCek = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpParaYatir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaYatir)).BeginInit();
            this.grpParaCek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaCek)).BeginInit();
            this.SuspendLayout();
            // 
            // lstIslem
            // 
            this.lstIslem.FormattingEnabled = true;
            this.lstIslem.ItemHeight = 16;
            this.lstIslem.Location = new System.Drawing.Point(173, 280);
            this.lstIslem.Margin = new System.Windows.Forms.Padding(4);
            this.lstIslem.Name = "lstIslem";
            this.lstIslem.Size = new System.Drawing.Size(441, 228);
            this.lstIslem.TabIndex = 7;
            // 
            // grpParaYatir
            // 
            this.grpParaYatir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpParaYatir.Controls.Add(this.btnParaYatir);
            this.grpParaYatir.Controls.Add(this.nudParaYatir);
            this.grpParaYatir.Controls.Add(this.label3);
            this.grpParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpParaYatir.Location = new System.Drawing.Point(396, 109);
            this.grpParaYatir.Margin = new System.Windows.Forms.Padding(4);
            this.grpParaYatir.Name = "grpParaYatir";
            this.grpParaYatir.Padding = new System.Windows.Forms.Padding(4);
            this.grpParaYatir.Size = new System.Drawing.Size(220, 161);
            this.grpParaYatir.TabIndex = 5;
            this.grpParaYatir.TabStop = false;
            this.grpParaYatir.Text = "Para Yatir";
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(81, 102);
            this.btnParaYatir.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(100, 28);
            this.btnParaYatir.TabIndex = 2;
            this.btnParaYatir.Text = "Para Yatir";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // nudParaYatir
            // 
            this.nudParaYatir.Location = new System.Drawing.Point(68, 33);
            this.nudParaYatir.Margin = new System.Windows.Forms.Padding(4);
            this.nudParaYatir.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudParaYatir.Name = "nudParaYatir";
            this.nudParaYatir.Size = new System.Drawing.Size(140, 26);
            this.nudParaYatir.TabIndex = 1;
            this.nudParaYatir.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar:";
            // 
            // grpParaCek
            // 
            this.grpParaCek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpParaCek.Controls.Add(this.btnParaCek);
            this.grpParaCek.Controls.Add(this.nudParaCek);
            this.grpParaCek.Controls.Add(this.label2);
            this.grpParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpParaCek.Location = new System.Drawing.Point(173, 109);
            this.grpParaCek.Margin = new System.Windows.Forms.Padding(4);
            this.grpParaCek.Name = "grpParaCek";
            this.grpParaCek.Padding = new System.Windows.Forms.Padding(4);
            this.grpParaCek.Size = new System.Drawing.Size(215, 161);
            this.grpParaCek.TabIndex = 6;
            this.grpParaCek.TabStop = false;
            this.grpParaCek.Text = "Para Cek";
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(91, 102);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(100, 28);
            this.btnParaCek.TabIndex = 2;
            this.btnParaCek.Text = "Para Cek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // nudParaCek
            // 
            this.nudParaCek.Location = new System.Drawing.Point(69, 36);
            this.nudParaCek.Margin = new System.Windows.Forms.Padding(4);
            this.nudParaCek.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudParaCek.Name = "nudParaCek";
            this.nudParaCek.Size = new System.Drawing.Size(133, 26);
            this.nudParaCek.TabIndex = 1;
            this.nudParaCek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Miktar:";
            // 
            // lblTutar
            // 
            this.lblTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutar.Location = new System.Drawing.Point(248, 29);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(275, 60);
            this.lblTutar.TabIndex = 3;
            this.lblTutar.Text = "0.00 TL";
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bakiye";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 520);
            this.Controls.Add(this.lstIslem);
            this.Controls.Add(this.grpParaYatir);
            this.Controls.Add(this.grpParaCek);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpParaYatir.ResumeLayout(false);
            this.grpParaYatir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaYatir)).EndInit();
            this.grpParaCek.ResumeLayout(false);
            this.grpParaCek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaCek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIslem;
        private System.Windows.Forms.GroupBox grpParaYatir;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.NumericUpDown nudParaYatir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpParaCek;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.NumericUpDown nudParaCek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label1;
    }
}

