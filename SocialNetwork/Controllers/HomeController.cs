using E_Market.Middlewares;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Core.Application.Interfaces.Services;
using SocialNetwork.Core.Application.ViewModels.Publications;
using System.Threading.Tasks;

namespace SocialNetwork.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPublicationService _publicationService;
        private readonly IFileUploader _fileUploader;
        private readonly UserSessionValidation _userSession;

        public HomeController(
            IPublicationService publicationService, 
            UserSessionValidation userSession,
            IFileUploader fileUploader)
        {
            _publicationService = publicationService;
            _userSession = userSession;
            _fileUploader = fileUploader;
        }

        public async Task<IActionResult> Index()
        {
            if (!_userSession.HasUser()) return RedirectToRoute(new
            { controller = "User", action = "Index" });

            return View(await _publicationService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SavePublicationViewModel vm)
        {
            if (!_userSession.HasUser()) return RedirectToRoute(new
            { controller = "User", action = "Index" });

            if (!ModelState.IsValid)
            {
                return View("Index",vm);
            }

            // Save profile picture
            SavePublicationViewModel publication = await _publicationService.Add(vm);
            publication.Image = _fileUploader.UploadFile(vm.File, publication.Id);
            await _publicationService.Update(publication, publication.Id);

            return View("Index", vm);
        }
    }
}
