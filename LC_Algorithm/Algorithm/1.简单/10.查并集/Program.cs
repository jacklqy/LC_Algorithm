using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._10.查并集
{
    public class Program : OpentAlgorithm
    {
        /// <summary>
        /// 在.NET中实现查并集（Union）算法，可以使用HashSet<T>集合来高效地完成。下面是一个简单的示例代码，演示如何合并两个HashSet集合
        /// </summary>
        public override void Open()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 2, 3, 4 };

            HashSet<int> unionSet = new HashSet<int>(set1);
            unionSet.UnionWith(set2);

            foreach (int item in unionSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
