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

app.UseHttpsRedirection();

app.UseAuthorization();


// 使用 Controller 路由
app.MapControllers();

app.Run();

