namespace TravelExperienceGraphQLAPI.Extensions
{
    public class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, string connectionString)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (string.IsNullOrWhiteSpace(connectionString)) throw new ArgumentNullException(nameof(connectionString));

            services.AddScoped<IMySqlDataAccess>(x => new MySqlDataAccess(connectionString));
            return services;
        }
    }
}
