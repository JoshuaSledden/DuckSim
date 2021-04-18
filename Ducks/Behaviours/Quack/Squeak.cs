using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSim.Ducks.Behaviours.Quack
{
    class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
