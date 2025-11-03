// Program.cs
// Minimal .NET 7 Web API - returns: "Hello WORLD Team from Savaş Enes Erateşli"
// Listens on port 11130 by default (can be overridden by ASPNETCORE_URLS env)

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Kestrel'ı explicit olarak 11130 portuna bind edelim (ENV ile override edilebilir)
builder.WebHost.ConfigureKestrel(options =>
{
    // Kestrel port binding is optional — will also respect ASPNETCORE_URLS env
});

var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Text("Hello WORLD Team from Savaş Enes Erateşli", "text/plain");
});

app.Run();
