using System;

namespace _08_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region int类型数组
            ///**
            // *  数组：用来声明存储多个相同类型的变量
            // *  格式：数组类型[] 数组名 = new 数组类型[数组长度]
            // *  举例：int[] nums = new int[10];
            // *  注意：声明时，已经给数组中所有元素赋初值了，int数组，赋初值为0
            // * 
            // */

            //int[] nums = new int[10];
            ////nums[0] = 1;
            ////nums[1] = 2;
            ////nums[2] = 3;
            ////nums[3] = 4;
            ////nums[4] = 5;
            ////nums[5] = 6;
            ////nums[6] = 7;
            ////nums[7] = 8;
            ////nums[8] = 9;
            ////nums[9] = 10;

            ////Console.WriteLine(nums);
            ////Console.ReadKey();

            //// 通过一个循环，给数组赋值
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //}

            //// 通过一个循环，给数组取值
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write("{0} ", nums[i]);
            //}

            //Console.ReadKey(); 
            #endregion

            #region string类型数组  初始化时，没有给数组元素开辟空间 初值为null

            //string[] strs = new string[10];

            #endregion

            #region bool类型数组  初始化时，给数组中所有元素开辟了空间，初值为false

            //bool[] bs = new bool[10];

            #endregion

            #region 数组的声明方式

            ///**
            // *   第一种：声明时确定数组类型和长度，不给定数组内容 如：string[] strs = new string[10];
            // *   第二种：声明数组时，直接给数组指定内容，内容放在花括号中 如：int[] numsTwo = { 1, 2, 3, 4, 5, 6 };
            // * 
            // */

            //// 声明数组时直接给数组指定内容
            //int[] numsTwo = { 1, 2, 3, 4, 5, 6 };

            ////不推荐使用的另外两种声明方式
            //int[] numsThree = new int[3] { 1, 2, 3 };
            //int[] numsFour = new int[] { 1, 2, 3 };

            #endregion

        }
    }
}
