using TravelExperienceGraphQLAPI.Configuration;
using TravelExperienceGraphQLAPI.Extensions;
using TravelExperienceGraphQLAPI.GraphQL;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registering services
builder.Services.AddDataServices(ApplicationConfiguration.GetConnectionString(builder));
builder.Services.AddScoped<Query>();