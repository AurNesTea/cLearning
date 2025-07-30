namespace oop.demo;

/// <summary>
/// 紙箱介面
/// </summary>
public interface ICarton
{
    /// <summary>
    /// 長度
    /// </summary>
    int Length { get; set; }
    /// <summary>
    /// 寛度
    /// </summary>
    int Width { get; set; }
    /// <summary>
    /// 高度
    /// </summary>
    int Height { get; set; }
    /// <summary>
    /// 重量
    /// </summary>
    int Weight { get; set; }
    /// <summary>
    /// 紙箱資訊
    /// </summary>
    string CartonInfo { get; }
    /// <summary>
    /// 打包
    /// </summary>
    void Package();
    /// <summary>
    /// 打包
    /// </summary>
    /// <param name="length">長度</param>
    /// <param name="width">寛度</param>
    /// <param name="height">高度</param>
    /// <param name="weight">重量</param>
    void Package(int length, int width, int height, int weight);
}
