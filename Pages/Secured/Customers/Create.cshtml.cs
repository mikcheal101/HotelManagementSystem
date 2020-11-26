using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using HotelManagementSystem.Models;
using HotelManagementSystem.Data;
using Microsoft.Extensions.Logging;

namespace HotelManagementSystem.Pages.Secured.Customers
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> logger;
        private readonly ApplicationDbContext dbContext;
        private readonly string ReturnUrl;
        private readonly IHostingEnvironment environment;

        public CreateModel(ApplicationDbContext dbContext, ILogger<CreateModel> logger, IHostingEnvironment environment)
        {
            this.environment = environment;
            this.dbContext = dbContext;
            this.logger = logger;
            this.ReturnUrl = "/Secured/Customers/Index";
        }

        public SelectList IdTypes = new SelectList(new List<SelectListItem>
        {
            new SelectListItem
            {
                Text=IdentificationType.DRIVERS_LICENCE.ToString().Replace("_", " "),
                Value=IdentificationType.DRIVERS_LICENCE.ToString()
            },
            new SelectListItem
            {
                Text=IdentificationType.INTERNATIONAL_PASSPORT.ToString().Replace("_", " "),
                Value=IdentificationType.INTERNATIONAL_PASSPORT.ToString()
            }
        }, "Value", "Text");

        public class FormModel
        {
            [Required]
            [Display(Name = "First Name")]
            public string Firstname { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string Lastname { get; set; }

            [Required]
            [Display(Name = "Email Address")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "ID Card Number (means of identification)")]
            public string IdentificationNumber { get; set; }

            [Required]
            [Display(Name = "Means Of Identification")]
            public IdentificationType MeansOfIdentificationType { get; set; }

            // [Required]
            [Display(Name = "Means Of Identification Image")]
            public IFormFile MeansOfIdentification { get; set; }
        }

        [BindProperty]
        public FormModel Input { get; set; }

        public void OnGet()
        { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var personType = this.dbContext.Usertypes.Where<Usertype>(usertype => usertype.Name == UserRole.CUSTOMER.ToString().ToLower()).First();
                var customer = new Customer();
                customer.Id = Guid.NewGuid().ToString();
                customer.Email = Input.Email.ToLower();
                customer.NormalizedEmail = Input.Email.ToUpper();
                customer.UserName = Input.Email.ToLower();
                customer.NormalizedUserName = Input.Email.ToUpper();
                customer.EmailConfirmed = false;
                customer.Lastname = Input.Lastname;
                customer.Firstname = Input.Firstname;
                customer.PersonType = personType;
                customer.IdentificationNumber = Input.IdentificationNumber;
                customer.MeansOfIdentificationType = Input.MeansOfIdentificationType;

                var filePath = Path.Combine(this.environment.ContentRootPath, "Uploads", Input.Email + Input.MeansOfIdentification.FileName);
                using (var stream = System.IO.File.Create(filePath))
                {
                    await Input.MeansOfIdentification.CopyToAsync(stream);
                    await this.dbContext.Customers.AddAsync(customer);
                    await this.dbContext.SaveChangesAsync();
                    return Redirect(this.ReturnUrl);
                }
            }
            return Page();
        }
    }
}
