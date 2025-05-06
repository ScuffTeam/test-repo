var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Giga Mega Ultra Текст");

app.Run();


"чё вы нах"