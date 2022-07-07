using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_InheritanceOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Urun> urunler = new List<Urun>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Laptop laptop = new Laptop();
            MasaUstu masaustu = new MasaUstu();
            Anakart anakart = new Anakart();
            anakart.Marka = "Asus";
            anakart.Model = "2. model";
            anakart.Fiyat = 900;

            EkranKarti ek = new EkranKarti();
            ek.Marka = "Nvidia";
            ek.Model = "GTX3080";
            ek.Fiyat = 20000;

            Islemci islemci = new Islemci();
            islemci.Marka = "Intel";
            islemci.Model = "I7";
            islemci.CekirdekSayisi = 16;
            islemci.Fiyat = 5000;

            Bilgisayar pc1 = new Bilgisayar();
            pc1.Anakart = anakart;
            pc1.EkranKarti = ek;
            pc1.Islemci = islemci;
            pc1.Monitor = "MSI";
            pc1.Ram = 32;
            pc1.Fiyat = 50000;

            urunler.Add(anakart);
            urunler.Add(ek);
            urunler.Add(islemci);
            urunler.Add(laptop);
            urunler.Add(masaustu);


            laptop.Anakart = anakart;
            laptop.EkranKarti = ek;
            laptop.Islemci = islemci;
            laptop.SarjSuresi = "2 saat";
            laptop.Ram = 16;
            laptop.Fiyat = 13000;

            masaustu.Anakart = pc1.Anakart;
            masaustu.EkranKarti = ek;
            masaustu.Islemci = islemci;
            masaustu.Fiyat = 25000;

            foreach (Urun urun in urunler)
            {
                if (urun is Anakart)
                {
                    Anakart anakart1 = (Anakart)urun; //Unboxing yapiyoruz.
                   // string format = $"{anakart1.Marka} {anakart1.Model} {anakart1.Fiyat} TL";
                    lstAnakart.Items.Add(anakart1); //override yaptigimiz icin anakarti direkt yazdigimizda da string ifade goruyoruz
                }
                else if (urun is EkranKarti)
                {
                    EkranKarti ekranKarti = (EkranKarti)urun;
                    //string format = $"{ekranKarti.Marka} {ekranKarti.Model} {ekranKarti.Fiyat} TL";
                    lstEkranKarti.Items.Add(ekranKarti);
                }
                else if (urun is Islemci)
                {
                    Islemci islemci1 = (Islemci)urun;
                    //string format = $"{islemci1.Marka} {islemci.Model} {islemci.CekirdekSayisi} {islemci1.Fiyat} TL";
                    lstIslemci.Items.Add(islemci1);
                }
                else if (urun is Laptop)
                {
                    Laptop laptop1 = (Laptop)urun;
                    //string format = $"{laptop1.SarjSuresi} {laptop1.Fiyat} TL";
                    lstLaptop.Items.Add(laptop1);
                }
                else if (urun is MasaUstu)
                {
                    MasaUstu masaUstu=(MasaUstu)urun;
                    //string format = $" {masaUstu.Fiyat} TL ";
                    lstMasaustu.Items.Add(masaUstu);
                }
                //cift tiklanan nesne listview'a gitsin. 
            }
        }

        private void lstAnakart_DoubleClick(object sender, EventArgs e)
        {
            //Listbox'taki bir item'a cift tiklandiginda yapilacaklar icin event.

            Anakart seciliAnakart =(Anakart)lstAnakart.SelectedItem; //object dondurdugu icin unboxing yapmamiz gerekiyor.
            listBox1.Items.Add(seciliAnakart);
            toplamTutar += seciliAnakart.Fiyat;
            lblFiyat.Text = toplamTutar.ToString("C2");
        }
        decimal toplamTutar = 0;
        private void lstEkranKarti_DoubleClick(object sender, EventArgs e)
        {
            EkranKarti seciliEkranKarti = (EkranKarti)lstEkranKarti.SelectedItem;
            listBox1.Items.Add(seciliEkranKarti);
            toplamTutar += seciliEkranKarti.Fiyat;
            lblFiyat.Text = toplamTutar.ToString("C2");
        }

        private void lstIslemci_DoubleClick(object sender, EventArgs e)
        {
            Islemci seciliIslemci = (Islemci)lstIslemci.SelectedItem;
            listBox1.Items.Add(seciliIslemci);
            toplamTutar += seciliIslemci.Fiyat;
            lblFiyat.Text = toplamTutar.ToString("C2");
        }

        private void lstMasaustu_DoubleClick(object sender, EventArgs e)
        {
            MasaUstu seciliMasaUstu = (MasaUstu)lstMasaustu.SelectedItem;
            listBox1.Items.Add(seciliMasaUstu);
            toplamTutar = seciliMasaUstu.Fiyat;
            lblFiyat.Text = toplamTutar.ToString("C2");
        }

        private void lstLaptop_DoubleClick(object sender, EventArgs e)
        {
            Laptop seciliLaptop = (Laptop)lstLaptop.SelectedItem;
            listBox1.Items.Add(seciliLaptop);
            toplamTutar += seciliLaptop.Fiyat;
            lblFiyat.Text = toplamTutar.ToString("C2");
        }
    }
}
