using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class GumballMachine
    {
        public static State noQuarterState { get; set; }
        public static State hasQuarterState { get; set; }
        public static State soldOutState { get; set; }
        public static State soldState { get; set; }

        public static State state = soldOutState;
        static int count = 0;

        public GumballMachine(int number)
        {
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuaterState(this);
            soldOutState = new SoldOutState(this);
            soldState = new SoldState(this);

            count = number;

            if (number > 0)
                state = noQuarterState;
            
        }

        public void SetState(State newState)
        {
            state = newState;
        }

        public State GetCurrentState()
        {
            return state;
        }

        public State GetSoldOutState()
        {
            return soldOutState;
        }

        public State GetSoldState()
        {
            return soldState;
        }

        public State GetNoQuarterState()
        {
            return noQuarterState;
        }

        public State GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public int GetCount()
        {
            return count;
        }

        public void Refill(int number)
        {
            count = number;
            state = noQuarterState;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("Releasing Ball");
            if (count != 0)
                count = count - 1;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Sukhdeep Singh Saini's State Machine")
                .Append("\n Machine is currently having " + count + "Gumballs")
                .Append("\nPlease insert a Quarter to dispense a Gumball");
            return builder.ToString();
        }

    }

}
