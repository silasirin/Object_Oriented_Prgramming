using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_McAdam
{
    public class Siparis
    {
        public Burger SeciliMenu { get; set; }
        public Boyut Boyut { get; set; }
        public List<Ekstra> Ekstra { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;

            //Menu fiyati
            ToplamTutar += SeciliMenu.Fiyat;

            //Boyut Fiyati
            switch (Boyut)
            {
                case Boyut.Kucuk:
                    ToplamTutar += 0;
                    break;
                case Boyut.Orta:
                    ToplamTutar += 3;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += 5;
                    break;
            }
            //Ekstra Fiyati
            foreach (Ekstra ekstra in Ekstra)
            {
                ToplamTutar += ekstra.Fiyat;
            }

            ToplamTutar *= Adet;
        }

        public override string ToString()
        {
            if (Ekstra.Count<1)
            {
                return Adet + " Adet " + Boyut.ToString() + " Boy " + SeciliMenu + " Fiyat: " + ToplamTutar.ToString("C2");
            }
            else
            {
                string ekstraBilgi = " ";

                foreach (Ekstra ekstra in Ekstra)
                {
                    ekstraBilgi += ekstra.UrunAdi + " ";
                }
                return Adet + " Adet " + Boyut.ToString() + " Boy " + SeciliMenu + " Ekstralar: " + Ekstra + " Fiyat: " +ToplamTutar.ToString("C2");
            }
           
        }
    }
}
