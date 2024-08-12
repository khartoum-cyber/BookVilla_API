using Microsoft.AspNetCore.Identity;

namespace BookVilla_VillaAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
