using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class NormalQuack : QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Hey Buddy , I am Quacking Normally");
        }
    }
}
