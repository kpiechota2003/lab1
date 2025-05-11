using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestProject1")]

namespace lab1
{
    internal class Problem
    {
        public List<Item> items;
        public Problem(int n, int seed)
        {
            Random random = new Random(seed);
            items = new List<Item>();

            for (int i = 0; i < n; i++) {
                int value = random.Next(1, 11);
                int weigth = random.Next(1, 11);
                items.Add(new Item(value, weigth, i));
            }

        }

        public Result Solve(int capacity)
        {
            Result result = new Result();
            int cur_weigth = 0;
            int cur_value = 0;

            //if n=0?

            //operatory <, > są przeciążone, uwzględniają wartość i masę
            items.Sort();
            items.Reverse();

            for (int i = 0; i < items.Count; i++) {
                if (items[i].weight + cur_weigth <= capacity) {
                    result.items.Add(items[i].index);
                    cur_weigth += items[i].weight;
                    cur_value += items[i].value;
                }
            }

            result.total_weight = cur_weigth;
            result.total_value = cur_value;

            return result;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, items.Select(item => item.ToString()));
        }
    }
}
