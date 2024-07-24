var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    // Original response
    var response = "Hello World! This is for GitHub Actions";

    // New line added
    response += "\nThis is another Example";

    return response;
});
