using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._12.回溯算法
{
    public class Program : OpentAlgorithm
    {
        /// <summary>
        /// FindPath函数使用回溯算法来遍历2D数组中的每个元素，尝试找到一条和为targetSum的路径。如果找到这样的路径，函数返回true，否则返回false。这个例子中使用了深度优先搜索的方法来遍历路径
        /// </summary>
        public override void Open()
        {
            int[,] matrix =
            {
                {1, 3, 5, 9},
                {8, 1, 3, 4},
                {5, 0, 6, 1},
                {8, 8, 4, 0}
            };
            int targetSum = 10;
            bool found = FindPath(matrix, targetSum, 0, 0);
            if (found)
            {
                Console.WriteLine("Path found.");
            }
            else
            {
                Console.WriteLine("No path found.");
            }
        }

        private bool FindPath(int[,] matrix, int targetSum, int currentSum, int row)
        {
            if (currentSum > targetSum) return false;
            if (currentSum == targetSum) return true;

            int columns = matrix.GetLength(1);
            bool found = false;

            for (int col = 0; col < columns; col++)
            {
                if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < columns)
                {
                    currentSum += matrix[row, col];
                    if (!found)
                    {
                        if (row == matrix.GetLength(0) - 1)
                        {
                            found = FindPath(matrix, targetSum, currentSum, row + 1);
                        }
                        else
                        {
                            found = FindPath(matrix, targetSum, currentSum, row + 1);
                            if (!found)
                            {
                                found = FindPath(matrix, targetSum, currentSum, row);
                            }
                        }
                    }
                    currentSum -= matrix[row, col];
                }
            }

            return found;
        }
    }
}
