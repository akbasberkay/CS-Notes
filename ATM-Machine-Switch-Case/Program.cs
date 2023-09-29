using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter what you would like to do.");
            Console.WriteLine("1) Display balance");
            Console.WriteLine("2) Withdraw Money");
            Console.WriteLine("3) Deposit Money");
            Console.WriteLine("Press 'q' to exit ATM");
            string oprtn = Console.ReadLine();
            int balance = 1000;
            switch (oprtn) {
                case "1":
                    Console.WriteLine("Your balance is " + balance + ". Have  good day!");
                    break;
                case "2":
                    Console.WriteLine("Please insert withdrawal amount:");
                    string wthamountstr = Console.ReadLine();
                    int wthamount = Convert.ToInt32(wthamountstr);
                    if (wthamount > balance) {
                        Console.WriteLine("That amount cannot be withdrawed!");
                    }
                    else
                    {
                        int newbalancewth = balance - wthamount;
                        Console.WriteLine("Your new balance is " + newbalancewth + ". Have  good day!");
                    }
                    break;
                case "3":
                    Console.WriteLine("Please insert deposit amount: ");
                    string dpsamountstr = Console.ReadLine();
                    int dpsamount = Convert.ToInt32(dpsamountstr);
                    int newbalancedps = balance + dpsamount;
                    Console.WriteLine("Your new balance is " + newbalancedps + ". Have  good day!");
                    break;
                case "q":
                    Console.WriteLine("You exited the ATM Machine. Have a good day");
                    break;
                default: 
                    Console.WriteLine("You should be inputting the options you are given to");
                    break;
            }
            Console.ReadLine();
        }
    }
}
