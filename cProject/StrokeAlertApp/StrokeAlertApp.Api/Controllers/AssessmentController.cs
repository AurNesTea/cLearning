using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StrokeAlertApp.Api.Data;
using StrokeAlertApp.Api.Models;


namespace StorkeAlertApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssessmentController : ControllerBase
    {
        private readonly AssessmentDbContext _Context;
        public AssessmentController(AssessmentDbContext context)
        {
            _Context = context;
        }

        [HttpPost]
        public async Task<ActionResult> SubmitAssessment([FromBody] StrokeAssessmentDto input)
        {
            // 印出Log
            Console.WriteLine($"收到請求：{input.UserName}, {input.FaceDrooping}, {input.ArmWeakness}, {input.SpeechDifficulty}");

            // 基本邏輯
            bool isHighRisk = input.FaceDrooping && input.ArmWeakness && input.SpeechDifficulty;

            // 儲存進資料庫
            var assessment = new StrokeAssessment
            {
                UserName = input.UserName,
                FaceDrooping = input.FaceDrooping,
                ArmWeakness = input.ArmWeakness,
                SpeechDifficulty = input.SpeechDifficulty,
                Timestamp = DateTime.UtcNow
            };

            _Context.Assessments.Add(assessment);
            await _Context.SaveChangesAsync();

            return Ok(new
            {
                result = isHighRisk ? "高風險，請立即撥打119" : "目前無明顯中風徵兆"
            });
        }

        // API get History
        [HttpGet("History")]
        public async Task<ActionResult<IEnumerable<StrokeAssessment>>> GetHistory(
            [FromQuery] String? userName,
            [FromQuery] DateTime? start,
            [FromQuery] DateTime? end
        )
        {
            var query = _Context.Assessments.AsQueryable();

            // 取得用戶名字
            if (!String.IsNullOrWhiteSpace(userName))
                query = query.Where(a => a.UserName == userName);

            // 開始時間戳記
            if (start.HasValue)
                query = query.Where(a => a.Timestamp >= start.Value);

            // 結束時間戳記
            if (end.HasValue)
                query = query.Where(a => a.Timestamp <= end.Value);

            // 回傳結果
            var result = await query.OrderByDescending(a => a.Timestamp).ToListAsync();
            return Ok(result);
        }

        // API ExportCSV
        [HttpGet("ExportCsv")]
        public async Task<IActionResult> ExportCsv(
            [FromQuery] String? userName,
            [FromQuery] DateTime? start,
            [FromQuery] DateTime? end
        )
        {
            var query = _Context.Assessments.AsQueryable();

            if (!string.IsNullOrWhiteSpace(userName))
                query = query.Where(a => a.UserName == userName);

            if (start.HasValue)
                query = query.Where(a => a.Timestamp == start.Value);

            if (end.HasValue)
                query = query.Where(a => a.Timestamp == end.Value);

            var records = await query.OrderByDescending(a => a.Timestamp).ToListAsync();

            var sb = new StringBuilder();
            sb.AppendLine("Id,UserName,FaceDrooping,ArmWeakness,SpeechDifficulty,Timestamp");
            foreach (var r in records)
            {
                sb.AppendLine($"{r.Id}, {r.UserName}, {r.FaceDrooping}, {r.ArmWeakness}, {r.SpeechDifficulty}, {r.Timestamp:yyyy-MM-dd HH:mm:ss}");
            }

            var bytes = Encoding.UTF8.GetBytes(sb.ToString());
            return File(bytes, "text/csv", "assessment.csv");
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