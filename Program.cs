var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Selamlar CI/CD süreci tamamlandi.");

app.Run("http://0.0.0.0:9090");
