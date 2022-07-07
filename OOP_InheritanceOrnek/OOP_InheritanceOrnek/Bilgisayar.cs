using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_InheritanceOrnek
{
    public class Bilgisayar:Urun
    {
        public Islemci Islemci { get; set; }
        public EkranKarti EkranKarti { get; set; }
        public int Ram { get; set; }
        public string Monitor { get; set; }
        public Anakart Anakart { get; set; }
    }
}
