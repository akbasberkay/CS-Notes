using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method_and_Variable
{
    public class Math
    {
        public static double pi = 3.14;
        public static double Add(double a, double b) {  
            return a + b; 
        }
        public static double Subtract(double a, double b) {  
            return a - b; 
        }
        public static double Multiply(double a, double b) {  
            return a * b; 
        }
        public static double Divide(double a, double b) {  
            return a / b; 
        }
    }
}
