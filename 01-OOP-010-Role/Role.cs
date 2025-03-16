using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_010_Role
{
    internal class Role
    {
        private string barva;

        public string Barva
        {
            get { return barva; }
            set { barva = value; }

        }

        public int Delka;

        public Role(string barva, int delka)
        {
            Barva = barva;
            Delka = delka;
        }
        public override string ToString()
        {
            return "$ role papíru";
        }
    }
}
