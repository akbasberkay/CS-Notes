using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class MyFirstClass
    {
        public int somenumber;
        public string somestring;
        public MyFirstClass( int _somenumber, string _somestring)
        {
            somenumber = _somenumber;
            somestring = _somestring;
        }

        public void FirstClassFunction()
        {
            Console.WriteLine("Doing something");
        }
    }
}
