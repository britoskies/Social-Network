using SocialNetwork.Core.Application.Interfaces.Repositories;
using SocialNetwork.Core.Domain.Entities;
using SocialNetwork.Infrastucture.Persistence.Contexts;

namespace SocialNetwork.Infrastructure.Persistence.Repositories
{
    public class PublicationRepo : GenericRepo<PublicationModel>, IPublicationRepo
    {
        private readonly ApplicationContext _dbContext;

        public PublicationRepo(ApplicationContext Context) : base(Context)
        {
            _dbContext = Context;
        }
    }
}
