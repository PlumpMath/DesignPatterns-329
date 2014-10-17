using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class PizzaStore
    {
        SimplePizzaFactory factory{get;set;}

        public PizzaStore(SimplePizzaFactory fb)
        {
            this.factory = fb;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;
            pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
