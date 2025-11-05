var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Selamlar CI/CD süreci tamamlandi.Yeni sürüm");

app.Run("http://0.0.0.0:9090");
