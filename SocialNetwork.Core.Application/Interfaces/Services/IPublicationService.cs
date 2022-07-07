using SocialNetwork.Core.Application.ViewModels.Publications;
using SocialNetwork.Core.Domain.Entities;

namespace SocialNetwork.Core.Application.Interfaces.Services
{
    public interface IPublicationService : IGenericService<SavePublicationViewModel, PublicationViewModel, PublicationModel>
    {

    }
}
