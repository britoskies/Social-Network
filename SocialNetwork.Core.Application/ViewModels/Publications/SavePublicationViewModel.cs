using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Core.Application.ViewModels.Publications
{
    public class SavePublicationViewModel
    {
        public int Id { get; set; }
        public string Image { get; set; }

        [Required(ErrorMessage = "Debe colocar contenido")]
        [DataType(DataType.Text)]
        public string Caption { get; set; }
        public int UserId { get; set; }


        [DataType(DataType.Upload)]
        public IFormFile File { get; set; }
    }
}
