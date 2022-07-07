using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Application.ViewModels.User
{
    public class RegisterUserViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar una foto de perfil")]
        public string ProfilePicture { get; set; }

        [Required(ErrorMessage = "Debe colocar un nombre")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe colocar su apellido")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Debe colocar un nombre de usuario")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Debe colocar una contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Las contraseñas no coiciden")]
        [Required(ErrorMessage = "Debe colocar una contraseña")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Debe colocar un correo")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe colocar un telefono")]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }


        // For rendering purposes
        public bool IsVerified { get; set; } = false;
        public bool ErrorUserExists { get; set; } = false;


        // Profile picture file

        [DataType(DataType.Upload)]
        public IFormFile File { get; set; }
    }
}
