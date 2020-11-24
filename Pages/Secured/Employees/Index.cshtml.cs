using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
namespace MyApp.Namespace
{
    public class EmployeesModel : PageModel
    {
        private readonly ILogger<EmployeeModel> logger;
        private readonly ApplicationDbContext dbContext;

        public EmployeesModel(ILogger<EmployeeModel> logger, ApplicationDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }

        public ICollection<Person> Employees { get; set; }

        public void OnGet()
        {
            this.Employees = this.dbContext.People.ToList();
        }
    }
}
