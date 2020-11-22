using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using System.ComponentModel.DataAnnotations;


using Microsoft.Extensions.Logging;

namespace HotelManagementSystem.Pages.Secured.Employees
{
    public class UpdateModel : PageModel
    {
        private readonly ILogger<UpdateModel> logger;
        private readonly ApplicationDbContext dbContext;

        public UpdateModel(ILogger<UpdateModel> logger, ApplicationDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
            this.ReturnUrl = "/Secured/Employees/Index";
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
        }

        [BindProperty]
        public FormModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public Person Employee { get; set; }
        public async Task<IActionResult> OnGetAsync(string Id)
        {
            this.Employee = await this.dbContext.People.FindAsync(Id);
            if (this.Employee == null)
            {
                return Redirect("/Error");
            }

            this.Input = new FormModel();
            this.Input.Firstname = this.Employee.Firstname;
            this.Input.Lastname = this.Employee.Lastname;
            this.Input.Email = this.Employee.Email;
            this.Input.Username = this.Employee.UserName;

            return Page();
        }


        public async Task<IActionResult> OnPostAsync(string Id)
        {

            if (ModelState.IsValid)
            {
                this.Employee = await this.dbContext.People.FindAsync(Id);
                if (this.Employee == null)
                {
                    return Redirect("/Error");
                }

                this.Employee.Firstname = this.Input.Firstname;
                this.Employee.Lastname = this.Input.Lastname;

                this.Employee.Email = this.Input.Email.ToLower();
                this.Employee.UserName = this.Input.Username.ToLower();
                this.Employee.NormalizedEmail = this.Input.Email.ToUpper();
                this.Employee.NormalizedUserName = this.Input.Username.ToUpper();

                try
                {
                    var result = this.dbContext.People.Update(this.Employee);
                    var response = await this.dbContext.SaveChangesAsync();
                    this.logger.LogInformation("Employee updated");
                    return Redirect(this.ReturnUrl);
                }
                catch (System.Exception exception)
                {
                    var errorMessage = exception.InnerException.Message.ToString();
                    this.logger.LogError(errorMessage);
                    ModelState.AddModelError(string.Empty, errorMessage);
                }
            }

            return Page();
        }
    }
}
