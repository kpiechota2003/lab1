using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Item : IComparable<Item>
    {
        public int value;
        public int weight;
        public int index;
        public bool is_packed = false;

        public Item(int item_value, int item_weight, int item_index)
        {
            value = item_value;
            weight = item_weight;
            index = item_index;
        }

        public int CompareTo(Item other)
        {
            if (other == null) return 1;
            return (value * (1000 / weight)).CompareTo(other.value * (1000 / other.weight));
        }

        public static bool operator <(Item a, Item b)
        {
            if (ReferenceEquals(a, null)) return !ReferenceEquals(b, null);
            return a.CompareTo(b) < 0;
        }

        public static bool operator >(Item a, Item b)
        {
            if (ReferenceEquals(a, null)) return false;
            return a.CompareTo(b) > 0;
        }

        public override string ToString()
        {
            return $"no.: {index}  v: {value} w: {weight} [{value * (1000 /weight)}]";
        }
    }
}
