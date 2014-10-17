using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class PepporoniPizza : Pizza
    {
        public PepporoniPizza()
        {
            Name = "PepporoniPizza";
            Dough = "PepporoniPizzaDough";
            Sauce = "PepporoniPizzaSauce";
            toppings.Add("Peporonni");
            toppings.Add("Chicken");
        }
    }
}
