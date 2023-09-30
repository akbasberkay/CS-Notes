using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somenumber1 = 8;
            string somestring2 = "helloooo!";
            MyFirstClass berkay = new MyFirstClass(somenumber1,somestring2);
            berkay.FirstClassFunction();
            Console.WriteLine(berkay.somenumber + " " + berkay.somestring);
            Console.ReadLine();
        }
    }
}
