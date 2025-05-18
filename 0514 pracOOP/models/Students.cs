using System;

namespace oop.demo;

/// <summary>
/// 學生識別
/// </summary>
public class Students
{
    /// <summary>
    /// 學生編號
    /// </summary>
    public string No { get; set; } = "";
    /// <summary>
    /// 學生姓名
    /// </summary>
    public string Name { get; set; } = "";
    /// <summary>
    /// 性別 : M=男 F=女
    /// </summary>
    public enGender Gender { get; set; } = enGender.Female;
    /// <summary>
    /// 出生日期
    /// </summary>
    public DateTime Birthday { get; set; } = DateTime.MinValue;
}
