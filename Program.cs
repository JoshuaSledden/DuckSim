using DuckSim.Ducks;
using System;

namespace DuckSim
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallard = new MallardDuck();
            mallard.Display();
            mallard.Quack();
            mallard.Swim();
            mallard.Fly();

            var red = new RedheadDuck();
            red.Display();
            red.Quack();
            red.Swim();
            red.Fly();

            var rubber = new RubberDuck();
            rubber.Display();
            rubber.Quack();
            rubber.Swim();
            rubber.Fly();
        }
    }
}
