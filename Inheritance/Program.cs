using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat obj = new Cat();
            obj.animal_name = "Skittles";
            obj.animal_age = 10;
            obj.cat_specie = "Siamese";
            obj.SaHi();
            Console.ReadLine();
        }
    }
}
