using System;
using oop.deom;

namespace oop.demo;

/// <summary>
/// 引擎的類別
/// </summary>
public class Engine : Car
{
    /// <summary>
    /// 車號
    /// </summary>
    public string CarNo { get; set; } = "";
    /// <summary>
    /// 引擎編號
    /// </summary>
    public string EngineNo { get; set; } = "";
    /// <summary>
    /// 進氣量(cc)
    /// </summary>
    public int CC { get; set; } = 2000;
    /// <summary>
    /// 車子顏色
    /// </summary>
    public enColors Color { get; set; } = enColors.Red;

    /// <summary>
    /// 汽油類型
    /// </summary>
    public enOilType OilType { get; set; } = enOilType.Type92;
    /// <summary>
    /// 汽油的基本資訊
    /// </summary>
    public string BaseInfor
    {
        get
        {
            string str_color = Enum.GetName(typeof(enColors), Color) ?? "未知";  // ?? "未知": 如果抓不到 enum 名稱，就會預設變成 "未知"。
            string str_oil = "九二無鉛";
            if (OilType == enOilType.Type95) str_oil = "九五無鉛";
            if (OilType == enOilType.Type98) str_oil = "九八無鉛";
            return $"廠牌：{BrandName}, 型號：{ModelName}, CC數：{CC}, 顏色：{str_color}, 汽油類型：{str_oil}";
        }
    }
}