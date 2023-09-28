using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your score: ");
            string strinput = Console.ReadLine();
            int actualnote = int.Parse(strinput);
            string noteletter = "";
            if (actualnote > 80) {
                noteletter = "A";
            }
            else if (actualnote >= 60 && actualnote < 80)
            { 
                noteletter = "B";
            }
            else if (actualnote >= 40 && actualnote < 60)
            {
                noteletter = "C";
            }
            else if (actualnote < 40 )
            {
                noteletter = "F";
            }
            Console.WriteLine("Your grade is: " + noteletter);
            Console.ReadLine();
        }
    }
}
