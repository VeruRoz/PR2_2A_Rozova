using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamestanci7
{
    internal class Firma
    {
        private List<zamestnanec> _personal = new List<zamestnanec>();
        public void Zamestnej (zamestnanec z)
        {
            if (!_personal.Contains(z))
                _personal.Add(z);
        }

        public void Propust(zamestnanec z)
        {
            _personal.Remove(z);
        }

        public void Vyplata()
        {
            int total = 0;
            int mzda;
            foreach (zamestnanec z in _personal)
            {
                mzda = z.Mzda();
                total += mzda;
                Console.WriteLine($"{z.Prijmení} {z.Jmeno} : {mzda} kč");
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine($"celkem {total} kč ");
        }

    }
}
