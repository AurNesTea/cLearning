namespace oop.demo;

/// <summary>
/// 步驟類別
/// </summary>
public class Job
{
    /// <summary>
    /// 步驟
    /// </summary>
    public int JobStep { get; set; } = 0;
    /// <summary>
    /// 步驟名稱
    /// </summary>
    public string JobName { get; set; } = "";
    /// <summary>
    /// 步驟執行時間(單位:秒)
    /// </summary>
    public int JobDelay { get; set; } = 0;
    /// <summary>
    /// 同步累計時間(單位:秒)
    /// </summary>
    public int TotalsSync { get; set; } = 0;
    /// <summary>
    /// 非同步累計時間(單位:秒)
    /// </summary>
    public int TotalsAsync { get; set; } = 0;
}