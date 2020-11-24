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
    public class DestroyModel : PageModel
    {
        public string ReturnUrl { get; private set; }
        public string ErrorReturnUrl { get; private set; }
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<DestroyModel> logger;

        public DestroyModel(
            ILogger<DestroyModel> logger,
            ApplicationDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
            this.ReturnUrl = "/Secured/Employees/Index";
        }

        public async Task<IActionResult> OnGetAsync(string Id)
        {
            var person = await this.dbContext.People.FindAsync(Id);
            if (person != null)
            {
                this.dbContext.Remove(person);
                await this.dbContext.SaveChangesAsync();
            }
            return Redirect(this.ReturnUrl);
        }
    }
}
