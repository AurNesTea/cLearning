namespace oop.demo;

/// <summary>
/// 輕型機車的類別
/// </summary>
public class Lite : Moto
{
    /// <summary>
    /// 輕型機車編號
    /// </summary>
    public string LiteNo { get; set; } = "";
    /// <summary>
    /// 輕型機車名稱
    /// </summary>
    public string LiteName { get; set; } = "";
    /// <summary>
    /// 輕型機車建構子
    /// </summary>
    public Lite()
    {

    }
    /// <summary>
    /// 輕型機車建構子
    /// </summary>
    /// <param name="brandName">廠牌名稱</param>
    /// <param name="modelName">型號</param>
    /// <param name="color">顏色</param>
    public Lite(string brandName, string modelName, enColors color)
    {
        BrandName = brandName;
        ModelName = modelName;
        Color = color;
    }
}