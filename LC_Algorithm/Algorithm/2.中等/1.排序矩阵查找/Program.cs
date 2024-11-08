using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._2.中等._1.排序矩阵查找
{
    /// <summary>
    /// 听题：给定M×N矩阵，每一行、每一列都按升序排列，请编写代码找出某元素。
    /// 示例：
    /// 现有矩阵 matrix 如下：
    /// {
    ///   [1,   4,  7, 11, 15],
    ///   [2,   5,  8, 12, 19],
    ///   [3,   6,  9, 16, 22],
    ///   [10, 13, 14, 17, 24],
    ///   [18, 21, 23, 26, 30]
    /// }
    /// 给定 target = 5，返回 true。
    /// 给定 target = 20，返回 false。
    /// </summary>
    public class Program : OpentAlgorithm
    {
        public override void Open()
        {
            var target = 5;
            var matrix = new int[][]
            {
                [1, 4, 7, 11, 15],
                [2, 5, 8, 12, 19],
                [3, 6, 9, 16, 22],
                [10, 13, 14, 17, 24],
                [18, 21, 23, 26, 30]
            };

            //1.直接查找
            var v1 = SearchMatrix(matrix, target);

            var v2 = BinarySearch(matrix, target);

            var v3 = ZSearchMatrix(matrix, target);
        }

        /// <summary>
        /// 1.直接查找
        /// </summary>
        /// <remarks>
        /// 思路与算法：
        /// 我们直接遍历整个矩阵 matrix，判断 target 是否出现即可。
        /// </remarks>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return false;
            }
            foreach (int[] row in matrix)
            {
                foreach (int element in row)
                {
                    if (element == target)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 2.二分查找
        /// </summary>
        /// <remarks>
        /// 思路与算法：
        /// 由于矩阵 matrix 中每一行的元素都是升序排列的，因此我们可以对每一行都使用一次二分查找，判断 target 是否在该行中，从而判断 target 是否出现。
        /// </remarks>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool BinarySearch(int[][] matrix, int target)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return false;
            }
            foreach (int[] row in matrix)
            {
                int index = Search(row, target);
                if (index >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        public int Search(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (high - low) / 2 + low;
                int num = nums[mid];
                if (num == target)
                {
                    return mid;
                }
                else if (num > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// 3.Z字形查找
        /// </summary>
        /// <remarks>
        /// 思路与算法：
        /// 我们可以从矩阵 matrix 的右上角 (0,n−1) 进行搜索。在每一步的搜索过程中，如果我们位于位置 (x,y)，那么我们希望在以 matrix 的左下角为左下角、以 (x,y) 为右上角的矩阵中进行搜索，即行的范围为 [x,m−1]，列的范围为 [0,y]：
        /// a.如果 matrix[x, y] = target，说明搜索完成；
        /// b.如果 matrix[x, y]>target，由于每一列的元素都是升序排列的，那么在当前的搜索矩阵中，所有位于第 y 列的元素都是严格大于 target 的，因此我们可以将它们全部忽略，即将 y 减少 1；
        /// c.如果 matrix[x, y]<target，由于每一行的元素都是升序排列的，那么在当前的搜索矩阵中，所有位于第 x 行的元素都是严格小于 target 的，因此我们可以将它们全部忽略，即将 x 增加 1。
        /// 在搜索的过程中，如果我们超出了矩阵的边界，那么说明矩阵中不存在 target。
        /// </remarks>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool ZSearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return false;
            }
            int m = matrix.Length, n = matrix[0].Length;
            int x = 0, y = n - 1;
            while (x < m && y >= 0)
            {
                if (matrix[x][y] == target)
                {
                    return true;
                }
                if (matrix[x][y] > target)
                {
                    --y;
                }
                else
                {
                    ++x;
                }
            }
            return false;
        }

    }
}
