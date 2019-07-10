using System;

namespace _05_枚举和int以及string之间的转换
{

    // 声明一个QQState枚举，存储QQ状态
    public enum QQState
    {
        OnLine = 1,
        OffLine,
        Leave,
        Busy,
        QMe
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强转为int类型
            // 声明使用QQState枚举类型
            //QQState qqstate = QQState.OnLine;

            //// 枚举类型默认可以跟int类型互相转换，可以与int类型兼容  可以通过强制类型转换  从默认从0开始
            //int n = (int)qqstate;
            //Console.WriteLine(n);   // 0
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadKey();
            #endregion

            #region 将int类型强转为枚举类型 转换不了，输原来的数字

            //int n1 = 3;
            //int n2 = 8;
            //QQState qqState = (QQState)n1;
            //Console.WriteLine(qqState);
            //Console.WriteLine((QQState)n2);   // 转换不了，输出原来数字8
            //Console.ReadKey();


            #endregion

            #region 将枚举类型转换为字符串类型
            // 所有的类型都能转换程string类型，调用ToString()方法

            //int n1 = 10;
            //string s = n1.ToString();
            //Console.WriteLine(s);
            //Console.WriteLine(3.14.ToString());
            //Console.WriteLine(5000m.ToString());
            //Console.ReadLine();

            //QQState state = QQState.OnLine;
            //string sState = state.ToString();
            //Console.WriteLine(sState);
            //Console.ReadKey();
            #endregion

            #region 将字符串转换为枚举类型 

            ///*
            // *  与字符串不兼容，不能进行强转
            // *  int转string: Convert.ToInt32()、int.Parse()、int.TryParse()
            // *  字符串转枚举：Enum.Parse()
            // *  将用Parse()方法的目的就是为了帮助我们将字符串转换为对应的枚举类型
            // *  参数：Parse(枚举类型，字符串）
            // *  QQState qqState = (QQState)Enum.Parse(typeof(QQState),s);
            // *  
            // */

            //string s = "0";
            //// 将s 转换为枚举类型
            //QQState qqState = (QQState)Enum.Parse(typeof(QQState),s);
            //Console.WriteLine(qqState);
            //Console.ReadKey();



            #endregion

            #region 枚举练习   提示用户选择一个在线状态，接收，转换为枚举类型，打印再控制台

            //// 提示用户选择一个在线状态，接收，转换为枚举类型，打印再控制台

            //Console.WriteLine("请选择您的qq在线状态 1--OnLine 2--OffLine 3--Leave 4--Busy 5--QMe");
            //string input = Console.ReadLine();

            //switch (input)
            //{
            //    case "1":
            //        QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine("您选择的在线状态是{0}", s1);
            //        break;
            //    case "2":
            //        QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine("您选择的在线状态是{0}", s2);
            //        break;
            //    case "3":
            //        QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine("您选择的在线状态是{0}", s3);
            //        break;
            //    case "4":
            //        QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine("您选择的在线状态是{0}", s4);
            //        break;
            //    case "5":
            //        QQState s5 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine("您选择的在线状态是{0}", s5);
            //        break;
            //}

            //Console.ReadKey();

            #endregion

            #region 提示用户选择一个在线状态，接收，转换为枚举类型，打印再控制台  重复输入，合理判断
            //// 提示用户选择一个在线状态，接收，转换为枚举类型，打印再控制台

            //while (true)
            //{
            //    Console.WriteLine("请选择您的qq在线状态（输入end/End结束）1--OnLine 2--OffLine 3--Leave 4--Busy 5--QMe  ");
            //    string input = Console.ReadLine();
            //    if (input == "end" || input == "End")
            //    {
            //        Console.WriteLine("选择结束，跳出程序");
            //        break;
            //    }
            //    else
            //    {
            //        try
            //        {
            //            int num = Convert.ToInt32(input);
            //            if (num <= 5 && num >= 1)
            //            {
            //                QQState state = (QQState)Enum.Parse(typeof(QQState), input);
            //                Console.WriteLine("您选择的在线状态是{0}", state);
            //            }
            //            else
            //            {
            //                Console.WriteLine("您输入的状态超出范围，请重新输入");
            //            }
            //        }
            //        catch
            //        {
            //            Console.WriteLine("您输入的状态选择不是1-5之间的数字，请重新输入");
            //        }
            //    }

            //}

            //Console.ReadKey(); 
            #endregion
        }
    }
}
