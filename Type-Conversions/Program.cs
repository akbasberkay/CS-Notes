using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convert class can do all of the work for this!!
            
            Console.WriteLine("Please input the first number: ");
            string inputVal1 = Console.ReadLine();
            int inputInt_1 = int.Parse(inputVal1);
            Console.WriteLine("Please input the second number: ");
            string inputVal2 = Console.ReadLine();
            int inputInt_2 = int.Parse(inputVal2);
            Console.WriteLine("Please inout the operator: ( + - * / )");
            string oppie = Console.ReadLine();
            int outputval = 0;
            if (oppie == "+") {
                outputval = inputInt_1 + inputInt_2;
            } else
            {
                if (oppie == "-")
                {
                    outputval = inputInt_1 - inputInt_2;
                }
                else
                {
                    if (oppie == "*")
                    {
                        outputval = inputInt_1 * inputInt_2;
                    }
                    else
                    {
                        if (oppie == "/")
                        {
                            outputval = inputInt_1 / inputInt_2;
                        }
                    }
                }
            }
            Console.WriteLine("Result is: " + outputval);
            Console.ReadLine();
        }
    }
}
