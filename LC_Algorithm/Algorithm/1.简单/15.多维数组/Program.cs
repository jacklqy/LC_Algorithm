using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._15.多维数组
{
    public class Program : OpentAlgorithm
    {
        /// <summary>
        /// 注意，多维数组的索引是基于每个维度的，例如在二维数组中，GetLength(0)返回第一维的长度，GetLength(1)返回第二维的长度。在三维数组中，你会有GetLength(0)、GetLength(1)和GetLength(2)。
        /// 多维数组在.NET中非常有用，特别是在表达矩阵、立体坐标或其他数学结构时。但是，需要注意的是，多维数组的索引可能会使得理解和操作变得更加复杂。在某些情况下，可能需要考虑使用其他数据结构，如列表或自定义类，以简化操作。
        /// </summary>
        /// <remarks>
        /// 多维数组的抽象Demo：一个小区里面有多少栋楼，每栋楼有多少层，每层有多少户人家，每家有多少人---这就是一个多维数组的抽象
        /// </remarks>
        public override void Open()
        {
            // 创建一个3x4的二维数组
            int[,] twoDimensionalArray = new int[3, 4];

            // 初始化数组
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    twoDimensionalArray[i, j] = i * j;
                }
            }

            // 打印数组
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    Console.Write(twoDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 创建一个3x4x2的三维数组
            int[,,] threeDimensionalArray = new int[3, 4, 2];

            // 初始化数组
            for (int i = 0; i < threeDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < threeDimensionalArray.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDimensionalArray.GetLength(2); k++)
                    {
                        threeDimensionalArray[i, j, k] = i * j * k;
                    }
                }
            }

            // 打印数组 (这将是一个复杂的操作，通常需要递归或循环遍历每个维度)
        }
    }
}
