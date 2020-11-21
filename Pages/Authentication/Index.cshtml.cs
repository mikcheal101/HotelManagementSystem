using System;
using System.Security.Claims;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

        #region Helpers

        #region UserSerializer
        protected class CustomSerializeModel
        {
            public string UserId { get; set; }
            public string FirstName { get; set; }
            public string Username { get; set; }
        }
        #endregion

        #region Sign In Method
        private async Task SignInUser(string username, bool isPersistent)
        {
            var claims = new List<Claim>();

            try
            {
                // settings
                claims.Add(new Claim(ClaimTypes.Name, username));
                var claimIdentities = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimPrincipal = new ClaimsPrincipal(claimIdentities);
                var authenticationManager = Request.HttpContext;

                // sign in
                await authenticationManager.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    claimPrincipal,
                    new AuthenticationProperties { IsPersistent = isPersistent });
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
            }
        }
        #endregion

        #endregion
    }
}