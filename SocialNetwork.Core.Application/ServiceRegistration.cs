using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Core.Application.Interfaces.Services;
using SocialNetwork.Core.Application.Services;
using System.Reflection;

namespace SocialNetwork.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection service, IConfiguration configuration)
        {
            /// Services
            service.AddTransient<IPublicationService, PublicationService>();
            service.AddTransient<IUserService, UserService>();
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
