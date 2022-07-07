using AutoMapper;
using SocialNetwork.Core.Application.Dtos.Email;
using SocialNetwork.Core.Application.Interfaces.Repositories;
using SocialNetwork.Core.Application.Interfaces.Services;
using SocialNetwork.Core.Application.ViewModels.User;
using SocialNetwork.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Application.Services
{
    public class UserService : GenericService<RegisterUserViewModel, UserViewModel, UserModel>, IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;

        public UserService(IUserRepo userRepo, IEmailService emailService, IMapper mapper) : base(userRepo, mapper) 
        {
            _userRepo = userRepo;
            _emailService = emailService;
            _mapper = mapper;
        }

        public async Task<UserViewModel> Login(LoginViewModel loginVm)
        {
            UserModel user = await _userRepo.LoginAsync(loginVm);
            if (user == null) return null;

            UserViewModel userVm = _mapper.Map<UserViewModel>(user);

            return userVm;
        }

        public override async Task<RegisterUserViewModel> Add(RegisterUserViewModel vm)
        {
            RegisterUserViewModel userVm = await base.Add(vm);

            await _emailService.SendAsync(new EmailRequest
            {
                To = userVm.Email,
                Subject = "Bienvenido a la Red Social",
                Body = $"<h1> Bienvenido a la Red Social </h1> <br> <p> Su nombre de usuario es <strong> {userVm.UserName} </strong> </p> <br> <p> Haga click aquí debajo para confirmar que su cuenta ha sido creada </p>  <a href='https://localhost:44346/User/AccountVerify/{userVm.Id}'>Confirmar</a>"
            });

            return userVm;
        }

        public async Task<List<UserViewModel>> GetAllWithInclude()
        {
            List<UserModel> userList = await _userRepo.GetAllWithIncludeAsync(new List<string> { "Publications" });

            return userList.Select(user => new UserViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Username = user.UserName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                Phone = user.PhoneNumber

            }).ToList();
        }

        public async Task<UserViewModel> ValidateUser(RegisterUserViewModel vm)
        {
            UserModel registerVm = await _userRepo.ValidateUser(vm);

            if (registerVm != null) return new UserViewModel
            {
                Id = registerVm.Id,
                Name = registerVm.Name,
                LastName = registerVm.LastName,
                Email = registerVm.Email,
                Password = registerVm.Password,
                Phone = registerVm.PhoneNumber,
                Username = registerVm.UserName
            };

            return null;
        }
    }
}
