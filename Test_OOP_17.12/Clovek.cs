using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP_17._12_
{
    internal class Clovek
    {
//        řída Clovek
//Má vlastnosti Jmeno(řetězec) a Pohlavi(enumerace viz výše) které lze veřejně číst a dědící třídy je mohou nastavit, celý svět ne
//Vlastnosti Jmeno a Pohlavi přijme konstruktor jako parametry a nastaví
//Přepisuje bázovou metodu ToString() tak, že vypíše něco jako "Jmenuji se Alena a jsem žena" (samozřejmě podle hodnot uložených v objektu)

        private string jméno { get; init; }
        private enum Pohlavi { Muz, Zena };


    } 
}
