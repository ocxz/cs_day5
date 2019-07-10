using System;

namespace _06_结构
{
    class Program
    {
        // 声明一个性别枚举Gender
        public enum Gender
        {
            男,
            女,
        }


        // 声明一个个人信息Person结构体
        public struct Person
        {
            public string _name;     // 字段
            public int _age;
            public Gender _gender;
            public int _grade;
        }


        static void Main(string[] args)
        {
            #region 结构的学习和使用 利用结构类型存储个人信息
            ///**
            // *   xx大学管理系统
            // *   姓名 性别 年龄 系别 年级
            // *   帮助一次性声明多个变量
            // *   语法：[public] struct 结构名 { 成员们 }
            // * 
            // */

            ////string zsName = "张三";
            ////int zsAge = 21;
            ////char zsGender = '男';
            ////int zsGrade = 3;

            //// 结构体Person的使用
            //Person zsPerson;     // 声明一个zsPerson结构变量
            //zsPerson._name = "张三";
            //zsPerson._age = 21;
            //zsPerson._gender = Gender.男;
            //zsPerson._grade = 3;

            //Person lsPerson;    // 声明一个lsPerson结构变量
            //lsPerson._name = "李四";
            //lsPerson._age = 20;
            //lsPerson._gender = Gender.女;
            //lsPerson._grade = 4;

            //Console.WriteLine(zsPerson._name);
            //Console.WriteLine(lsPerson._name);

            //Console.ReadKey(); 
            #endregion

        }
    }
}
