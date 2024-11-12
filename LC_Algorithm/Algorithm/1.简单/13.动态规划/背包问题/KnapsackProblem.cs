using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._13.动态规划.背包问题
{
    public class KnapsackProblem
    {
        /// <summary>
        /// 其中weights和values分别代表物品的重量和价值，capacity代表背包的最大容量。使用了二维数组dp来记录状态，最后输出了最大价值
        /// </summary>
        public void Query()
        {
            int[] weights = { 2, 1, 3, 2 }; // 物品的重量
            int[] values = { 3, 2, 4, 2 }; // 物品的价值
            int capacity = 5; // 背包的容量

            int[,] dp = new int[weights.Length + 1, capacity + 1];

            for (int i = 1; i <= weights.Length; i++)
            {
                for (int j = 1; j <= capacity; j++)
                {
                    if (weights[i - 1] <= j)
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - weights[i - 1]] + values[i - 1]);
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            Console.WriteLine($"最大价值: {dp[weights.Length, capacity]}");
        }
    }
}
