using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AracKayit
{
    internal class AracSeyleri
    {

        public string marka;
        public string model;
        public string yakit;
        public string vites;
        private string _renk;
        public string Renk
        {
            get 
            { return _renk; }
            set
            {
                if (value!="Kirmizi")
                {
                    _renk = value;
                }
                else
                {
                    _renk = "";
                }
            }
        }
        private int _yil;
        public int Yil
        {
            get 
            { return _yil; }
            set
            {
                if (value > 2010)
                {
                    _yil = value;
                }
                else
                {
                    _yil = 0;
                }
            }
        }


    }
}
