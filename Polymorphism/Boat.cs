﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("boat is boating!!!");
        }
    }
}
