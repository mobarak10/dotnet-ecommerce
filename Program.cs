var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// REST PI => GET, POST, PUT, DELETE

app.MapGet("/", () => "API is working fine");

var products = new List<Product>() {
    new Product ("Sumsung s20", 100.00m),
    new Product ("Apple iphone 16", 200.00m),
};
app.MapGet("/products", () => {
    return Results.Ok(products);
});

app.Run();

public record Product(string Name, decimal Price);
