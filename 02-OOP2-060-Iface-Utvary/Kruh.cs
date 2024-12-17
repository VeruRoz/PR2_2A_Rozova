using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_060_Iface_Utvary
{
    internal class Kruh : IUtvary
    {
        public string Nazev => "Kruh";
        public double Polomer { get; init; }

        public Kruh(double r)
        {
            Polomer = r;
        }

        public double GetObsah() => Math.PI * Polomer* Polomer;

        public double GetObvod() => Math.PI * Polomer;
        public override string ToString() => $"kruh o polomer {Polomer} cm";

    }
}
