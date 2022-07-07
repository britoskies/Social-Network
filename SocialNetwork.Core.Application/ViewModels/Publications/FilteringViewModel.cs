using System.Collections.Generic;

namespace SocialNetwork.Core.Application.ViewModels.Publications
{
    public class FilteringViewModel
    {
        public List<int> CategoryIds { get; set; } = new List<int>();
        public string PublicationName { get; set; }
    }
}
