using SocialNetwork.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Domain.Entities
{
    public class PublicationModel : AuditableBaseEntity
    {
        public string Image { get; set; }
        public string Caption { get; set; }

        // User References
        public int UserId { get; set; }
        public UserModel User { get; set; }
    }
}
