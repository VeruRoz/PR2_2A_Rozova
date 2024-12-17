using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamestanci7
{
    internal class StalyZamestanec : zamestnanec
    {
        private int _mzda;

        public StalyZamestanec(string jmeno, string prijmeni, int mzda) :base(jmeno, prijmeni)
        {
            _mzda = mzda;
        }
        public override int Mzda()
        {
            return _mzda;
        }
    }
}
