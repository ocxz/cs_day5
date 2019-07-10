using System;

namespace _09_数组的五个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1：从一个整数数组中取出最大的整数、最小的整数、总和、平均值

            ///*
            // *   声明一个int类型的数组，并且随意的赋初值
            // *   声明变量max存最大值、min存最小值、sum存总和
            // *   给max、min赋初值有两个方法：
            // *   1、将数组中的某个值赋给max、min，确保max、min的值时数组中有的
            // *   2、给max赋int所能表示的最小值MinValue,给min赋int所能表示的最大值MaxValue 确保比较时max、min能取到数组中的元素值
            // * 
            // */

            //// 声明一个int类型的数组，并赋初值
            //int[] nums = { 1, 3, 2, 8, 6, 9, 4, 5 };

            ///**
            // *   给max、min赋值的两个方法
            // *   方法一：将数组中的某个值赋给max、min，确保max、min的值时数组中有的
            // *   方法二：给max赋int所能表示的最大值MaxValue,给min赋int所能表示的最小值MinValue  确保比较时max、min能取到数组中的元素值
            // *   
            // */

            ////// 方法一给max、min赋值
            ////int max = nums[0];   // 声明max变量存最大值
            ////int min = nums[0];   // 声明min变量存最小值

            //// 方法二给max、min赋值
            //int max = int.MinValue;   // 给最大值赋int最小值，确保max能取到数组中的元素值
            //int min = int.MaxValue;   // 给最小值赋int最大值，确保min能取到数组中的元素值
            //int sum = 0;   // 声明一个变量用来存和

            //Console.Write("数组：");
            //for (int i = 0; i < nums.Length; i++)   // 循环数组中每个变量，跟最大值、最小值比较，加入总和中
            //{
            //    /**
            //     *    关于循环中nums[i]的两种理解方式
            //     *    1、代表数组当前循环到的元素
            //     *    2、代表数组中的每一个元素
            //     * 
            //     */

            //    max = max > nums[i] ? max : nums[i];
            //    min = min < nums[i] ? min : nums[i];
            //    sum += nums[i];
            //    Console.Write("{0} ", nums[i]);
            //}

            //Console.WriteLine("\n的最大值为{0}，最小值为{1}，总和为{2}，平均值为{3:0.00}", max, min, sum, sum * 1.0 / nums.Length);
            //Console.ReadKey();


            #endregion

            #region 练习2：数组里都是人的名字(老杨，老苏，老邹，老虎，老牛，老蒋，老王，老马）最终变成：老杨|老苏|老邹...

            //// 数组里都是人的名字，分割成：老杨|老苏|老邹...(老杨，老苏，老邹，老虎，老牛，老蒋，老王，老马）

            //string[] names = { "老杨", "老苏", "老邹", "老虎", "老牛", "老蒋", "老王", "老马" };

            //for (int i = 0; i < names.Length-1; i++)
            //{
            //    Console.Write("{0}|", names[i]);
            //}

            //Console.Write(names[names.Length - 1]);
            //Console.ReadKey();

            #endregion

            #region 练习2：(方法二 字符串累加）数组里都是人的名字(老杨，老苏，老邹，老虎，老牛，老蒋，老王，老马）最终变成：老杨|老苏|老邹...

            //// 数组里都是人的名字，分割成：老杨|老苏|老邹...(老杨，老苏，老邹，老虎，老牛，老蒋，老王，老马）

            //string[] names = { "老杨", "老苏", "老邹", "老虎", "老牛", "老蒋", "老王", "老马" };  // 声明名字数组并赋初值
            //string str = "";   // 声明一个字符串，用来累加

            //Console.Write("名字数组：");
            //for (int i = 0; i < names.Length - 1; i++)   // 循环到倒数第二个名字，因为最后一个名字不用加|，需要额外处理
            //{
            //    str += names[i] + "|";     // 将当前名字+|追加到str中
            //    Console.Write("{0} ", names[i]);
            //}
            //Console.Write(names[names.Length - 1]);
            //str += names[names.Length - 1];

            //Console.Write("\n转换后的结果为：");
            //Console.WriteLine(str);
            //Console.ReadKey();

            #endregion

            #region 练习3：一个整数数组做处理，元素为正数：值加一；元素为负数：值减一；元素为0：值不变

            //int[] nums = { 1, -2, 3, -4, 5, 6, 0 };

            //Console.Write("数组变化后的值");

            //// 思路：通过循环，取出数组中所有元素，对每个元素进行判断处理
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > 0)   // 元素值为正数
            //    {
            //        nums[i] += 1;
            //    }else if (nums[i] == 0)   // 元素值为0
            //    {
            //        nums[i] = nums[i];
            //    }
            //    else    // 元素值为负数
            //    {
            //        nums[i] -= 1; 
            //    }
            //    Console.Write("{0} ", nums[i]);
            //}

            //Console.ReadKey();

            #endregion

            #region 练习5：将字符串数组中的元素进行反转 如：{"我","是","好人"}  ---> {"好人","是","我"}

            ///** 
            // *    1、字符串数组反转：不管有奇数个元素还是偶数个元素，反转次数都是数组长度/2
            // *    2、进行反转的两个元素下标之和为数组长度减一
            // *    也就是说：让下标为i的元素与下标为数组长度减一再减i的元素进行交换
            // *    3、奇数个元素数组：中间一个不会参与反转（循环比较一半就行，不会循环到中间的那个数）
            // *    4、偶数个元素数组：进行彻底交换
            // *    
            // */

            //string[] strs = { "我", "是", "好人" };

            //for (int i = 0; i < strs.Length/2; i++)
            //{
            //    string temp = strs[i];     // 声明一个临时变量，用来存储str[i]
            //    strs[i] = strs[strs.Length - 1 - i];
            //    strs[strs.Length - 1 - i] = temp;
            //}

            //Console.Write("新数组为：");
            //for (int i = 0; i < strs.Length; i++)
            //{
            //    Console.Write("{0} ", strs[i]);
            //}
            //Console.ReadKey();


            #endregion
        }
    }
}
