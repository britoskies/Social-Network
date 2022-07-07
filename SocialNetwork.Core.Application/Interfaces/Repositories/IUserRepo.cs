using SocialNetwork.Core.Application.ViewModels.User;
using SocialNetwork.Core.Application.Interfaces.Repositories;
using SocialNetwork.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Application.Interfaces.Repositories
{
    public interface IUserRepo : IGenericRepo<UserModel> 
    {
        Task<UserModel> LoginAsync(LoginViewModel loginVm);
        Task<UserModel> ValidateUser(RegisterUserViewModel vm);
    }
}
