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
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraGelir = 0;
            int satisAdedi = 0;

            if (SiparisOlustur.siparisListesi.Count>0)
            {
                foreach (Siparis siparis in SiparisOlustur.siparisListesi)
                {
                    ciro += siparis.ToplamTutar;
                    foreach (Ekstra ekstra in siparis.Ekstra)
                    {
                        ekstraGelir += ekstra.Fiyat;
                    }
                    ekstraGelir *= siparis.Adet;
                    satisAdedi += siparis.Adet;
                    lstSiparisler.Items.Add(siparis);
                }
            }
            lblCiro.Text = "Toplam Ciro: "+ ciro.ToString("C2");
            lblEkstraSiparis.Text = "Ekstralardan gelen gelir: " + ekstraGelir.ToString("C2");
            lblSatilanUrunAdedi.Text= "Toplam Satilan Urun Adedi: " + satisAdedi.ToString("C2");
            lblToplamSiparis.Text = "Siparis Adedi:"+ lstSiparisler.Items.Count.ToString();          
        }
    }
}
