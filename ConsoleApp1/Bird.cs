using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bird : Animal, IFlyable
    {

        public void Fly()
        {
            Console.WriteLine("I'm Flyyyyying!");
        }

    }

}
