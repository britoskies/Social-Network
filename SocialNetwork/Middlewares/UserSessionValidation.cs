using Microsoft.AspNetCore.Http;
using SocialNetwork.Core.Application.Helpers;
using SocialNetwork.Core.Application.ViewModels.User;

namespace E_Market.Middlewares
{
    public class UserSessionValidation
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserSessionValidation(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool HasUser()
        {
            UserViewModel user = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
            return user == null ? false : true;
        }
    }
}
