using SocialNetwork.Core.Domain.Entities;
using SocialNetwork.Infrastucture.Persistence.Contexts;
using SocialNetwork.Core.Application.ViewModels.User;
using SocialNetwork.Core.Application.Interfaces.Repositories;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Core.Application.Helpers;

namespace SocialNetwork.Infrastructure.Persistence.Repositories
{
    public class UserRepo : GenericRepo<UserModel>, IUserRepo
    {
        private readonly ApplicationContext _dbContext;

        public UserRepo(ApplicationContext Context) : base(Context)
        {
            _dbContext = Context;
        }

        public override async Task<UserModel> AddAsync(UserModel entity)
        {
            entity.Password = PasswordEncryptation.ComputeSha256Hash(entity.Password);
            await base.AddAsync(entity);
            return entity;
        }

        public async Task<UserModel> LoginAsync(LoginViewModel loginVm)
        {
            string passwordEncrypt = PasswordEncryptation.ComputeSha256Hash(loginVm.Password);
            UserModel user = await _dbContext.Set<UserModel>().FirstOrDefaultAsync(user => 
                user.UserName == loginVm.UserName && user.Password == passwordEncrypt);

            return user;
        }

        public async Task<UserModel> ValidateUser(RegisterUserViewModel vm)
        {
            UserModel user = await _dbContext.Set<UserModel>().FirstOrDefaultAsync(user =>
                user.UserName.ToLower() == vm.UserName.ToLower());

            if (user != null) return user;
            return null;
        }
    }
}
