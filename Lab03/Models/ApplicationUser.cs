using Microsoft.AspNetCore.Identity;

namespace Lab03.Models
{
    public class ApplicationUser:IdentityUser

    {
        public string FullName { get; set; }
    }
}
