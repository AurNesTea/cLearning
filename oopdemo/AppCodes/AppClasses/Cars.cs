namespace oop.demo;

/// <summary>
/// 車子的類別
/// </summary>
public class Car : BaseClass
{
    /// <summary>
    /// 建構子
    /// </summary>
    public Car()
    {
        ComponentInit();
        BrandName = "Benz";
        ModelName = "C300";
    }
    /// <summary>
    /// 建構子
    /// </summary>
    /// <param name="brandName">廠牌名稱</param>
    /// <param name="modelName">型號</param>
    public Car(string brandName, string modelName)
    {
        ComponentInit();
        BrandName = brandName;
        ModelName = modelName;
    }

    /// <summary>
    /// 建構子初始化程式
    /// </summary>
    private void ComponentInit()
    {
        Color = enColors.Red;
    }

    #region 屬性宣告
    /// <summary>
    /// 私有屬性範例
    /// </summary>
    private string CarData1 { get; set; } = "";

    /// <summary>
    /// 保護屬性範例
    /// </summary>
    protected string CarData2 { get; set; } = "";

    /// <summary>
    /// 廠牌名稱
    /// </summary>
    public string BrandName { get; set; } = "";
    /// <summary>
    /// 車子的型號
    /// </summary>
    public string ModelName { get; set; } = "";
    /// <summary>
    /// 顏色
    /// </summary>
    public enColors Color { get; set; } = enColors.Red;
    /// <summary>
    /// 車重(噸)
    /// </summary>
    public string Weight { get; set; }
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

    /// <summary>
    /// 設定車子資訊
    /// </summary>
    /// <param name="carNo">車牌號碼</param>
    /// <param name="brandName">廠牌名稱</param>
    /// <param name="modelNo">車子的型號</param>
    #endregion

    /// <summary>
    /// 設定車子體積參數事件範例：
    /// </summary>
    /// <param name="length">長度</param>
    /// <param name="width">寛度</param>
    /// <param name="height">高度</param>
    public void SetCarData(int length, int width, int height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public int GetCarValume()
    {
        //體積=長度 x 寛度 x 高度
        int int_volume = Length * Width * Height;
        return int_volume;
    }
}
