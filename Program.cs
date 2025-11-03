var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World from Savaş Enes Erateşli");

app.Run("http://0.0.0.0:11130");
