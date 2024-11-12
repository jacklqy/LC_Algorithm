using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._14.贪心算法.背包问题
{
    internal class KnapsackProblem
    {
        /// <summary>
        /// 背包问题：有一个背包，背包的容量是M，有N个物品，每个物品的体积是Vi，价值是Wi，求如何装入物品才能使背包内物品的总价值最大。
        /// </summary>
        /// <param name="values"></param>
        /// <param name="weights"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public int Query(int[] values, int[] weights, int capacity)
        {
            int n = values.Length;
            int[] knapsack = new int[capacity + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = capacity; j >= weights[i]; j--)
                {
                    knapsack[j] = Math.Max(knapsack[j], knapsack[j - weights[i]] + values[i]);
                }
            }

            return knapsack[capacity];
        }
    }
}
