using backend;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
	.AddControllers()
	.AddJsonOptions(options => {
		options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
		options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
		options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
		options.JsonSerializerOptions.IncludeFields = true;
		options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
	});
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlite(DatabaseContext.ConnectionString));

WebApplication app = builder.Build();

app.UseCors(options =>
{
	options.AllowAnyOrigin();
});

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();
