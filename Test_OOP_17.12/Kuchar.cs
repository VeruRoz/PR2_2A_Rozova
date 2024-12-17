using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP_17._12_
{
    internal class Kuchar : Zamestnanec
    {
        //        třída Kuchar
        //Je rozšiřující třídou Zamestnanec a implementuje vše potřebné z bázových tříd
        //Konstruktor přijímá parametry jmeno, pohlavi, mzda a hotel(řetězec).
        //Parametry, které lze, uloží pomocí bázového konstruktoru.Jako název povolání uloží řetězec "kuchař"
        //Hotel si uloží jako soukromou datovou položku přímo ve třídě
        //Pokud se pracuje(tedy když se zavolá metoda Pracuj()), vrací metoda řetězec "Klepu řízky v hotelu …".
        private string Hotel;
        public Kuchar(string jmeno, Enum pohlavi, int mzda, string hotel) : base(jmeno, pohlavi, mzda, povolání = "kuchar")
        {
            Hotel = hotel;
        }
        override public string Pracuj()
        {
            return "Klepu řízky v hotelu …";
        }

    }
}
