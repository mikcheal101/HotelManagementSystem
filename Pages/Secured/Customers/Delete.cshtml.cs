using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using Microsoft.Extensions.Logging;
namespace HotelManagementSystem.Pages.Secured.Customers
{
    public class DeleteModel : PageModel
    {
        private readonly ILogger<DeleteModel> logger;
        private readonly ApplicationDbContext dbContext;
        private readonly string ReturnUrl;
        public DeleteModel(ILogger<DeleteModel> logger, ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.ReturnUrl = "/Secured/Customers/Index";
        }
        public async Task<IActionResult> OnGetAsync(string Id)
        {
            var customer = await this.dbContext.Customers.FindAsync(Id);
            this.dbContext.Remove<Customer>(customer);
            await this.dbContext.SaveChangesAsync();
            return Redirect(this.ReturnUrl);
        }
    }
}
