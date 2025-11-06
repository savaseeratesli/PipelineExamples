var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Ziraat Team from @Savaş Enes ERATEŞLİ");

app.Run("http://0.0.0.0:11130");
