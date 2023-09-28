using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 365;
            int b = 5;
            //Math Operators
            int c = a + b;
            Console.WriteLine(c);
            int d = a - b;
            Console.WriteLine(d);
            int e = a * b;
            Console.WriteLine(e);
            int f = a / b;
            Console.WriteLine(f);
            int g = a % b;
            Console.WriteLine(g);
            a-- ;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
