using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AsriATS.Persistance
{
    public static class PersistanceServiceExtension
    {
        public static void ConfigurePersistance(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(opt => {
                opt.UseNpgsql(connection);
            });
        }
    }
}