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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        //List<Burger> menuListesi = new List<Burger>()
        //{
        //    new Burger{ UrunAdi="Whopper", Fiyat=20}
        //};

        public static List<Siparis> siparisListesi = new List<Siparis>();
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            rbKucuk.Checked = true;
            nudAdet.Value = 1;
            Ekstra ekstra = new Ekstra();
            cmbMenu.DataSource = Burger.burgerListesi.ToList();

            foreach (Ekstra eks in Ekstra.ekstraListesi)
            {
                CheckBox chk = new CheckBox();
                chk.Text = eks.UrunAdi;
                chk.Tag = ekstra; //boxing
                flowLayoutPanel1.Controls.Add(chk);
            }
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SeciliMenu = (Burger)cmbMenu.SelectedItem;
            if (rbKucuk.Checked)
            {
                siparis.Boyut = Boyut.Kucuk;
            }
            else if (rbOrta.Checked)
            {
                siparis.Boyut = Boyut.Orta;
            }
            else if(rbBuyuk.Checked)
            {
                siparis.Boyut = Boyut.Buyuk;
            }

            siparis.Ekstra = new List<Ekstra>(); //null reference hatasi almamak icin.

            Control ctrl = new Control();
            if (ctrl is CheckBox)
            {
                foreach (CheckBox chk in flowLayoutPanel1.Controls)
                {
                    if (chk.Checked)
                    {
                        Ekstra ekstra = (Ekstra)chk.Tag;
                        siparis.Ekstra.Add(ekstra);
                    }
                }
            }
            
            siparis.Adet = Convert.ToInt32(nudAdet.Value);
            siparis.Hesapla();

            lstSiparis.Items.Add(siparis);
            lblToplam.Text = TutarHesapla().ToString("C2");
        }

        public decimal TutarHesapla()
        {
            decimal toplamTutar = 0;

            for (int i = 0; i < lstSiparis.Items.Count; i++)
            {
                Siparis siparis = (Siparis)lstSiparis.Items[i];
                toplamTutar += siparis.ToplamTutar;
            }
            return toplamTutar;
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Siparis Tutuari: "+TutarHesapla().ToString("C2")+ "Siparis islemi onaylansin mi?", "Siparis Onayi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dr==DialogResult.Yes)
            {
                for (int i = 0; i < lstSiparis.Items.Count; i++)
                {
                    Siparis siparis = (Siparis)lstSiparis.Items[i];
                    siparisListesi.Add(siparis);
                }
                lstSiparis.Items.Clear();
                lblToplam.Text = "0 TL";
                MessageBox.Show("Siparis Tamamlandi!");
            }

        }
    }
}
