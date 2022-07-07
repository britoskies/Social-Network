using SocialNetwork.Core.Application.Helpers;
using SocialNetwork.Core.Application.Interfaces.Repositories;
using SocialNetwork.Core.Application.Interfaces.Services;
using SocialNetwork.Core.Application.ViewModels.Publications;
using SocialNetwork.Core.Application.ViewModels.User;
using SocialNetwork.Core.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Application.Services
{
    public class PublicationService : GenericService<SavePublicationViewModel, PublicationViewModel, PublicationModel>, IPublicationService
    {
        private readonly IPublicationRepo _publicationRepo;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserViewModel userViewModel;
        private readonly IMapper _mapper;

        public PublicationService(IPublicationRepo publicationRepo, IHttpContextAccessor contextAccessor, IMapper mapper) 
            : base(publicationRepo, mapper)
        {
            _publicationRepo = publicationRepo;
            _contextAccessor = contextAccessor;
            _mapper = mapper; 
            userViewModel = _contextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }

        public override async Task<SavePublicationViewModel> Add(SavePublicationViewModel vm)
        {
            vm.UserId = userViewModel.Id;
            return await base.Add(vm);
        }

        public override async Task Update(SavePublicationViewModel vm, int id)
        {
            await base.Update(vm, id);
        }

        public async Task<List<PublicationViewModel>> GetAllWithInclude()
        {
            List<PublicationModel> publicationList = await _publicationRepo.GetAllWithIncludeAsync(new List<string>
            {
                "User"
            });

            return publicationList.Where(p => p.UserId == userViewModel.Id).Select(publication => new PublicationViewModel
            {
                Id = publication.Id,
                Caption = publication.Caption,
                Image = publication.Image,
                User = _mapper.Map<UserViewModel>(publication.User)

            }).ToList();
        }
    }
}
