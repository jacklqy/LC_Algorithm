using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._7.链表
{
    /// <summary>
    /// 在.NET中，链表（Linked List）是一种常见的数据结构，它由节点组成，每个节点包含两个部分：数据和指向下一个节点的引用。---非线程安全
    /// </summary>
    public class Program : OpentAlgorithm
    {
        public override void Open()
        {
            // 创建一个链表
            LinkedList<int> linkedList = new LinkedList<int>();

            // 添加节点
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);

            // 在开始处添加节点
            linkedList.AddFirst(5);
            // 在末尾处添加节点
            linkedList.AddLast(8);

            // 遍历链表
            foreach (var value in linkedList)
            {
                Console.WriteLine(value);
            }

            // 删除指定节点
            LinkedListNode<int> node = linkedList.Find(20);
            if (node != null)
            {
                linkedList.Remove(node);
            }

            // 再次遍历链表
            Console.WriteLine("\nAfter removal:");
            foreach (var value in linkedList)
            {
                Console.WriteLine(value);
            }

            // 清空链表
            linkedList.Clear();

            // 输出链表中的节点数
            Console.WriteLine("\nCount: " + linkedList.Count);
        }
    }
}
