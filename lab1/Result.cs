using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Result
    {
        public List<int> items;
        public int total_weight = 0;
        public int total_value = 0;

        public Result() { 
            items = new List<int>();
        }

        public string ToString() { 
            string items_str = string.Join(",", items.Select(x => x.ToString()).ToArray());


        }
    }
}
