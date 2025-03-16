using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP2_050_Dopravní_Prostredky
{
    internal abstract class Automobil : DopravniProstredek
    {
        //        Vytvořte abstraktní třídu Automobil, která dědí z DP.
        //Konstruktor bude přijímat všechny parametry z bodu 1 kromě názvu, pak zavolá konstruktor bázové třídy a vše jí předá(název je "automobilss
        protected Automobil(string name, TypPohonu pohon, double maxRychlost, int početmíst) : base(name = "Automobil",  pohon, maxRychlost, početmíst)
        {
        }
    }
}
