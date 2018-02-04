﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.Fly;

namespace Strategy.Ducks
{
    public class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFly();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I'm a rubber duck!");
        }
    }
}
