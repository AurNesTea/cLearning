namespace oop.demo;

/// <summary>
/// 父親的類別
/// </summary>
public class Daddy : BaseClass
{
    /// <summary>
    /// 銀行存款金額
    /// </summary>
    public int BankSavings { get; set; }

    /// <summary>
    /// 父親的現金
    /// </summary>
    public int Cash { get; set; }

    /// <summary>
    /// 每月工作的薪水
    /// </summary>
    public int Salary { get; set; }

    /// <summary>
    /// 目前的財產總額
    /// </summary>
    public int Money { get; set; }

    /// <summary>
    /// 父親的建構子
    /// </summary>
    public Daddy()
    {
        //目前的財產總額
        Money = 0;
        //父親的銀行存款總額
        BankSavings = 20000;
        //父親的現金總額
        Cash = 50000;
        //父親每月工作的薪水(身故，不發薪)
        Salary = 0;
    }

    /// <summary>
    /// 領薪水
    /// </summary>
    /// <param name="month">工作月份</param>
    public virtual void GetPaid(int month)
    {
        //父親的財產總額 = 父親的銀行存款 + 父親的現金
        int int_amount = (BankSavings + Cash);
        //加入父親的財產
        Money += int_amount;
        Console.WriteLine($"繼承父親的財產：{int_amount}");
    }
    
    /// <summary>
    /// 顯示目前財產現狀
    /// </summary>
    /// <returns></returns>
    public string Information()
    {
        return $"目前的財產金額為：{Money}";
    }
}