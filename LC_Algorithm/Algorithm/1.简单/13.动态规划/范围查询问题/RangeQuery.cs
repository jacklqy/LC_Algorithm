using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._13.动态规划.范围查询问题
{
    public class RangeQuery
    {
        /// <summary>
        /// 累计和
        /// </summary>
        private List<int> _cumulativeSum = [];

        /// <summary>
        /// 最大结束子序列和
        /// </summary>
        private List<int> _maxEndingHere = [];

        /// <summary>
        /// 最大开头子序列和
        /// </summary>
        private List<int> _maxStartingHere = [];

        public RangeQuery(List<int> numbers)
        {
            // 计算累计和和最大结束子序列和
            int cumulative = 0;
            int maxSum = int.MinValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                cumulative += numbers[i];
                _cumulativeSum.Add(cumulative);

                if (cumulative > maxSum)
                {
                    maxSum = cumulative;
                }

                _maxEndingHere.Add(maxSum);
            }

            // 逆向遍历预处理最大开头子序列和
            maxSum = int.MinValue;
            for (int i = _cumulativeSum.Count - 1; i >= 0; i--)
            {
                if (_cumulativeSum[i] > maxSum + _maxEndingHere[i])
                {
                    maxSum = _cumulativeSum[i];
                }
                _maxStartingHere.Add(maxSum - _cumulativeSum[i]);
            }

            // 反转最大开头子序列，确保索引顺序
            _maxStartingHere.Reverse();
        }

        /// <summary>
        /// 该方法接受一个范围[start, end]并返回该范围内的最大子序列和
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int Query(int start, int end)
        {
            if (start > end || start < 0 || end >= _cumulativeSum.Count)
            {
                throw new ArgumentException("Invalid range");
            }

            int maxSum = int.MinValue;
            for (int i = start; i <= end; i++)
            {
                int localMax = _maxEndingHere[i] - _maxStartingHere[i];
                if (localMax > maxSum)
                {
                    maxSum = localMax;
                }
            }

            return maxSum;
        }
    }
}
