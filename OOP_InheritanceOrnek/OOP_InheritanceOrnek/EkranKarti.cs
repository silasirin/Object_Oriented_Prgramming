using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_InheritanceOrnek
{
    public class EkranKarti:Urun
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"{Marka} {Model} {Fiyat} TL";
        }
    }
 
}
