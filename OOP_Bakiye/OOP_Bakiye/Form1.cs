using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Bakiye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ParaIslemi paraIslemi = new ParaIslemi();

        private void Form1_Load(object sender, EventArgs e)
        {
            paraIslemi.guncelTutar = 500;
            lblTutar.Text = paraIslemi.guncelTutar.ToString("C2");

        }
        private void btnParaCek_Click(object sender, EventArgs e)
        {
            paraIslemi.CekilecekTutar = Convert.ToInt32(nudParaCek.Value);
            if (paraIslemi.CekilecekTutar <= paraIslemi.guncelTutar)
            {

                paraIslemi.guncelTutar -= paraIslemi.CekilecekTutar;

            }
            else
            {
                
                MessageBox.Show("Yetersiz Bakiye!");
            }
            lblTutar.Text = paraIslemi.guncelTutar.ToString("C2");
            
            string format = $"Cekilen Para: {paraIslemi.CekilecekTutar} TL , Guncel Tutar: {paraIslemi.guncelTutar} TL";
            lstIslem.Items.Add(format);
            paraIslemi.CekilecekTutar = 0;
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            paraIslemi.YatirilacakTutar = Convert.ToInt32(nudParaYatir.Value);
            paraIslemi.guncelTutar += paraIslemi.YatirilacakTutar;
            lblTutar.Text = paraIslemi.guncelTutar.ToString("C2");
            string format = $"Yatirilan Para: {paraIslemi.YatirilacakTutar} TL , Guncel Tutar: {paraIslemi.guncelTutar} TL";
            lstIslem.Items.Add(format);
        }
    }
}
