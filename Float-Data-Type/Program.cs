using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float minval = float.MinValue;
            float maxval = float.MaxValue;
            //Have to put f to the end of the floating number; otherwise its understood as double type and throws error
            float somenumber = 12.55f;
            Console.WriteLine(minval);
            Console.WriteLine(maxval);
            Console.ReadLine();
        }
    }
}
