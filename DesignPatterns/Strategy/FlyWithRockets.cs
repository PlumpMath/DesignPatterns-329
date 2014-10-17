using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class FlyWithRockets : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am Flying Using the Rockets");
        }
    }
}
