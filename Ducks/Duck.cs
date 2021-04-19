using DuckSim.Ducks.Behaviours.Fly;
using DuckSim.Ducks.Behaviours.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSim.Ducks
{
    public abstract class Duck
    {
        public IFlyBehaviour flyBehaviour { get; set; }
        public IQuackBehaviour quackBehaviour { get; set; }

        public void Quack()
        {
            quackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Swim!");
        }

        public void Display()
        {
            Console.WriteLine("Display!");
        }

        public void Fly()
        {
            flyBehaviour.Fly();
        }
    }
}
