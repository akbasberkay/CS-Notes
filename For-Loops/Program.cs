using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the printed amount:");
            string amnt = Console.ReadLine();
            int amntint = Convert.ToInt32(amnt);
            for (int i = 0; i < amntint; i++) { 
                Console.WriteLine(i);
                Console.WriteLine("Have a good day!!");
            }
            Console.ReadLine();
        }
    }
}
