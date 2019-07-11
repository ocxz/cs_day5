using System;

namespace _12_方法练习
{
    class Program
    {
        static void Main(string[] args)
        {

            // 调用方法 求两个整数最大值
            int max = Program.GetMaxValue(5, 20);
            Console.WriteLine(max);
            Console.ReadKey();
        }

        #region 写一个方法，求两个整数之间的最大值

        /// <summary>
        /// 计算两个整数之间的最大值，并且返回该最大值
        /// </summary>
        /// <param name="num1">第一个整数</param>
        /// <param name="num2">第二个整数</param>
        /// <returns>返回的最大值</returns>
        public static int GetMaxValue(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        #endregion
    }
}
