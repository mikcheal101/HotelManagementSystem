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
namespace HotelManagementSystem.Pages.Secured.Customers
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<IndexModel> logger;

        public IndexModel(ApplicationDbContext dbContext, ILogger<IndexModel> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        public ICollection<Person> Customers { get; set; }

        public void OnGet()
        {
            this.Customers = this.dbContext.People
                .Where<Person>(person => person.PersonType.Name == UserRole.CUSTOMER.ToString().ToLower())
                .ToList<Person>();
        }
    }
}
