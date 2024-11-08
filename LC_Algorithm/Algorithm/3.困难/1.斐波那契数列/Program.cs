using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._3.困难._1.斐波那契数列
{
    /// <summary>
    /// 斐波那契数列（Fibonacci sequence），又称黄金分割数列，因数学家莱昂纳多·斐波那契（Leonardoda Fibonacci）以兔子繁殖为例子而引入，故又称为“兔子数列”，
    /// 指的是这样一个数列：0、1、1、2、3、5、8、13、21、34、……这个数列从第三项开始，每一项都等于前两项之和。裴波那契数列最具有和谐之美的地方是，越往后，相邻两项的比值会无限趋向于黄金比1:0.618
    /// </summary>
    public class Program : OpentAlgorithm
    {
        /// <summary>
        /// 以下是一个简单的动态规划示例，实现斐波那契数列的动态规划算法：
        /// </summary>
        public override void Open()
        {
            int n = 10;
            int result = Fibonacci(n);
            Console.WriteLine($"Fibonacci of {n} is {result}");
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;

            var memo = new Dictionary<int, int>();
            memo.Add(0, 0);
            memo.Add(1, 1);

            return Helper(memo, n);
        }

        private static int Helper(Dictionary<int, int> memo, int n)
        {
            if (memo.ContainsKey(n))
            {
                return memo[n];
            }
            else
            {
                int value = Helper(memo, n - 1) + Helper(memo, n - 2);
                memo.Add(n, value);
                return value;
            }
        }
    }
}
