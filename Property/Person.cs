using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class Person
    {
        private string name;
        private int age;
        public string NAME { 
            get {
                return name;
            } set { 
                name = value;
            }
        
        }
        public int AGE { 
            get {
                return age;
            } 
            set { 
                age = value;
            } 
        }
    }
}
