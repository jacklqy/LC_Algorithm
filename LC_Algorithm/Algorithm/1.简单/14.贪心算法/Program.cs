using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._14.贪心算法
{
    /// <summary>
    /// 贪心算法的关键在于定义问题的最优子结构和制定贪心策略，然后通过一系列的局部决策最终得到全局最优解。
    /// </summary>
    public class Program : OpentAlgorithm
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }
    }

    public class Interval
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Interval(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}
