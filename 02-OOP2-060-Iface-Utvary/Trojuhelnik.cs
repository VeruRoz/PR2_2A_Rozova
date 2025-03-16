using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_060_Iface_Utvary
{
    internal class Trojuhelnik : IUtvary
    {
        public string Nazev => "Trojuhelnik";
        public double Strana { get; init; }
        public double Strana2 { get; init; }
        public double Strana3 { get; init; }

        public Trojuhelnik(double strana, double strana2, double strana3)
        {
            Strana = strana;
            Strana2 = strana2;
            Strana3 = strana3;
        }

        public double GetObsah()
        {
            double s= GetObvod() / 2;
            return Math.Sqrt(s * (s - Strana) * (s - Strana2) * (s - Strana3));
        }

        public double GetObvod() => Strana + Strana2 + Strana3;

        public override string ToString() => $"Trojuhelnik o stanách {Strana}cm, {Strana2}cm, {Strana3}cm";

    }
}
