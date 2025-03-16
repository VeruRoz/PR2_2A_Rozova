using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP_17._12_
{
    internal class Skupina
    {
        //        Třída Skupina
        //Má soukromou položku _zamestnanci: pole/list objektů třídy Zamestnanec
        //Má veřejnou metodu DoPrace(), která nejprve vypíše "Pracuje N zaměstanců" (kde N je počet prvků kolekce _zamestnanci) a pak postupně nechá pracovat všechny zaměstnance věcí z pole výše a vypíše, kdo a jak pracuje(=návratovou hodnotu metod) do konzole.Metoda nic nevrací.Ukázka je připravená v main.cs
        //Má veřejnou read-only vlastnost Popis, která vrací popis podle šablony "Skupina 3 mužů a 5 žen" (podle dat uložených v jednotlivých objektech)
        //Má veřejnou read-only vlastnost PrumernaMzda, která vrací průměrnou mzdu všech zaměstnanců ve skupině
        //V konstruktoru přijímá pole zaměstnanců a nakopíruje si ho(viz první bod třídy Skupina).


         
        private List<Zamestnanec> _zamestnanci = new List<Zamestnanec>();

        public void DoPrace()
        {
            Console.WriteLine($"pracuje {_zamestnanci.Count} zaměstnancu");
            for (int i = 0; i < _zamestnanci.Count; i++)
            {
                _zamestnanci[i].Pracuj();
            }
        }
               
        public string Popis { get; private set; } = $"skupina {_zamestnanci.Pohlavi.Muz.Count} mužu {_zamestnanci.Pohlavi.Zena.Count} zen";
        public double PrumernaMzda() //{ get; private set; } 
        {
            double cel = 0;
            for (int i = 0; i < _zamestnanci.Count; i++)
            {
                cel =+ _zamestnanci[i].Mzda;

            }
            cel = cel / _zamestnanci.Count;
        }
        public Skupina(List<Zamestnanec> zamestnanci, string popis, double prumernaMzda)
        {
            _zamestnanci = zamestnanci;
            Popis = popis;
            PrumernaMzda = prumernaMzda;
        }
    }
}
