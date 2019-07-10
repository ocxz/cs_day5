using System;

namespace _02_常量
{
    class Program
    {
        static void Main(string[] args)
        {
            // 变量  可以改变
            int age = 18;
            age = 20;

            // 常量 需要提前声明赋值，不可以改变
            const int COUNT = 100;
            //COUNT = 200;    // 报错 不能重新赋值
        }
    }
}
