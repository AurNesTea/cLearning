using Microsoft.AspNetCore.Mvc;

namespace StorkeAlertApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssessmentController : ControllerBase
    {
        [HttpPost]
        public ActionResult SubmitAssessment([FromBody] StrokeAssessmentDto input)
        {
            // 基本邏輯
            bool isHighRisk = input.FaceDrooping && input.ArmWeakness && input.SpeechDifficulty;

            return Ok(new
            {
                result = isHighRisk ? "高風險，請立即撥打119" : "目前無明顯中風徵兆"
            });
        }
    }

    public class StrokeAssessmentDto
    {
        public string? UserName { get; set; }
        public bool FaceDrooping { get; set; }
        public bool ArmWeakness { get; set; }
        public bool SpeechDifficulty { get; set; }
    }
}