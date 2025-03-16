using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_27._11_
{
    internal class Inventory
    {
        private List<Item> _items = new List<Item>();

        public int TotalWeight => _items.Sum(x => x.Weight);

        public void Take(Item item)
        {
            _items.Add(item);
        }
        public void Drop(Item item)
        {
            _items.Remove(item);
        }
        public bool Contains(Item item) => _items.Contains(item);
    }
}
