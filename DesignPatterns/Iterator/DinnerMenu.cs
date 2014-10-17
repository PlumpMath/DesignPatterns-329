using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class DinnerMenu : Menu
    {
        public string[] items;
        public static int Position = 0;

        public DinnerMenu()
        {
            items = new string[10];
            AddItems("Chicken");
            AddItems("Chicken2");
            AddItems("Chicken3");
            AddItems("Chicken4");
        }

        public void AddItems(string item)
        {
            if(Position >= items.Length)
                Console.WriteLine("Cannot Add more items to Menu , size full");
            else
            {
                items[Position] = item;
                Position = Position + 1;
            }
        }

        public Iterator CreateIterator()
        {
            return new DinnerMenuIterator(items);
        }
    }
}
