using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hyena hyena = new Hyena();
            hyena.Hunt();
            hyena.Flee();
            Console.ReadLine();
        }
    }
}
