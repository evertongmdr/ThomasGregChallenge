using Microsoft.AspNetCore.Identity;

namespace ThomasGreg.Domain.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomName { get; set; }
    }
}
