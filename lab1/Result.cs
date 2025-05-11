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

        public override string ToString() {
            string items_str = string.Join(", ", items);
            string weigth_str = string.Join("\ntotal weigth: ", total_weight.ToString());
            string value_str = string.Join("\ntotal value: ", total_value.ToString());

            return $"result: {items_str}, [w,v]=[{weigth_str}, {value_str}]";
        }
    }
}
