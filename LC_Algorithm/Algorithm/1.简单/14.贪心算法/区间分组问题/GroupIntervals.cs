using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._14.贪心算法.区间分组问题
{
    internal class GroupIntervals
    {
        /// <summary>
        /// 有一系列的区间，需要将这些区间分配到尽可能少的组中，使得每个组的区间两两之间没有公共点。
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int Query(List<Interval> intervals)
        {
            intervals.Sort((a, b) => a.Start.CompareTo(b.Start));

            List<int> ends = new List<int>();

            foreach (var interval in intervals)
            {
                int end = interval.End;
                int index = ends.BinarySearch(end);
                if (index < 0)
                {
                    ends.Insert(~index, end);
                }
            }

            return ends.Count;
        }
    }
}
