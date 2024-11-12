using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._14.贪心算法.装箱问题
{
    internal class BinPackingProblem
    {
        /// <summary>
        /// 有一些可以装入背包的物品，每个物品有一个体积Vi，求如何选择物品才能使背包的总体积最小。
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public int Query(int[] values)
        {
            int n = values.Length;
            int currentCapacity = 0;
            int wastedSpace = 0;

            Array.Sort(values, (a, b) => b.CompareTo(a)); // 从大到小排序

            foreach (int value in values)
            {
                if (currentCapacity + value <= currentCapacity)
                {
                    wastedSpace += currentCapacity - value;
                    currentCapacity = value;
                }
            }

            return wastedSpace;
        }
    }
}
