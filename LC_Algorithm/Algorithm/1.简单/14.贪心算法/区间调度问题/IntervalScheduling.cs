using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._14.贪心算法.区间调度问题
{
    internal class IntervalScheduling
    {
        /// <summary>
        /// 有很多间隔的集合，每个集合有一个开始和结束时间，选择尽可能多的集合，使得它们互不重叠。
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public List<Interval> Query(List<Interval> intervals)
        {
            intervals.Sort((a, b) => a.End.CompareTo(b.End));

            List<Interval> selected = new List<Interval>();

            for (int i = 0; i < intervals.Count; i++)
            {
                Interval current = intervals[i];
                if (selected.Count == 0 || selected.Last().Start >= current.Start)
                {
                    selected.Add(current);
                }
            }

            return selected;
        }
    }
}
