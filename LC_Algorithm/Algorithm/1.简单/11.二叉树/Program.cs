using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1.简单._11.二叉树
{
    public class Program : OpentAlgorithm
    {
        public override void Open()
        {
            // 构建二叉树
            TreeNode root = new TreeNode { Value = 1 };
            root.Left = new TreeNode { Value = 2 };
            root.Right = new TreeNode { Value = 3 };
            root.Left.Left = new TreeNode { Value = 4 };
            root.Left.Right = new TreeNode { Value = 5 };
            root.Right.Left = new TreeNode { Value = 6 };
            root.Right.Right = new TreeNode { Value = 7 };


            Console.WriteLine("先序遍历:");
            PreOrderTraversal(root);

            Console.WriteLine("\n中序遍历:");
            InOrderTraversal(root);

            Console.WriteLine("\n后序遍历:");
            PostOrderTraversal(root);

            Console.WriteLine("\n二叉树的最小深度:");
            var v1 = MinDepth(root);
            Console.WriteLine(v1);

            Console.WriteLine("\n二叉树的最大深度:");
            var v2 = MaxDepth(root);
            Console.WriteLine(v2);

            Console.WriteLine("\n二叉树路径总和:");
            var solution = new Solution();
            var v3 = solution.PathSum(root, 7);

            Console.WriteLine("\n二叉树求根到叶子节点数字之和:");
            Solution2 solution2 = new Solution2();
            int result = solution2.PathSum(root, 7); // 假设我们要找的和为2
            Console.WriteLine(result); // 输出结果

            Console.WriteLine("\n二叉树中的最大路径和:");

            Console.WriteLine("\n对称二叉树:");

            Console.WriteLine("\n翻转二叉树:");

            Console.WriteLine("\n平衡二叉树:");

            Console.WriteLine("\n二叉树的右视图:");

            Console.WriteLine("\n完全二叉树的节点个数:");
        }

        /// <summary>
        /// 递归先序遍历
        /// </summary>
        /// <param name="node"></param>
        private void PreOrderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            Console.WriteLine(node.Value); // 访问当前节点
            PreOrderTraversal(node.Left);  // 遍历左子树
            PreOrderTraversal(node.Right); // 遍历右子树
        }

        /// <summary>
        /// 递归中序遍历
        /// </summary>
        /// <param name="node"></param>
        private void InOrderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            InOrderTraversal(node.Left);   // 遍历左子树
            Console.WriteLine(node.Value); // 访问当前节点
            InOrderTraversal(node.Right);  // 遍历右子树
        }

        /// <summary>
        /// 递归后序遍历
        /// </summary>
        /// <param name="node"></param>
        private void PostOrderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            PostOrderTraversal(node.Left);  // 遍历左子树
            PostOrderTraversal(node.Right); // 遍历右子树
            Console.WriteLine(node.Value);  // 访问当前节点
        }

        /// <summary>
        /// 二叉树的最小深度
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftDepth = MinDepth(root.Left);
            int rightDepth = MinDepth(root.Right);

            if (leftDepth == 0 && rightDepth == 0)
            {
                return 1;
            }
            else if (leftDepth == 0)
            {
                return rightDepth + 1;
            }
            else if (rightDepth == 0)
            {
                return leftDepth + 1;
            }
            else
            {
                return Math.Min(leftDepth, rightDepth) + 1;
            }
        }

        /// <summary>
        /// 二叉树的最大深度
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftDepth = MaxDepth(root.Left);
            int rightDepth = MaxDepth(root.Right);
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }

    /// <summary>
    /// PathSum方法使用深度优先搜索（DFS）遍历二叉树，寻找和为指定值的路径。在遍历过程中，我们动态构建路径并计算剩余需要匹配的和，如果到达叶子节点且剩余和为0，则将当前路径添加到结果列表中。最后，代码返回所有满足条件的路径。
    /// </summary>
    public class Solution
    {
        private int targetSum;
        private IList<IList<int>> result = new List<IList<int>>();
        private IList<int> path = new List<int>();

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return result;
            }

            targetSum = sum;
            Traverse(root);
            return result;
        }

        private void Traverse(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            path.Add(node.Value); // 前往左子树
            targetSum -= node.Value; // 减去当前节点值
            if (targetSum == 0 && node.Left == null && node.Right == null)
            {
                result.Add(new List<int>(path));
            }
            Traverse(node.Left);
            Traverse(node.Right);
            targetSum += node.Value; // 回溯，恢复targetSum
            path.RemoveAt(path.Count - 1); // 回溯，移除当前节点
        }
    }

    /// <summary>
    /// PathSum方法递归地计算从根节点到叶子节点路径上数字之和为指定值的路径数量。在使用时，我们需要创建一个二叉树，并调用PathSum方法，传入树的根节点和需要的路径数字和。
    /// </summary>
    public class Solution2
    {
        public int PathSum(TreeNode root, int sum)
        {
            if (root == null)
                return 0;

            // 递归计算左子树的路径和
            int leftPathSum = PathSum(root.Left, sum);
            // 递归计算右子树的路径和
            int rightPathSum = PathSum(root.Right, sum);
            // 当前节点到叶子节点的路径和
            int currentPathSum = root.Value == sum ? 1 : 0;
            // 加上根节点到叶子节点的路径和
            currentPathSum += leftPathSum + rightPathSum;

            return currentPathSum;
        }
    }

    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }
}
