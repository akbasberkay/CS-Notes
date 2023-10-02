using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string animal_name;
        public int animal_age;
        public void SaHi()
        {
            Console.WriteLine("This animals name is: " +  animal_name);
            Console.WriteLine("This animals age is: " + animal_age);
        }
    }
}
