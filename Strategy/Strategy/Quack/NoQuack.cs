using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Quack
{
    public class NoQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
