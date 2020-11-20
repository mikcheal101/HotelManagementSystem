using Microsoft.AspNetCore.Identity;

namespace HotelManagementSystem.Models
{
    public class Person : IdentityUser
    {
        [PersonalData]
        public string Firstname { get; set; }
    }
}