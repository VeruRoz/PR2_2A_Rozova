using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamestanci7
{
    internal abstract class zamestnanec
    {
        public string Jmeno { get; private set; }
        public string Prijmení { get; private set; }
        protected zamestnanec(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmení = prijmeni;
        }
        public abstract int Mzda()

    }
}
