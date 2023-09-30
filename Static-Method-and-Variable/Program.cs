using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method_and_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 355793;
            double b = 457;
            double summed = Math.Add(a, b);
            double sbt = Math.Subtract(a, b);
            double mltp = Math.Multiply(a, b);
            double dvd = Math.Divide(a, b);
            Console.WriteLine(summed + " " + sbt + " " + mltp + " " + dvd + " " + Math.pi);
            Console.ReadLine();
        }
    }
}
