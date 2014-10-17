using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "CheesePizza";
            Dough = "CheesePizzaDough";
            Sauce = "CheesePizzaSauce";
            toppings.Add("Cheese Delite");
            toppings.Add("Extra thin Crust Cheese");
        }
    }
}
