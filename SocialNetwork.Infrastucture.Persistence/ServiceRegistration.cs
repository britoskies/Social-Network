using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Core.Application.Interfaces.Repositories;
using SocialNetwork.Infrastructure.Persistence.Repositories;
using SocialNetwork.Infrastucture.Persistence.Contexts;

namespace SocialNetwork.Infrastucture.Persistence
{
    // Decorator - Extension Method (design pattern)
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection service, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                service.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("ApplicationDb"));
            }

            else
            {
                service.AddDbContext<ApplicationContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), m =>
                    m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
            }

            // Repositories
            service.AddTransient(typeof(IGenericRepo<>), typeof(GenericRepo<>));
            service.AddTransient<IPublicationRepo, PublicationRepo>();
            service.AddTransient<IUserRepo, UserRepo>();
        }
    }
}
