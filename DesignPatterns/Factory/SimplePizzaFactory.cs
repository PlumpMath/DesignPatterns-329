using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class SimplePizzaFactory
    {       
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("Cheese"))
                pizza = new CheesePizza();
            else if (type.Equals("Veggie"))
                pizza = new VeggiePizza();
            else if (type.Equals("cheese"))
                pizza = new PepporoniPizza();

            return pizza;
        }
    }
}
