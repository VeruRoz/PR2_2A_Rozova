using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP2_030_bankovniucet
{
    internal class Ucet
    {
        public double stav { get; private set; }

        public void Vyber(double castka)
        {
            if (castka < 0)
                throw new ArgumentOutOfRangeException();
            else
            {
                if (castka > stav)
                    throw new ArgumentOutOfRangeException();
                else
                {
                    stav = stav - castka;
                    Console.WriteLine("bylo vybráno " + castka);
                }
            }
        }

        public void Uloz(double castka)
        {
            if (castka < 0)
                throw new ArgumentOutOfRangeException();
            else
            {
                 stav = stav + castka;
                 Console.WriteLine("bylo uloženo " + castka);
            }
        }
        public void ToString()
        {
            Console.WriteLine($"váš zůstatek na učte je {stav}Kč");
        }
    }
}
