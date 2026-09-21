using Microsoft.AspNetCore.Identity;

namespace DocAppoint.Models
{
    public class Users:IdentityUser
    {
        public string Name { get; set; }
    }
}
