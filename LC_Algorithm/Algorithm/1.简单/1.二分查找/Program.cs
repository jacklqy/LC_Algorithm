using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._1.二分查找
{
    /// <summary>
    /// 听题：给定一个 n 个元素有序的（升序）整型数组 nums 和一个目标值 target  ，写一个函数搜索 nums 中的 target，如果目标值存在返回下标，否则返回 -1。
    /// 示例：
    /// 输入: nums = [-1,0,3,5,9,12], target = 9
    /// 输出: 4
    /// 解释: 9 出现在 nums 中并且下标为 4
    /// </summary>
    public class Program : OpentAlgorithm
    {
        public override void Open()
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12, 18 };
            var target = 9;

            //1.顺序查找--耗时耗空间，时间复杂度和空间复杂度都占有，不推荐使用。
            var v1 = SequenceSearch(nums, target);

            //2.二分查找(递归)
            int left = 0;
            int right = nums.Length - 1;
            var v2 = HalfSearch(nums, target, left, right);

            //3.二分查找(非递归)
            var v3 = BinarySearch(nums, target);
        }

        /// <summary>
        /// 1、顺序查找
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private int SequenceSearch(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 2.二分查找(递归)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private int HalfSearch(int[] nums, int target, int left, int right)
        {
            // 如果左指针大于右指针，说明在给定区间内未找到目标值，返回 -1
            if (left > right)
                return -1;

            // 计算中间位置
            int mid = left + (right - left) / 2;

            // 如果中间位置的元素等于目标值，返回中间位置的索引
            if (nums[mid] == target)
            {
                return mid;
            }
            // 如果中间位置的元素大于目标值，在左侧区间继续递归查找
            else if (nums[mid] > target)
            {
                return HalfSearch(nums, target, left, right - 1);
            }
            // 如果中间位置的元素小于目标值，在右侧区间继续递归查找
            else
            {
                return HalfSearch(nums, target, mid + 1, right);
            }
        }

        /// <summary>
        /// 3、二分查找(非递归)
        /// </summary>
        /// <remarks>
        /// 复杂度分析：
        /// 时间复杂度：二分查找的时间复杂度是 O(log⁡ N)，这里 N 是输入数组的长度；
        /// 空间复杂度：由于二分查找算法在执行的过程中只使用到常数个临时变量，因此空间复杂度是 O(1)。
        /// </remarks>
        private int BinarySearch(int[] nums, int target)
        {
            // 初始化左指针，指向数组的第一个元素
            int left = 0;
            // 初始化右指针，指向数组的最后一个元素
            int right = nums.Length - 1;
            int mid;
            // 当左指针小于等于右指针时，循环进行二分查找
            while (left <= right)
            {
                // 计算中间位置
                mid = (right + left) / 2;

                // 如果中间位置的元素等于目标值，直接返回中间位置的索引
                if (nums[mid] == target)
                {
                    return mid;
                }
                // 如果中间位置的元素大于目标值，说明目标值在左侧区间，更新右指针
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                // 如果中间位置的元素小于目标值，说明目标值在右侧区间，更新左指针
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
