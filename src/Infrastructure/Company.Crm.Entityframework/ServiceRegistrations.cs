using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Company.Crm.Entityframework
{
    public static class ServiceRegistrations
    {
        //this ifadesi metodun bir extension metot olduğunu iade eder.
        public static void AddEntityFrameworkRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            //Program.cs ten dogrudan EF e ulaşmaması gerekir fakat biz şimdilik EF i referans alalım.DI ile refere ettik.

            var connectionString = configuration.GetConnectionString("Default");
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
        }

    }
}
