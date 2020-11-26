using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public enum IdentificationType
    {
        DRIVERS_LICENCE,
        INTERNATIONAL_PASSPORT
    }
    public class Customer : Person
    {
        [Required(ErrorMessage = "A Type of Means Of Identification is required!")]
        [PersonalData]
        public IdentificationType MeansOfIdentificationType { get; set; }

        [Required(ErrorMessage = "Means of identification number is required!")]
        [PersonalData]
        public string IdentificationNumber { get; set; }


        [Required(ErrorMessage = "Kindly Upload A Means Of Identification!")]
        [PersonalData]
        public string MeansOfIdentification { get; set; }
    }
}