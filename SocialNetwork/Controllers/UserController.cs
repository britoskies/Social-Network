using E_Market.Middlewares;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Core.Application.Helpers;
using SocialNetwork.Core.Application.Interfaces.Services;
using SocialNetwork.Core.Application.ViewModels.User;
using System.Threading.Tasks;

namespace WebApp.SocialNetwork.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IFileUploader _fileUploader;
        private readonly UserSessionValidation _userSession;

        public UserController(IUserService userService, UserSessionValidation userSession, IFileUploader fileUploader)
        {
            _userService = userService;
            _userSession = userSession;
            _fileUploader = fileUploader;
        }

        public IActionResult Index()
        {
            if (_userSession.HasUser()) return RedirectToRoute(new
            { controller = "Home", action = "Index" });

            return View();
        }

        public IActionResult Register()
        {
            if (_userSession.HasUser()) return RedirectToRoute(new
            { controller = "Home", action = "Index" });

            return View(new RegisterUserViewModel());
        }

        public IActionResult Logout()
        {
            if (!_userSession.HasUser()) return RedirectToRoute(new
            { controller = "Home", action = "Index" });

            HttpContext.Session.Remove("user");
            return RedirectToRoute(new { controller = "User", action = "Index" });
        }

        public async Task<IActionResult> AccountVerify(int id)
        {
            RegisterUserViewModel saveVm = await _userService.GetById(id);
            saveVm.IsVerified = true;

            await _userService.Update(saveVm, id);
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel vm)
        {
            if (_userSession.HasUser()) return RedirectToRoute(new
            { controller = "Home", action = "Index" });

            if (!ModelState.IsValid) return View(vm);

            UserViewModel userVm = await _userService.Login(vm);

            // Check if login was correct
            
            if (userVm != null)
            {
                if (!userVm.IsVerified) 
                {
                    ModelState.AddModelError("UserValidation", "Debe validar su cuenta en el correo enviado!");
                    return View(vm);
                } 
                HttpContext.Session.Set<UserViewModel>("user", userVm);
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            } 
            
            else ModelState.AddModelError("UserValidation", "Credenciales inválidas!");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserViewModel vm)
        {
            UserViewModel userVm = await _userService.ValidateUser(vm);

            if (_userSession.HasUser()) return RedirectToRoute(new
            { controller = "Home", action = "Index" });

            if (!ModelState.IsValid) return View(vm);

            if (userVm != null)
            {
                ModelState.AddModelError("UserError", "Manito, ya existe ese usuario");
                vm.ErrorUserExists = true;
                return View(vm);
            }

            // Save profile picture
            RegisterUserViewModel user = await _userService.Add(vm);
            user.ProfilePicture = _fileUploader.UploadFile(vm.File, user.Id);
            await _userService.Update(user, user.Id);

            return RedirectToRoute(new { controller = "User", action = "Index" });
        }
    }
}
