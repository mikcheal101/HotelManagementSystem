using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using Microsoft.Extensions.Logging;
namespace HotelManagementSystem.Pages.Secured.Employees
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> logger;
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<Person> userManager;

        public CreateModel(ILogger<CreateModel> logger, ApplicationDbContext dbContext, UserManager<Person> userManager)
        {
            this.logger = logger;
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        public class FormModel
        {
            [Required]
            public string Username { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            public string Firstname { get; set; }
            [Required]
            public string Lastname { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        [BindProperty]
        public FormModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet()
        { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {

                var EMPLOYEE_ID = Guid.NewGuid().ToString();
                var employee = new Person
                {
                    Id = EMPLOYEE_ID,
                    UserName = Input.Username.ToLower(),
                    NormalizedUserName = Input.Username.ToUpper(),
                    Email = Input.Email.ToLower(),
                    NormalizedEmail = Input.Email.ToUpper(),
                    EmailConfirmed = true,
                    Firstname = Input.Firstname,
                    Lastname = Input.Lastname
                };

                var passwordHasher = new PasswordHasher<Person>();
                employee.PasswordHash = passwordHasher.HashPassword(employee, "P@ssw0rd");
                var creatingUser = await userManager.CreateAsync(employee, Input.Password);
                if (creatingUser.Succeeded)
                {
                    this.logger.LogInformation("Employee Created Successfully!");
                    RedirectToPage("/Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "An error occued while creting the employee!");
                }
            }
            return Page();
        }
    }
}
