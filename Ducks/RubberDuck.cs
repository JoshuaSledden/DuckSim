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
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehaviour = new Squeak();
            flyBehaviour = new FlyNotPossible();
        }


        public void Display()
        {
            Console.WriteLine("Display Rubber Duck!");
        }
    }
}
