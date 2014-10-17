using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class HasQuaterState : State
    {
        GumballMachine gumballMachine;

        public HasQuaterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("Already having a Quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter Ejected");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning The Crank");
            gumballMachine.SetState(gumballMachine.GetSoldState());
        }

        public void Dispense()
        {
            Console.WriteLine("Dispensed");

        }
    }
}
