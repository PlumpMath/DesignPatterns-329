using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class DinnerMenuIterator : Iterator
    {
        string[] items;
        static int Position = 0;
        public DinnerMenuIterator(string[] items)
        {
            this.items = items;
        }
        public bool HasNext()
        {
            if (Position >= items.Length)
                return false;
            else
                return true;
        }

        public object Next()
        {
            string item = items[Position];
            Position = Position + 1;
            return item;
        }
    }
}
