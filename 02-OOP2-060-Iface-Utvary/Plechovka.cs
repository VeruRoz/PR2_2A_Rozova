using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_060_Iface_Utvary
{
    internal class Plechovka
    {
        
        public double Objem { get; set; }
        public double Vydatnost { get; set; }

        public Plechovka(double objem, double vydatnost)
        {
            Objem = objem;
            Vydatnost = vydatnost;
        }
        public override string ToString() => $"Plechovka barvy, zbývá jí ještě na {Objem} cm²";

//      bude mít veřejnou metodu Obarvi(), která obrdží IUtvar a pokud je v plechovce dost barvy na jeho obarvení, sníží svůj objem a vrátí true (úspěch),         jinak si ponechá původní objem a vrátí false (neúspěch)
        public bool Obarvi(IUtvary utvary)
        {
            if (Objem > utvary.GetObsah() *Vydatnost )
            {
                Objem -= utvary.GetObsah() * Vydatnost;
                return true;
            }
            else
                return false;
        }

      //Vytvořte instanci plechovky a vyzkoušejte obarvit všechny útvary z pole.Udělejte si pole větší, abyste vyzkoušeli i to, že plechovka dojde.

    }
}
