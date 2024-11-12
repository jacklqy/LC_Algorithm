using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._9.优先队列
{
    public class Program : OpentAlgorithm
    {
        /// <summary>
        /// 以下就是在.NET中创建和使用优先队列的几种方法。选择哪种方法取决于你的具体需求和你的优先队列的具体要求（例如是否需要动态更新优先级，是否需要线程安全等）。
        /// </summary>
        public override void Open()
        {
            
        }

        /// <summary>
        /// .NET Framework提供了一个名为Queue的类，它可以被用作优先队列。然而，这个类并没有内置的优先级排序功能，因此你需要手动实现排序。
        /// </summary>
        private void Queue_Test()
        {
            Queue<int> priorityQueue = new Queue<int>();

            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(4);

            while (priorityQueue.Count > 0)
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }
        }

        /// <summary>
        /// SortedSet是.NET提供的一个集合，它会自动对添加到其中的元素进行排序。
        /// </summary>
        private void SortedSet_Test()
        {
            SortedSet<int> priorityQueue = new SortedSet<int>();

            priorityQueue.Add(3);
            priorityQueue.Add(1);
            priorityQueue.Add(4);

            foreach (var item in priorityQueue)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// 堆是一种特殊的数据结构，可以用来实现优先队列。在.NET中，可以使用Array.Sort或List.Sort方法来实现堆操作。
        /// </summary>
        private void List_Test()
        {
            List<int> priorityQueue = new List<int> { 3, 1, 4 };

            priorityQueue.Sort();

            foreach (var item in priorityQueue)
            {
                Console.WriteLine(item);
            }
        }

        ///// <summary>
        ///// 使用PriorityQueue类（需要NuGet安装"DataStructures"库）：
        ///// </summary>
        //private void PriorityQueue_Test()
        //{
        //    var priorityQueue = new DataStructures.PriorityQueue<int, int>();

        //    priorityQueue.Enqueue(3, 3);
        //    priorityQueue.Enqueue(1, 1);
        //    priorityQueue.Enqueue(4, 4);

        //    while (priorityQueue.Count > 0)
        //    {
        //        Console.WriteLine(priorityQueue.Dequeue());
        //    }
        //}
    }

    /// <summary>
    /// 线程安全队列
    /// </summary>
    public class ThreadSafeQueueExample
    {
        static ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

        static void Main()
        {
            Task producerTask = Task.Run(() => ProduceItems());
            Task consumerTask = Task.Run(() => ConsumeItems());

            Task.WaitAll(producerTask, consumerTask);
        }

        static void ProduceItems()
        {
            for (int i = 0; i < 10; i++)
            {
                concurrentQueue.Enqueue(i);
                Console.WriteLine($"Produced: {i}");
                Thread.Sleep(100); // Simulate production delay
            }
        }

        static void ConsumeItems()
        {
            int item;
            while (concurrentQueue.TryDequeue(out item))
            {
                Console.WriteLine($"Consumed: {item}");
                Thread.Sleep(100); // Simulate consumption delay
            }
        }
    }
}
