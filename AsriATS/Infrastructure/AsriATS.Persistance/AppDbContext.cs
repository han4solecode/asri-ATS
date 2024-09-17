using AsriATS.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AsriATS.Persistance
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        private readonly IConfiguration _configuration;

        // public AppDbContext()
        // {
            
        // }

        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = _configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseNpgsql(connection);
            // optionsBuilder.UseLazyLoadingProxies();
        }

        // DBSets di bawah ini
    }
}