using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double minval = double.MinValue;
            double maxval = double.MaxValue;
            double somenumber = 12.5545908;
            double secondnumber = 42.826451;
            double sumval = somenumber + secondnumber;
            double subtractval = somenumber - secondnumber;
            double multiplval = somenumber * secondnumber;
            double divideval = somenumber / secondnumber;
            Console.WriteLine(minval);
            Console.WriteLine(maxval);
            Console.WriteLine(sumval);
            Console.WriteLine(subtractval);
            Console.WriteLine(multiplval);
            Console.WriteLine(divideval);
            Console.ReadLine();
        }
    }
}
