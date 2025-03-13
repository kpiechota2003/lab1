using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Problem
    {
        public List<Item> Items;
        int n_items = 0;
        public Problem(int n, int seed)
        {
            Random random = new Random(seed);
            Items = new List<Item>();

            for (int i = 0; i < n; i++) {
                int value = random.Next(1, 11);
                int weigth = random.Next(1, 11);
                Items.Add(new Item(value, weigth, i));
            }

        }

        public Result Solve(int capacity)
        {
            Result result = new Result();
            int cur_weigth = 0;
            int cur_value = 0;

            //if n=0?

            //operatory <, > są przeciążone, uwzględniają wartość i masę
            Items.Sort();

            for (int i = 0; i < Items.Count; i++) {
                if (Items[i].weigth + cur_weigth <= capacity) {
                    result.items.Add(i);
                    cur_weigth += Items[i].weigth;
                    cur_value += Items[i].value;
                }
            }

            result.total_weight = cur_weigth;
            result.total_value = cur_value;

            return result;
        }
    }
}
