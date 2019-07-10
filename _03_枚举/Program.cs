using System;

namespace _03_枚举
{
    // 声明枚举 Gender
    public enum Gender
    {
        男,
        女
    }


    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  为什么要有枚举这个东西？
             *  xx 大学管理系统
             *  姓名 性别 年龄 系别 年龄
             *  
             *  性别：写死来，规范开发
             *  
             */

            char gender = '男';
            string s1 = "female";
            string ss1 = "爷们";

            // 枚举使用  变量类型 变量名 = 值;
            Gender gender2 = Gender.男;

            Console.WriteLine(gender2);
            Console.ReadKey();


        }
    }
}
