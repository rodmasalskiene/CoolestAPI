using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

builder.WebHost.UseKestrel().UseUrls("http://localhost:6262", "http://localhost:7045");

var app = builder.Build();

//app.MapGet("/", () => "Hello, World!");
//app.MapGet("/teste", () => "página teste");

app.Run("http://localhost:6262");
