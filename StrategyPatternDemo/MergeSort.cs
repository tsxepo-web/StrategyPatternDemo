using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    public class MergeSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.MergeSort();
            Console.WriteLine("MergeSorted list ");
        }
    }
}
