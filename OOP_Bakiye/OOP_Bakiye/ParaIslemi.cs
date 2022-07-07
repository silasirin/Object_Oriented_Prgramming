using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Bakiye
{
    internal class ParaIslemi
    {
        private int _cekilecekTutar;

        public int CekilecekTutar
        {
            get
            { return _cekilecekTutar; }

            set
            {
                if (10 < value && value < 1001)
                {
                    _cekilecekTutar = value;
                }
                else
                {
                    _cekilecekTutar = 0;
                }
            }
        }
        public int guncelTutar;

        private int _yatirilacakTutar;

        public int YatirilacakTutar
        {
            get 
            { return _yatirilacakTutar; }
            set
            {
                if (10 < value && value < 1001)
                {
                    _yatirilacakTutar = value;
                }
                else
                {
                    _yatirilacakTutar = 0;
                }
            }
        }


    }
}
