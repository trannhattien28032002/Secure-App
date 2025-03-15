using Microsoft.AspNetCore.Identity;

namespace API.Models 
{
    public class AppUser:IdentityUser 
    {
        public string? MyProperty { get; set; }
    }
}