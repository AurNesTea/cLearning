using Microsoft.EntityFrameworkCore;
using StrokeAlertApp.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// 加入 Controller 與 Swagger 支援
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AssessmentDbContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

var app = builder.Build();

// Configure the HTTP request pipeline.
// 啟用 Swagger（僅在開發環境）
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    // 正式環境才啟用 HTTPS 導向
    app.UseHttpsRedirection();
}

app.UseAuthorization();

// 開放靜態網頁存取, 
// 在 app.UseHttpsRedirection() 後面，app.MapControllers() 前面，
// 確保能正確處理靜態檔案（如 index.html）。
app.UseDefaultFiles();
app.UseStaticFiles();

// 使用 Controller 路由
app.MapControllers();



app.Run();

