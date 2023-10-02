using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Hyena : Predator, Prey
    {
        public void Hunt()
        {
            Console.WriteLine("Hyena is hunting!!!");
        }
        public void Flee()
        {
            Console.WriteLine("Hyena is running for its life!!!");
        }
    }
}
