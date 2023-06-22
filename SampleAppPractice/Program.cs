using SampleAppPractice.Models;
using SampleAppPractice.Controllers;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IMessanger,SMTPMessanger>();
var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
