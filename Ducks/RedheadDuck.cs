using DuckSim.Ducks;
using DuckSim.Ducks.Behaviours.Fly;
using DuckSim.Ducks.Behaviours.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSim
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehaviour = new LoudQuack();
            flyBehaviour = new FlyWithWings();
        }

        public void Display()
        {
            Console.WriteLine("Display Redhead!");
        }
    }
}
