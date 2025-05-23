// 資料模型放這裡
namespace StrokeAlertApp.Api.Models;

public class StrokeAssessment
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public bool FaceDrooping { get; set; }
    public bool ArmWeakness { get; set; }
    public bool SpeechDifficulty { get; set; }
    public DateTime Timestamp { get; set; }
}