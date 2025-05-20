// 資料庫設定放這裡

using Microsoft.EntityFrameworkCore;
using StrokeAlertApp.Api.Models;


namespace StrokeAlertApp.Api.Data
{
    public class AssessmentDbContext : DbContext
    {
        public AssessmentDbContext(DbContextOptions<AssessmentDbContext> options) : base(options) { }

        public DbSet<StrokeAssessment> Assessments { get; set; }
    }
}
