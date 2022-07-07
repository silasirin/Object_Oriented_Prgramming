using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_InheritanceOrnek
{
    public class MasaUstu:Bilgisayar
    {
        public string Marka { get; set; }

        public override string ToString()
        {
            return $"{Marka} {Ram} {Monitor} {Fiyat} TL "; 
        }
    }
}
