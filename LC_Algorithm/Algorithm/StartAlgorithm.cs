using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class StartAlgorithm
    {
        /// <summary>
        /// 执行入口
        /// </summary>
        public void Exe()
        {
            #region 简单

            #region 1、二分查找
            //OpentAlgorithm algorithm = new Algorithm._1.简单._2.二分查找.Program();
            //algorithm.Open();
            #endregion

            #region 11、二叉树
            //OpentAlgorithm algorithm = new Algorithm._1.简单._11.二叉树.Program();
            //algorithm.Open();
            #endregion

            #region 13、动态规划
            OpentAlgorithm algorithm = new Algorithm._1.简单._13.动态规划.Program();
            algorithm.Open();
            #endregion

            #endregion

            #region 中等

            #region 1、排序矩阵查找
            //OpentAlgorithm algorithm = new Algorithm._2.中等._1.排序矩阵查找.Program();
            //algorithm.Open();
            #endregion

            #endregion

            #region 困难

            #region 1、斐波那契数列
            //OpentAlgorithm algorithm = new Algorithm._3.困难._1.斐波那契数列.Program();
            //algorithm.Open(); 
            #endregion 

            #endregion
        }
    }
}
