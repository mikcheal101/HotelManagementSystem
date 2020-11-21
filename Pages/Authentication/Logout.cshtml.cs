using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


using HotelManagementSystem.Data;
using HotelManagementSystem.Models;

namespace MyApp.Namespace
{
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<Person> signInManager;
        private readonly ILogger<LogoutModel> logger;

        public LogoutModel(SignInManager<Person> signInManager, ILogger<LogoutModel> logger)
        {
            this.signInManager = signInManager;
            this.logger = logger;
        }

        public async Task<IActionResult> OnGet(string returnUrl = null)
        {
            await signInManager.SignOutAsync();
            logger.LogInformation("User logged out successfully!");
            return Redirect("/");
        }
    }
}
