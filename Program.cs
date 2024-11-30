using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddEndpointsApiExplorer();
if (app.Environment.IsDevelopment())
{
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", 
            new OpenApiInfo 
            {
                Title = "Todo API", 
                Description = "Keep track of your tasks", 
                Version = "v1"
            });
    });

    app.UseSwagger();
    app.UseSwaggerUI(c => 
    {
        c.SwaggerEndpoint("/swagger/vq/swagger.json", "Todo API V1");
    });
}

app.MapGet("/", () => "Hello World!");

app.Run();

