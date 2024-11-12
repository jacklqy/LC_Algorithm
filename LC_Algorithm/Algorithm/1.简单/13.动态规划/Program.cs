using Algorithm._1.简单._13.动态规划.范围查询问题;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._13.动态规划
{
    /// <summary>
    /// 在.NET中，动态规划（Dynamic Programming，DP）通常用于解决具有重叠子问题和最优子结构性质的问题。这种算法优化技术可以提高时间效率，常见的应用场景包括：
    /// 1.求解最优化问题：动态规划可以用来解决各种求最大值、最小值、优先队列等问题。
    /// 2.范围查询问题：可以预处理出某个状态的值，然后通过动态规划快速求解。
    /// 3.背包问题：如0-1背包问题、完全背包问题、多重背包问题等。
    /// 4.串处理：如字符串匹配问题（KMP算法）、编辑距离问题（动态规划求解Levenshtein距离）。
    /// </summary>
    public class Program : OpentAlgorithm
    {
        public override void Open()
        {
            //范围查询问题
            List<int> numbers = new List<int> { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            RangeQuery rangeQuery = new RangeQuery(numbers);
            int start = 1, end = 5;
            Console.WriteLine($"Max subarray sum in range [{start}, {end}) is: {rangeQuery.Query(start, end)}");
        }
    }
}
