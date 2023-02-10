var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Consegui publicar minha aplicação!");

app.Run();
