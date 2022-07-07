using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_InheritanceOrnek
{
    public class Laptop:Bilgisayar
    {
        public string SarjSuresi { get; set; }
        public override string ToString()
        {
            return $"{SarjSuresi} {Ram} {Monitor} {Fiyat} TL"; 
        }
    }
}
