using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Pages.Authentication
{
    public class IndexModel : PageModel
    {

        public class FormModel
        {
            [Required]
            [Display(Name = "Username")]
            public string Username { get; set; }

            [Required]
            [StringLength(10, ErrorMessage = "{0} length must be between {2} and {1}", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Display(Name = "Remember Me")]
            public bool RememberMe { get; set; }
        }

        [BindProperty]
        public FormModel Input { get; set; }

        public void OnGet()
        { }
    }
}