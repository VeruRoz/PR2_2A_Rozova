using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_040_Test_vyrobku
{
    internal class Tester

    {
        Vyrobek vyrobek = new Vyrobek();
        private double _vzor = 1;
        public double Vzor
        {
            get { return _vzor; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                else
                    _vzor = value;
            }
        }
        private double tolerance = 0.1;
        public double Tolerance
        {
            get { return tolerance; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                else
                    tolerance = value;
            }
        }

        public void tester(double Vzor, double Tolerance)
        {
            _vzor = Vzor;
            tolerance = Tolerance;
        }
        public bool Vyhovuje()
        {
            if (vyrobek == null)
            {
                throw new ArgumentNullException();
            }

            if (_vzor <= vyrobek.Rozmer + tolerance && _vzor >= vyrobek.Rozmer - tolerance)
            {
                return true;
            }
            else
                return false;
        }
    }
}
