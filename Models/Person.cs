using System;
using Microsoft.AspNetCore.Identity;

namespace HotelManagementSystem.Models
{
    public class Person : IdentityUser
    {
        [PersonalData]
        public string Firstname { get; set; }
        [PersonalData]
        public string Lastname { get; set; }

        [PersonalData]
        public Usertype PersonType { get; set; }

    }
}