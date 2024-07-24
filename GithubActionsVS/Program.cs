var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! This is for GitHub Actions\nThis is another Example");

app.Run();
