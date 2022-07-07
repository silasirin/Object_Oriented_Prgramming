using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_McAdam
{
    public abstract class Urun
    {
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return UrunAdi + " " + Fiyat + " TL";
        }
    }
}
