using System;
using Microsoft.AspNetCore.Identity;

namespace HotelManagementSystem.Models
{
    public class Person : IdentityUser
    {
        public enum PersonType
        {
            EmployeeAdmin = 0,
            Employee = 1,
            Customer = 2,
        };


        [PersonalData]
        public PersonType UserType { get; set; }
        [PersonalData]
        public string Firstname { get; set; }

    }
}