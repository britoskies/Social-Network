using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Core.Application.Interfaces.Services;
using SocialNetwork.Core.Domain.Settings;
using SocialNetwork.Infrastructure.Shared.Services;

namespace SocialNetwork.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection service, IConfiguration configuration)
        {
            // Services
            service.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            service.AddTransient<IEmailService, EmailService>();
            service.AddTransient<IFileUploader, FileUploader>();
        }
    }
}
