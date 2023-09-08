using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    public class ShellSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.ShellSort();
            Console.WriteLine("ShellSorted list ");
        }
    }
}
