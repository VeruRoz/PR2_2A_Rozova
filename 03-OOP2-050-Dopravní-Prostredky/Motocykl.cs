using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP2_050_Dopravní_Prostredky
{
    internal sealed class Motocykl : DopravniProstredek
    {
        //        Vytvořte uzavřenou třídu Motocykl, která dědí z DP.

        //Konstruktor bude přijímat pouze maximální rychlost.Bude volat konstruktor bázové třídy a předávat mu reálné parametry (pohon je spalovací, počet míst 2)
        //Natankuj() vypíše do konzole "Plním nádrž benzínem"
        public Motocykl(string name, TypPohonu pohon, double maxRychlost, int početmíst) : base(name = "Motocykl", pohon = TypPohonu.SpalovaciMotor, maxRychlost, početmíst =2)
        {
        }

       public override void Natankuj()
        {
            Console.WriteLine("plním nádrž benzínem");
        }
    }
}
