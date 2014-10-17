using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class SoldOutState : State
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Cannot Accept Quarter , The Machine is sold Out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Machine is sold out");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Machine is sold out");
        }

        public void Dispense()
        {
            Console.WriteLine("Machine is sold out");
        }

        public override string ToString()
        {
            return "Sold Out";
        }
    }
}
