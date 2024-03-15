var builder = WebApplication.CreateBuilder(args);

String httpPort = "http://localhost:5000";
String httpsPort = "http://localhost:5001";

builder.WebHost.UseKestrel().UseUrls(httpPort, httpsPort);

var app = builder.Build();

app.MapGet("/", () => "FOI?????");
app.MapGet("/teste", () => "pagina teste");

app.Run();

HttpClient client1 = new HttpClient();
try
{
    using HttpResponseMessage response = await client1.GetAsync(httpPort);
    //response.StatusCode = System.Net.HttpStatusCode.NotFound;
    //response.StatusCode = System.Net.HttpStatusCode.OK;
    response.EnsureSuccessStatusCode();
    Console.WriteLine("Response Content: {0}", response.Content);

    String responseBody = await response.Content.ReadAsStringAsync();
    Console.WriteLine(responseBody);
}
catch (HttpRequestException e)
{
    Console.WriteLine("Erro: {0}", e.Message);
}



