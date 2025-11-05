var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "VS Code başlayan bu yolculuk k8s de son buldu!");

app.Run("http://0.0.0.0:9090");
