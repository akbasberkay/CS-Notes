using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_Setter
{
    public class Person
    {
        private string name;
        private int age;

        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }
        public void setAge(int _age)
        {
            age = _age;
        }
        public int getAge()
        {
            return age;
        }
    }
}
