using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_InheritanceOrnek
{
    public class Islemci:Urun
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int CekirdekSayisi { get; set; }

        public override string ToString()
        {
            return $"{Marka} {Model} {CekirdekSayisi} {Fiyat} TL"; 
        }
    }
}
