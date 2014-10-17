using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class PanCakeHouseMenu : Menu
    {
        public List<string> items;

        public PanCakeHouseMenu()
        {
            items = new List<string>();
            AddItems("Vegeterian1");
            AddItems("Vegeterian2");
            AddItems("Vegeterian3");
            AddItems("Vegeterian4");
        }

        public void AddItems(string item)
        {
            items.Add(item);
        }

        public Iterator CreateIterator()
        {
            return new PanCakeHouseIterator(items);
        }
    }
}
