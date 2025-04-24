// Program.cs - Entry point of the .NET Web API application
// This file configures the application's services and middleware pipeline

// Import necessary namespaces
using UserManagerAPI.Data;
using UserManagerAPI.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using UserManagerAPI.Models;

// Create a new WebApplication builder
// This is the starting point for configuring the application
var builder = WebApplication.CreateBuilder(args);

// Configure Services
// Services are components that can be injected into other parts of the application
builder.Services.AddControllers(); // Add support for MVC controllers
builder.Services.AddEndpointsApiExplorer(); // Enable API documentation
builder.Services.AddSwaggerGen(); // Add Swagger for API documentation and testing

// Configure settings
var appSettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>();
builder.Services.AddSingleton(appSettings);

// Configure Entity Framework Core with SQLite
// This sets up the database context that will be used throughout the application
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Configure CORS (Cross-Origin Resource Sharing)
// This allows the frontend application to communicate with this API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin() // Allow requests from any origin
              .AllowAnyMethod() // Allow any HTTP method (GET, POST, PUT, DELETE)
              .AllowAnyHeader(); // Allow any HTTP headers
    });
});

// Build the application
var app = builder.Build();

// Configure Middleware Pipeline
// Middleware components process HTTP requests and responses in sequence

// Enable Swagger in development environment
// Swagger provides interactive API documentation
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Enable Swagger middleware
    app.UseSwaggerUI(); // Enable Swagger UI
}

// Important: Order of middleware matters!
// CORS must be configured before other middleware that might block requests
app.UseCors("AllowAll"); // Apply CORS policy
app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
app.UseAuthorization(); // Enable authorization middleware

// Map controller routes
// This connects URL patterns to controller actions
app.MapControllers();

// Start the application
app.Run();
