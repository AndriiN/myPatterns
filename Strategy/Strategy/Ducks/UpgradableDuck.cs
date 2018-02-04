using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.Fly;
using Strategy.Quack;

namespace Strategy.Ducks
{
    public class UpgradableDuck : DuckBase
    {
        public UpgradableDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm an upgradable duck!");
        }
    }
}
