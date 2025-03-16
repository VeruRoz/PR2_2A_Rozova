using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_27._11_
{
    internal class Dice
    {
        private static Random random;

        private static GetRandom()
        {
            if (random == null)
                random = new Random();

            return random;
        }
        public int Roll()
        {
            random rdn = GefRandom();
        }
    }
}
