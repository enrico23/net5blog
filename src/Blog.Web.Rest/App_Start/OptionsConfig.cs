using Blog.Utility.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Web.Rest
{
    public static class OptionsConfig
    {
        public static IServiceCollection AddOptionsConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<PositionOptions>().Bind(configuration.GetSection(PositionOptions.Position)).ValidateDataAnnotations();
            services.AddOptions<DatabaseOptions>().Bind(configuration.GetSection(DatabaseOptions.Database)).ValidateDataAnnotations();
            return services;
        }
    }
}