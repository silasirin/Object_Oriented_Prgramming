using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_McAdam
{
    public partial class EkstraOlustur : Form
    {
        public EkstraOlustur()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            if (txtEkstraAdi.Text != "" && nudEkstraFiyat.Value != 0)
            {
                Ekstra ekstra = new Ekstra();
                ekstra.UrunAdi = txtEkstraAdi.Text;
                ekstra.Fiyat = nudEkstraFiyat.Value;
                Ekstra.ekstraListesi.Add(ekstra);
            }
            else
            {
                MessageBox.Show("Urun secimi veya fiyat bilgisi eksik!");
            }
            nudEkstraFiyat.Value = 0;
            txtEkstraAdi.Text = "";
        }
    }
}
