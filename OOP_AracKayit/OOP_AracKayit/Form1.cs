using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_AracKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            arac.marka = cmbMarka.Text;
            arac.model = cmbModel.Text;
            arac.yakit = cmbYakit.Text;
            arac.vites = cmbVites.Text;
            arac.Renk = txtRenk.Text;
            arac.Yil = Convert.ToInt32(dateTimePicker1.Value.Year);

            if (arac.Yil != 0 )
            {
                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = arac.marka;
                lvi.SubItems.Add(arac.model);
                lvi.SubItems.Add(arac.yakit);
                lvi.SubItems.Add(arac.vites);
                lvi.SubItems.Add(arac.Renk);
                lvi.SubItems.Add(arac.Yil.ToString());
                listView1.Items.Add(lvi);
            }
            else
            {
                MessageBox.Show("minimum 2010 yili ve Kirmizi disinda bir renk giriniz.");
            }
            
        }
        AracSeyleri arac = new AracSeyleri();
        private void Form1_Load(object sender, EventArgs e)
        {
            //ComboBox'a marka ekleme:
            cmbMarka.Items.Clear();

            cmbMarka.Items.Add("Alfa Romeo");
            cmbMarka.Items.Add("Renault");
            cmbMarka.Items.Add("Ferrari");
            cmbMarka.Items.Add("Porsche");
            cmbMarka.Items.Add("Tesla");

            //Yakit Tipi:
            cmbYakit.Items.Add("Dizel");
            cmbYakit.Items.Add("Benzin");
            cmbYakit.Items.Add("Elektrikli");

            //Vites Tipi:
            cmbVites.Items.Add("Otomatik");
            cmbVites.Items.Add("Manuel");

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();

            switch (cmbMarka.Text)
            {
                case "Alfa Romeo":
                    cmbModel.Items.Add("Giulietta");
                    cmbModel.Items.Add("Quadrofoglio");
                    cmbModel.Items.Add("Giulia");
                    break;
                case "Renault":
                    cmbModel.Items.Add("Megane");
                    cmbModel.Items.Add("Clio");
                    cmbModel.Items.Add("Laguna");
                    break;
                case "Ferrari":
                    cmbModel.Items.Add("California");
                    cmbModel.Items.Add("Roma");
                    cmbModel.Items.Add("SF90");
                    break;
                case "Porsche":
                    cmbMarka.Items.Add("Cayman");
                    cmbModel.Items.Add("Boxster");
                    cmbModel.Items.Add("Carrera");
                    break;
                case "Tesla":
                    cmbMarka.Items.Add("X");
                    cmbModel.Items.Add("Y");
                    cmbModel.Items.Add("S");
                    break;
            }
        }
    }
}
