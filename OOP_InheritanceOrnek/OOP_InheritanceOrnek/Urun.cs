using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_InheritanceOrnek
{
    public class Urun
    {
        public decimal Fiyat { get; set; }
        public bool Aktif { get; set; }

        public decimal KdvliFiyat
        {
            get { return Fiyat*1.18m; }
        }

    }
}
