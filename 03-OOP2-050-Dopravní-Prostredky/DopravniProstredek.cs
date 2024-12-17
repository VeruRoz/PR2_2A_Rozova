using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP2_050_Dopravní_Prostredky
{
    internal abstract class DopravniProstredek
    {
        //            Vytvořte abstraktní třídu DopravniProstredek. Ta bude mít

        // Veřejné vlastnosti Nazev(string), Pohon(TypPohonu), MaxRychlost(double) a PocetMist(int)
        //Konstruktor, který obdrží a uloží předchozí parametry
        //Abstraktní metodu Natankuj(), která nic nevrací
        //nějaký pěkný ToString() sestavený z vlastností prostředku

        public string Name;
        public TypPohonu Pohon;
        public double MaxRychlost;
        public int Početmíst;

        protected DopravniProstredek(string name, TypPohonu pohon, double maxRychlost, int početmíst)
        {
            Name = name;
            Pohon = pohon;
            MaxRychlost = maxRychlost;
            Početmíst = početmíst;
        }

        abstract void Natankuj()
        {

        }

        public string ToString()
        {
            
        }
    }
}
