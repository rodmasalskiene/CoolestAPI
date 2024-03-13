using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

//builder.WebHost.UseKestrel().UseUrls("http://localhost:6262", "http://localhost:7045");
builder.WebHost.UseKestrel();

var app = builder.Build();

app.MapGet("/", () => "Hello, World!");
app.MapGet("/teste", () => "salve kk");

//app.Run("http://localhost:6262");
app.Run();