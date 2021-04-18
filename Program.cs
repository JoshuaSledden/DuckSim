using System;

namespace DuckSim
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new Duck();
            duck.Display();
            duck.Quack();

            var mallard = new MallardDuck();
            mallard.Display();
            mallard.Quack();

            var red = new RedheadDuck();
            red.Display();
            red.Quack();

            var rubber = new RubberDuck();
            rubber.Display();
            rubber.Quack();
        }
    }
}
