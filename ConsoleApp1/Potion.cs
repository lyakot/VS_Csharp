using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Potion : Item, IDrinkable
    {
        public int Drink()
        {
            return 5;
        }

        public override string ToString()
        {
            return "Potion";
        }
    }
}
