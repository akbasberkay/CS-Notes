using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sayhi_1();
            string returnval1 = SayHi_2();
            Console.WriteLine(returnval1);
            string returnval2 = SayHi_3("Hello3!");
            Console.WriteLine(returnval2);
            Console.WriteLine("Lets add 2 numbers using a function");
            Console.Write("First number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            int sumVal = SumNum(num2, num1);
            Console.WriteLine("Sum of total is: " + sumVal);
            Console.ReadLine();
        }
        //without parameter or return
        static void Sayhi_1() {
            Console.WriteLine("Hello1!");
        }
        //without parameter
        static string SayHi_2() {
            return "Hello2!";
        }
        //with both parameter and return
        static string SayHi_3(string param1) {
            return param1;
        }
        //with 2 parameters
        static int SumNum(int param1,  int param2)
        {
            return param1 + param2;
        }
    }
}
