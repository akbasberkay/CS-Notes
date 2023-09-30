using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_and_Private_Classes
{
    public class Customer
    {
        public int id;
        public string custname;
        public string custsurname;
        private string gender;
        public Customer(int _id, string _custname, string _custsurname, string _gender)
        {
            Console.WriteLine("Constructing...");
            id = _id;
            custname = _custname;
            custsurname = _custsurname;
            gender = _gender;
        }

        public void SayHi()
        {
            Console.WriteLine("Hello " + custname + " " + custsurname);
            SayLo("aaa","bbb");
        }

        private void SayLo(string frst, string scnd) {
            Console.WriteLine("Hello " + frst + " " + scnd);
        }
    }
}
