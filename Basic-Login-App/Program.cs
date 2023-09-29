using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Login_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "berkay";
            string password = "akbas";
            string usrinput = "";
            string passinput = "";
            int errcount = 0;
            while (true)
            {
                Console.WriteLine("Please type in username:");
                usrinput = Console.ReadLine();
                Console.WriteLine("Please type in password:");
                passinput = Console.ReadLine();
                if (usrinput != username || passinput != password)
                {
                    errcount ++;
                    Console.WriteLine("Incorrect attempt! " + (3-errcount) + " attempts left!");
                    if (errcount == 3)
                    {
                        Console.WriteLine("Login failed!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Welcome!");
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
