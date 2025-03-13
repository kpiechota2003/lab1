using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Item
    {
        public int value;
        public int weigth;
        public int index;
        public bool is_packed = false;
        public static bool operator <(Item a, Item b)
        {
            return a.value * a.weigth < b.value * b.weigth;
        }
        public static bool operator >(Item a, Item b)
        {
            return a.value * a.weigth > b.value * b.weigth;
        }

        public Item(int item_value, int item_weigth, int item_index)
        {
            value = item_value;
            weigth = item_weigth;
            index = item_index;
        }

        public void pack() { is_packed = true; }
        public void unpack() { is_packed = false; }

        public string ToString()
        {

        }
    }
}
