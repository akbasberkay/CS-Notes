using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person UncleJeff = new Person();
            UncleJeff.NAME = "Elon Musk";
            UncleJeff.AGE = 51;

            Console.WriteLine("Name: " + UncleJeff.NAME);
            Console.WriteLine("Age: " + UncleJeff.AGE);
            Console.ReadLine();
        }
    }
}
