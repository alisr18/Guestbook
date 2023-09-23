using Microsoft.AspNetCore.Identity;

namespace assignment_4.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Age { get; set; }
    }
}