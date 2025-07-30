namespace oop.demo;

/// <summary>
/// 機車的類別
/// </summary>
public class Moto : Engine
{
    /// <summary>
    /// 座墊
    /// </summary>
    public string SeatCushion { get; set; } = "";
    /// <summary>
    /// 煞車系統
    /// </summary>
    public enBrakeType BrakeType { get; set; } = enBrakeType.Disc;
}