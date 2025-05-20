namespace oop.demo;

/// <summary>
/// 車子的類別
/// </summary>
public class Car
{
    /// <summary>
    /// 設定車子體積參數事件範例：
    /// </summary>
    /// <param name="length">長度</param>
    /// <param name="width">寛度</param>
    /// <param name="height">高度</param>
    /// 不回傳值(事件Event)：void寫法
    public void SetCarData(int length, int width, int height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
    /// 回傳值(方法 Mehtod)
    public int GetCarVolume()
    {
        //體積=長度 x 寛度 x 高度 
        int int_volume = Length * Width * Height;
        return int_volume;
    }

    /// <summary>
    /// 廠牌名稱
    /// </summary>
    public string BrandName { get; set; } = "";
    /// <summary>
    /// 型號
    /// </summary>
    public string ModelName { get; set; } = "";
    /// <summary>
    /// 車重(噸)
    /// </summary>
    public int Weight { get; set; }
    /// <summary>
    /// 顏色
    /// </summary>
    public enColors Colors { get; set; } = enColors.Red;
    /// <summary>
    /// 長度(M)
    /// </summary>
    public int Length { get; set; }
    /// <summary>
    /// 寛度(M)
    /// </summary>
    public int Width { get; set; }
    /// <summary>
    /// 高度(M)
    /// </summary>
    public int Height { get; set; }
}
