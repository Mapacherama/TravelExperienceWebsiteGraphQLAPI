using TravelExperienceGraphQLAPI.Configuration;
using TravelExperienceGraphQLAPI.Extensions;
using TravelExperienceGraphQLAPI.GraphQL;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registering services
builder.Services.AddDataServices(ApplicationConfiguration.GetConnectionString(builder));
builder.Services.AddScoped<Query>();

builder.Services.AddControllers();
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseCors("Open");

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapGraphQL();
    endpoints.MapGraphQLVoyager();
});

await app.RunAsync();