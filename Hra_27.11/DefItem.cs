using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_27._11_
{
    internal abstract class DefItem : Item
    {
        public int Defance { get; private init; }

        public DefItem(string name, int weight, int defance) : base(name, weight)
        {
            Defance = defance;
        }
    }
}
