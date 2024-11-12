using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._8.栈与队列
{
    /// <summary>
    /// 在.NET中，推荐使用泛型版的Stack<T>和Queue<T>，因为它们提供了类型安全和更好的性能。---非线程安全
    /// </summary>
    public class Program : OpentAlgorithm
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 后进先出（LIFO）
        /// </summary>
        private void Stack_Test()
        {
            // 使用泛型Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(1); // 入栈
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop()); // 3 - 出栈
            Console.WriteLine(stack.Peek()); // 2 - 查看栈顶元素但不移除
        }

        /// <summary>
        /// 先进先出（FIFO）
        /// </summary>
        private void Queue_Test()
        {
            // 使用泛型Queue
            Queue<char> queue = new Queue<char>();
            queue.Enqueue('a'); // 入队
            queue.Enqueue('b');
            queue.Enqueue('c');

            Console.WriteLine(queue.Dequeue()); // a - 出队
            Console.WriteLine(queue.Peek()); // b - 查看队首元素但不移除
        }
    }
}
