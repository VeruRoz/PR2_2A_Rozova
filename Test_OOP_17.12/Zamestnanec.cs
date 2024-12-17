using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP_17._12_
{
    internal abstract class Zamestnanec : Clovek
    {
        //        Abstraktní třída Zamestnanec
        //Rozšiřuje třídu Clovek
        //Obsahuje veřejné vlastnosti Mzda(celé číslo) a Povolani(řetězec)
        //veřejně je lze číst
        //dědící třídy je mohou nastavit, celý svět ne
        //Její konstruktor přijímá kromě jména a pohlaví také mzdu a povolání.Pak volá bázový konstruktor a mzdu a povolání ukládá přímo.
        //Předepisuje dědícím třídám existenci metody Pracuj(), která vrací řetězec.Třída Zamestnanec ji ale neimplementuje.


        private int Mzda { get; init; }
        private string Povolání { get; init; }

        protected Zamestnanec(int mzda, string povolání)
        {
            Mzda = mzda;
            Povolání = povolání;
        }
        public abstract string Pracuj();
    }
}
