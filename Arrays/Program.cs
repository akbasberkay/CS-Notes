using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Porsche", "Lamborghini", "Mercedes", "BMW" };
            Console.WriteLine(cars);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars.Length);
            cars = cars.Append("Audi").ToArray();
            Console.WriteLine(cars.Length);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();
        }
    }
}
