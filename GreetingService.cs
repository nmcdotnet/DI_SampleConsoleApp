﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITTestCs
{
    internal class GreetingService : IGreetingService
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
