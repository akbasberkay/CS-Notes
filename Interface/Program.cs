using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hyena hyena = new Hyena();
            hyena.Hunt();
            hyena.Flee();
            Person berkay = new Person("Berkay", 25);
            berkay.sayHi();
            Console.ReadLine();
        }
        public class Person
        {
            private string name;
            private int age;
            public Person(string _name, int _age)
            {
                name = _name;
                age = _age;
            }
            public void sayHi()
            {
                Console.WriteLine("Hello " + name + " with age " + age);
            }
        }
    }
}
