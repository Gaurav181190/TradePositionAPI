using TradePositionApi.Repository;
using TradePositionApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Dependency Injection
builder.Services.AddSingleton<ITradeRepository, InMemoryTradeRepository>();
builder.Services.AddScoped<ITradeService, TradeService>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
