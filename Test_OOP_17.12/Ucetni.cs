using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP_17._12_
{
    internal class Ucetni : Zamestnanec
    {
        //        třída Ucetni
        //Je rozšiřující třídou Zamestnanec a implementuje vše potřebné z bázových tříd
        //Konstruktor přijímá parametry jmeno, pohlavi a mzda a volá bázový konstruktor.Jako název povolání uloží řetězec "účetní"
        //Pokud se pracuje(tedy když se zavolá metoda Pracuj()), vrací metoda řetězec "Kontroluji faktury".
        public Ucetni(string jmeno, Enum pohlavi, int mzda) : base(jmeno, pohlavi, mzda, povolání = "učetní")
        {
        }

        override public string Pracuj()
        {
            return "kontroluji faktury";
        }
    }
}
