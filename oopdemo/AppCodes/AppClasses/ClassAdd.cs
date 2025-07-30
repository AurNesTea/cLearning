namespace oop.demo;

/// <summary>
/// 加法的類別
/// </summary>
public class ClassAdd : BaseClass
{
    /// <summary>
    /// 加法-傳入一數字後得到該數字加上該數字的結果
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public int Add(int i)
    {
        return i + i;
    }
    /// <summary>
    /// 加法-傳入兩整數數字後得到兩整數數字相加的結果
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <returns></returns>
    public int Add(int i, int j)
    {
        return i + j;
    }
    /// <summary>
    /// 加法-傳入兩雙精確度數字後得到兩雙精確度數字相加的結果
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <returns></returns>
    public double Add(double i, double j)
    {
        return i + j;
    }
}