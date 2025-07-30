namespace oop.demo;

/// <summary>
/// 水果紙箱類別
/// </summary>
public class FruitCarton : BaseClass, ICarton
{
    /// <summary>
    /// 長度
    /// </summary>
    public int Length { get; set; } = 0;
    /// <summary>
    /// 寛度
    /// </summary>
    public int Width { get; set; } = 0;
    /// <summary>
    /// 高度
    /// </summary>
    public int Height { get; set; } = 0;
    /// <summary>
    /// 重量
    /// </summary>
    public int Weight { get; set; } = 0;
    /// <summary>
    /// 紙箱資訊
    /// </summary>
    public string CartonInfo
    {
        get
        {
            string str_message = "紙箱資訊：";
            str_message += $"長度：{Length} ";
            str_message += $"寛度：{Width} ";
            str_message += $"高度：{Height} ";
            str_message += $"空重：{Weight} ";
            str_message += $"體積：{Length * Width * Height} ";
            return str_message;
        }
    }
    /// <summary>
    /// 打包
    /// </summary>
    public void Package()
    {
        Length = 40;
        Width = 60;
        Height = 50;
        Weight = 20;
    }
    /// <summary>
    /// 打包
    /// </summary>
    /// <param name="length">長度</param>
    /// <param name="width">寛度</param>
    /// <param name="height">高度</param>
    /// <param name="weight">重量</param>
    public void Package(int length, int width, int height, int weight)
    {
        Length = length;
        Width = width;
        Height = height;
        Weight = weight;
    }
}