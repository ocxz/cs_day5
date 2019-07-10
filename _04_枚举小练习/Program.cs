using System;

namespace _04_枚举小练习
{
    // 声明一个季节Seasons的枚举
    public enum Seasons
    {
        春,
        夏,
        秋,
        冬
    }

    // 声明一个QQ状态枚举 QQStates
    public enum QQStates
    {
        OnLine,
        OffLine,
        Leave,
        Busy,
        QMe
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 使用Season枚举
            Seasons season = Seasons.春;
            // 使用QQState枚举
            QQStates qqState = QQStates.OnLine;
        }
    }
}
