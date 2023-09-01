namespace TravelExperienceGraphQLAPI.Configuration
{
    public static class ApplicationConfiguration
    {
        public static string GetConnectionString(WebApplicationBuilder app)
        {
            return app.Configuration.GetConnectionString("DefaultConnection");
        }

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("Open",
                    builder => builder
                        .WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials());
            });
        }
    }
}
