using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class FlyNoWay : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am not able to Fly");
        }
    }
}
