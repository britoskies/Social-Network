using SocialNetwork.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Domain.Entities
{
    public class UserModel : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public bool IsVerified { get; set; }

        // Nav Properties
        public ICollection<PublicationModel> Publications { get; set; }
    }
}
