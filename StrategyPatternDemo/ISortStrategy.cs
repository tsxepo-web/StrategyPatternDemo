using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    public interface ISortStrategy
    {
        public void Sort(List<string> list);
    }
}
