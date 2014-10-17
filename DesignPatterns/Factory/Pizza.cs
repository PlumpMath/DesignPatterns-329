using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public abstract class Pizza
    {
        public List<string> toppings = new List<string>();

        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }

        public void Prepare()
        {
            Console.WriteLine("I am Preparing the following pizza" + Name);
        }

        public void Bake()
        {
            Console.WriteLine("I am baking the Pizza" + Name);
        }

        public void Cut()
        {
            Console.WriteLine("I am Cutting the Pizza" + Name);
        }

        public void Box()
        {
            Console.WriteLine("I am Packing the pizza in the box" + Name);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("I made the ").Append(Name).Append("pizza")
                .Append("With Dough ").Append(Dough).Append("With Sauce ").Append(Sauce)
                .Append("for the customer");

            return builder.ToString();
        }


    }
}
