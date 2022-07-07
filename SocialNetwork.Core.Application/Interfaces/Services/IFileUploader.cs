using Microsoft.AspNetCore.Http;

namespace SocialNetwork.Core.Application.Interfaces.Services
{
    public interface IFileUploader
    {
        string UploadFile(IFormFile file, int id, bool isEditMode = false, string imagePath = "");
    }
}
