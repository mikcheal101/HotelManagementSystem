using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public class Customer : Person
    {
        [Required(ErrorMessage="Passport number is required!")]
        [PersonalData]
        public string PassportNumber { get; set; }


        [Required(ErrorMessage="Passport Photo is required!")]
        [PersonalData]
        public string PassportPhoto { get; set; }
    }
}