using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            Vehicle[] vehicles = { car, bicycle, boat };
            foreach (var vehicle in vehicles)
            {
                vehicle.Go();
            }
            Console.ReadLine();
        }
    }
}
