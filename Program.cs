var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Selamlar tüm aktarımla geldi. Savaş Enes Erateşli");

app.Run("http://0.0.0.0:9090");
