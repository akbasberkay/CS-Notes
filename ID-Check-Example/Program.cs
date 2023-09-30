using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID_Check_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your ID number. It has to be 11 numbers: ");
            string idnum = Console.ReadLine();
            Citizen newpersonnel = new Citizen();
            newpersonnel.ID = idnum;
            Console.WriteLine(newpersonnel.ID);
            Console.ReadLine();
        }
    }
}
