using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamestanci7
{
    internal class dobrovilnik : zamestnanec
    {
        public dobrovilnik(string jmeno, string prijmeni) : base(jmeno, prijmeni)
        {
        }

        public override int Mzda()
        {
            return 0;
        }
    }
}
