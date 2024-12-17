using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP2_030_bankovniucet
{
    internal class SporiciUcet : Ucet
    {
        public double UrokovaMira { get; private set; } = 1.35;

        public void Urokuj()
        {
            stav += stav * UrokovaMira / 100;
        }

    }
}
