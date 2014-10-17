using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            flyBehaviour = new FlyWithWings();
            QuackBehaviour = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Red Head Duck");
        }
    }
}
