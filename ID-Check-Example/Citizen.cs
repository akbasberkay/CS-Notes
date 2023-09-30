using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID_Check_Example
{
    public class Citizen
    {
        private string id;
        private bool kontrol = false;
        public string ID { 
            get { 
                return id.Substring(1,5); 
            } 
            set { 
                if (value.Length == 11)
                {
                    foreach (var item in value)
                    {
                        if (char.IsNumber(item))
                        {
                            continue;
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("Non-Number character detected.");
                    }
                    else
                    {
                        id = value;
                    }
                }
                
            }
        }
    }
}
