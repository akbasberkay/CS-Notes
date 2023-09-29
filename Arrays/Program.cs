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
            //string[] cars = { "Porsche", "Lamborghini", "Mercedes", "BMW" };
            //Console.WriteLine(cars);
            //Console.WriteLine(cars[1]);
            //Console.WriteLine(cars.Length);
            //cars = cars.Append("Audi").ToArray();
            //Console.WriteLine(cars.Length);

            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            int[] numbers = new int[10];
            int evensum = 0;
            int evencount = 0;
            int oddsum = 0;
            int oddcount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int numtoshow = i + 1;
                Console.Write(numtoshow + ". number to input: ");
                int inputnum = Int32.Parse(Console.ReadLine());
                numbers[i] = inputnum;
            }

            foreach (int j in numbers) { 
                if (j % 2 == 0) {
                    evencount++;
                    evensum += j;
                }
                else
                {
                    oddsum += j;
                    oddcount++;
                }
            }
            Console.WriteLine("Odd number count: " + oddcount);
            Console.WriteLine("Even number count: " + evencount);
            Console.WriteLine(evensum);
            Console.WriteLine(oddsum);
            if (evensum > oddsum) {
                Console.WriteLine("Even numbers are bigger than odd numbers!");
            } else if (oddsum > evensum) {
                Console.WriteLine("Odd numbers are bigger than even numbers!");
            }
            else
            {
                Console.WriteLine("Odd numbers are equal to even numbers!");
            }
            Console.ReadLine();
        }
    }
}
