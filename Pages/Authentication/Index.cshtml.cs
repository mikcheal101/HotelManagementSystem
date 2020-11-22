using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Microsoft.AspNetCore.Identity;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using Microsoft.Extensions.Logging;
namespace HotelManagementSystem.Pages.Authentication
{
    [AllowAnonymous]
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

        private readonly ILogger<IndexModel> logger;
        private readonly ApplicationDbContext applicationDbContext;
        private readonly SignInManager<Person> signInManager;
        private readonly UserManager<Person> userManager;

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            ApplicationDbContext applicationDbContext,
            SignInManager<Person> signInManager,
            UserManager<Person> userManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.logger = logger;
            this.applicationDbContext = applicationDbContext;
            this.ReturnUrl = "/Secured/Dashboard/Index";
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl ?? Url.Content("/Secured/Dashboard/Index");
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var person = await userManager.FindByEmailAsync(Input.Username);
                var validate_user = await signInManager.PasswordSignInAsync(person, Input.Password, Input.RememberMe, lockoutOnFailure: true);

                if (validate_user.Succeeded)
                {
                    this.logger.LogInformation("User Authenticated successfully!");
                    return Redirect(returnUrl);
                }
                else
                {
                    this.logger.LogInformation("User Authenticated Unsuccessfully!");
                    ModelState.AddModelError(string.Empty, "Invalid user credentials");
                }
            }
            return Page();
        }
    }
}