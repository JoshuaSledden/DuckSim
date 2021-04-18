using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSim.Ducks.Behaviours.Fly
{
    class FlyNotPossible : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Fly not possible!");
        }
    }
}
