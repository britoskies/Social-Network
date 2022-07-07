using SocialNetwork.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Application.ViewModels.Publications
{
    public class PublicationViewModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Caption { get; set; }

        // User References
        public int UserId { get; set; }
        public UserViewModel User { get; set; }
    }
}
