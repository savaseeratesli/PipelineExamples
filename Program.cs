var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "-->>VS Code başlayan bu yolculuk container -> k8s de son buldu!Savaş Enes ERATEŞLİ.05/11/2025 16:00");

app.Run("http://0.0.0.0:9090");
