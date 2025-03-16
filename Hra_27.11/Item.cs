﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_27._11_
{
    internal class Item
    {
        public string Name { get; private init; }
        public int Weight { get; private init; }

        public Item(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

    }
}
