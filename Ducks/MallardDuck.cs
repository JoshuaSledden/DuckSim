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
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehaviour = new LoudQuack();
            flyBehaviour = new FlyWithWings();
        }

        public void Display()
        {
            Console.WriteLine("Display Mallard!");
        }
    }
}
