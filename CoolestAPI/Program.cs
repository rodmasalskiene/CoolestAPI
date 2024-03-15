using CoolestAPI.Models;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

String httpPort = "http://localhost:5000";
String httpsPort = "http://localhost:5001";

builder.WebHost.UseKestrel().UseUrls(httpPort, httpsPort);

var app = builder.Build();

User user1 = new User();
user1.id = 1;
user1.name = "luquinha";
user1.email = "luquinha@email.com";

string json1 = JsonSerializer.Serialize(user1);

app.MapGet("/", () => "FOI?????");
app.MapGet("/teste", () => json1);
app.MapGet("/teste2", () => "resposta-teste2");

app.Run();

HttpClient sharedClient = new()
{
    BaseAddress = new Uri("http://localhost:5000"),
};

HttpResponseMessage response = await sharedClient.GetAsync("teste2");
response.EnsureSuccessStatusCode();

var jsonResponse = await response.Content.ReadAsStringAsync();
Console.WriteLine($"{jsonResponse}\n");



