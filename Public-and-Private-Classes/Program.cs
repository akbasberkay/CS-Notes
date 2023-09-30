using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_and_Private_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer(_id:1, _custname:"Berkay",_custsurname:"Akbas",_gender:"Male");
            
            //obj.id = 1;
            //obj.custname = "Berkay";
            //obj.custsurname = "Akbas";
            // obj.gender = "Male"; Inaccessible due to private 

            obj.SayHi();
            //obj.SayLo(); Inaccessible due to private

            // private methods can be accessed inside of other class methods of the same class
            // same goes for private attributes as well
            Console.ReadLine();
    }
    }
}
