using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamestanci7
{
    internal class brigadnik : zamestnanec
    {
        public brigadnik(string jmeno, string prijmeni) : base (jmeno, prijmeni)
        {

        }

        public int Odpracováno { get; set; }
        public int HodinováMzda { get; set; }

        public override int Mzda()
        {
            return Odpracováno + HodinováMzda;
        }
    }
}
