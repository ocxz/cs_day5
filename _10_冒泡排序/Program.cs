using System;

namespace _10_冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 排序之冒泡排序 将一个int数组按照从小到大排序

            ///**
            // *   题目：将一个int数组按照从小到大排序
            // *   原理：逐个将数组中的元素与后面元素判断，符合判断则交换
            // *   要点：需要双重循环来完成
            // *   第一趟：数组中的最大值排到最后面         交换次数：需要比较数组长度减一
            // *   第二趟：剩余数组中的最大值排到倒数第二   交换次数：需要比较数组长度减二
            // *   第三趟：剩余数组中的最大值排到倒数第三   交换次数：需要比较数组长度减三
            // *   
            // *   第一重循环：将数组的值挨个取出   循环次数：Length-1
            // *   第二重循环：将取出的值与后面未排序的值做交换   Length-1-i
            // * 
            // */

            //int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //Console.Write("排序前的数组：");
            //for (int i = 0; i < nums.Length; i++)   // 按个取出并打印
            //{
            //    Console.Write("{0} ", nums[i]);
            //}

            //Console.Write("\n排序后的数组：");

            //for (int i = 0; i < nums.Length - 1; i++)   // 将数组中的元素按个取出  控制比较趟数
            //{
            //    for (int j = i + 1; j < nums.Length; j++)   // 将数组当前元素，与数组前面未排序的元素按个比较，交换
            //    {
            //        if (nums[i] > nums[j])
            //        {
            //            int temp = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = temp;
            //        }
            //    }
            //    Console.Write("{0} ", nums[i]);     // 已经排好序的，正在处理的剩余数组的最小值
            //}

            //Console.Write("{0} ", nums[nums.Length-1]);
            //Console.ReadKey();

            #endregion

            #region 利用Array对象中的Sort()方法进行排序

            int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Console.Write("排序前的数组：");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Array.Sort(nums);   // 只能对数组做升序排序
            Array.Reverse(nums);

            Console.Write("\n排序后的数组：");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} ", nums[i]);
            }

            Console.ReadKey();

            #endregion

        }
    }
}
