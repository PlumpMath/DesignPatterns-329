using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new FlyNoWay();
            QuackBehaviour = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Rubber Duck");
        }
    }
}
