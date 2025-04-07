using Microsoft.AspNetCore.Identity;

namespace AuthApi.Data
{
    public class User : IdentityUser
    {
        public string ? Initals { get; set; }
    }
}
