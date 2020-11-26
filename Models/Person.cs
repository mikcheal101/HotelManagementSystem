using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

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

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return Firstname + ", " + Lastname; }
        }

    }
}