using Microsoft.AspNetCore.Identity;

namespace HotelManagementSystem.Models
{

    public enum UserRole
    {
        CUSTOMER,
        EMPLOYEE,
        SYSTEM_ADMINISTRATOR,
    }
    
    public class Usertype : IdentityRole
    {}
}