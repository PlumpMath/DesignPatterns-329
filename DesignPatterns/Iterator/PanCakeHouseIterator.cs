using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class PanCakeHouseIterator : Iterator
    {
        List<string> items;
        static int Position = 0;

        public PanCakeHouseIterator(List<string> items)
        {
            this.items = items;
        }
        public bool HasNext()
        {
            if (Position >= items.Count)
                return false;
            else
                return true;
        }

        public object Next()
        {
            var item = items[Position];
            Position = Position + 1;
            return item;
        }
    }
}
