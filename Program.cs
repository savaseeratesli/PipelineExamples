var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "hello world.Savaş Enes ERATEŞLİ.06/11/2025 16:35");

app.Run("http://0.0.0.0:9090");
