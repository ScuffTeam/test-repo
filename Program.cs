var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Mega Giga Ultra Текст");

app.Run();
