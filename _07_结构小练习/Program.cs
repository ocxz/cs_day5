using System;

namespace _07_结构小练习
{

    // 声明一个MyColor的结构体
    public struct MyColor
    {
        public int _red;          // 字段
        public int _green;
        public int _blue;
    }

    // 声明一个Gender枚举类型，用来存储性别
    public enum Gender
    {
        男,
        女
    }

    // 声明一个Person结构体，利用enum枚举类型存储性别
    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
        public int _grade;
    }

    class Program
    {
        static void Main(string[] args)
        {


            #region struct小练习  定义一个结构叫MyColor，有三个成员，分别为int类型的red、green、blue
            ///**
            // *   定义一个结构叫MyColor，有三个成员，分别为int类型的red、green、blue
            // *   声明一个MyColor类型变量，对其成员赋值，使MyColor可以表示为一个红色
            // * 
            // */

            //// 声明一个MyColor类型的变量
            //MyColor myColor;
            //myColor._red = 255;
            //myColor._green = 0;
            //myColor._blue = 0;
            #endregion

            #region 声明使用Person结构体存储个人信息，利用enum枚举类型存储性别  存储并取出个人信息

            //Person zsPerson;
            //zsPerson._name = "张三";
            //zsPerson._age = 18;
            //zsPerson._gender = Gender.男;
            //zsPerson._grade = 3;

            //Person xlPerson;
            //xlPerson._name = "小兰";
            //xlPerson._age = 16;
            //xlPerson._gender = Gender.女;
            //xlPerson._grade = 2;

            //Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，就读于{3}年级。", zsPerson._name, zsPerson._age, zsPerson._gender, zsPerson._grade);
            //Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，就读于{3}年级。", xlPerson._name, xlPerson._age, xlPerson._gender, xlPerson._grade);

            //Console.ReadKey();


            #endregion
        }
    }
}
