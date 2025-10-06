var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

// REST PI => GET, POST, PUT, DELETE

app.MapGet("/", () => "API is working fine");

app.MapGet("/hello", () => "Hello World!");

app.MapPost("/hello", () =>
{
    return "Post method Hello World!";
});

app.MapPut("/hello", () =>
{
    return "Put method Hello World!";
});

app.MapDelete("/hello", () =>
{
    return "Delete method Hello World!";
});

app.Run();
