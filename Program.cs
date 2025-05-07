var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Giga Mega Ultra Текст");

Console.WriteLine("Всем привет");

