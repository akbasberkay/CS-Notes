using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_Setter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person UncleJeff = new Person();
            UncleJeff.setName("Elon Musk");
            UncleJeff.setAge(51);
            Console.WriteLine("Name: " +  UncleJeff.getName());
            Console.WriteLine("Age: " + UncleJeff.getAge());
            Console.ReadLine();
        }
    }
}
