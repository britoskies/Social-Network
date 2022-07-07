using SocialNetwork.Core.Application.ViewModels.User;
using SocialNetwork.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Application.Interfaces.Services
{
    public interface IUserService : IGenericService<RegisterUserViewModel, UserViewModel, UserModel>
    {
        Task<UserViewModel> Login(LoginViewModel loginVm);
        Task<UserViewModel> ValidateUser(RegisterUserViewModel vm);
        Task<List<UserViewModel>> GetAllWithInclude();
    }
}
