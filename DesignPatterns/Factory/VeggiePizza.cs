using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            Name = "VeggiePizza";
            Dough = "VeggiePizzaDough";
            Sauce = "VeggiePizzaSauce";
            toppings.Add("Veggie Delite");
            toppings.Add("Jalapeno");
        }

    }
}
