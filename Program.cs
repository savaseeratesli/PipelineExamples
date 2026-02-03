var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var host = Environment.MachineName;
    var time = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
    var namespaceName = Environment.GetEnvironmentVariable("POD_NAMESPACE") ?? "unknown";
    var podName = Environment.GetEnvironmentVariable("HOSTNAME") ?? "unknown";

    var html = $@"
<!DOCTYPE html>
<html lang='tr'>
<head>
    <meta charset='UTF-8'>
    <title>Kubernetes App</title>
    <style>
        body {{
            margin: 0;
            font-family: Arial, sans-serif;
            background: linear-gradient(135deg, #0f2027, #203a43, #2c5364);
            color: #fff;
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
        }}
        .card {{
            background: rgba(255, 255, 255, 0.1);
            padding: 40px;
            border-radius: 16px;
            box-shadow: 0 10px 30px rgba(0,0,0,0.4);
            max-width: 600px;
            width: 90%;
        }}
        h1 {{
            margin-top: 0;
            color: #00e5ff;
        }}
        .item {{
            margin: 10px 0;
            font-size: 16px;
        }}
        .badge {{
            display: inline-block;
            padding: 6px 12px;
            border-radius: 20px;
            background: #00c853;
            color: #003300;
            font-weight: bold;
            margin-top: 10px;
        }}
        footer {{
            margin-top: 20px;
            font-size: 12px;
            opacity: 0.7;
        }}
    </style>
</head>
<body>
    <div class='card'>
        <h1>🚀 Kubernetes Üzerinde Çalışan .NET App</h1>

        <div class='item'>👋 Merhaba Team,</div>
        <div class='item'>👤 Developed by: <b>@Savaş Enes ERATEŞLİ</b></div>
        <div class='item'>🕒 Sunucu Saati: <b>{time}</b></div>
        <div class='item'>🖥 Hostname: <b>{host}</b></div>
        <div class='item'>📦 Pod Name: <b>{podName}</b></div>
        <div class='item'>📂 Namespace: <b>{namespaceName}</b></div>

        <div class='badge'>K8s Running ✅</div>

        <footer>
            Minimal API + Kubernetes Demo
        </footer>
    </div>
</body>
</html>";

    return Results.Content(html, "text/html; charset=utf-8");
});

app.Run("http://0.0.0.0:11111");
