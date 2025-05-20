namespace oop.demo;

/// <summary>
/// 第二種繼承情形：不繼承父親的現金情形
/// </summary>
public class Child2 : Daddy
{
    /// <summary>
    /// 第二種不繼承情形建構子
    /// </summary>
    public Child2()
    {
        //兒子總財產初始值
        Money = 0;
        //兒子每月工作的薪水
        Salary = 20000;
        Console.WriteLine($"兒子2總財產初始值：{Money}");
    }

    /// <summary>
    /// 第二種不繼承情形建構子
    /// </summary>
    /// <param name="money">兒子總財產初始值</param>
    public Child2(int money)
    {
        //兒子總財產初始值
        Money = money;
        //兒子每月工作的薪水
        Salary = 20000;
        Console.WriteLine($"兒子2總財產初始值：{Money}");
    }

    /// <summary>
    /// 領薪水
    /// </summary>
    /// <param name="month">工作月份</param>
    /// sealed override(不允許其子階覆寫):在 GetPaid 事件前加上 sealed override 關鍵字，不再允許其子階覆寫
    public sealed override void GetPaid(int month)
    {
        //兒子總財產加上自己工作的薪資
        Money += (Salary * month);
        Console.WriteLine($"兒子總財產加上工作 {month} 月, 每月薪資為 {Salary}  = {(Salary * month)}");
    }
}