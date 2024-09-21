using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_040_Test_vyrobku
{
    internal class Vyrobek
    {
        private double _rozmer = 1.1;
        public double Rozmer
        {
            get
            {
               return _rozmer;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Rozměr musí být kladné číslo.");
                }
                _rozmer = value;
            }
        }

        public void vyrobek(double rozmer)
        {
           Rozmer  = rozmer;
        }
    }
}
