var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Son güncelleme 23:13 6.11.25");

app.Run("http://0.0.0.0:9090");
