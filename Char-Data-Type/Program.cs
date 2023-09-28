using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ' is important for declaring. Char can only have 1 character.
            char first = 'A';
            char second = 'B';
            Console.WriteLine(first);
            Console.WriteLine(second);
            // " is used for declaring. Strins can have multiple characters.
            string third = "Berkay";
            string fourth = "Akbaş";
            Console.WriteLine(third);
            Console.WriteLine(fourth);
            Console.ReadLine();
        }
    }
}
