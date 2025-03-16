using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_27._11_
{
    internal class Weapon : Item
    {
        public int Damege { get; private init; }
        public int Attack { get; private init; }
        public bool IsHanded { get; private init; }
        public bool IsTwoHanded { get; private init; }

        public Weapon(string name, int weight,int damege, int attack, bool isHanded, bool isTwoHanded) : base(name, weight)
        {
            Damege = damege;
            Attack = attack;
            IsHanded = isHanded;
            IsTwoHanded = isTwoHanded;
        }

    }
}
