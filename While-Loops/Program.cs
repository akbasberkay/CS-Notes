using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.WriteLine("---------------");
            int cnt = 100;
            while (cnt >= 0) { 
                if (cnt % 2 == 0)
                {
                    Console.WriteLine(cnt);
                }
                cnt--;
            }
            Console.ReadLine();
        }
    }
}
