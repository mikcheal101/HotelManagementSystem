using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


using Microsoft.Extensions.Logging;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Pages.Secured.Rooms.Category
{
    public class DeleteModel : PageModel
    {
        private readonly ILogger<DeleteModel> logger;
        private readonly ApplicationDbContext dbContext;

        public string ReturnUrl { get; set; }

        public DeleteModel(ILogger<DeleteModel> logger, ApplicationDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
            this.ReturnUrl = "/Secured/Rooms/Category/Index";
        }

        public async Task<IActionResult> OnGetAsync(string Id)
        {
            var roomCategory = await this.dbContext.RoomCategories.FindAsync(Id);
            if (roomCategory != null)
            {
                this.dbContext.Remove<RoomCategory>(roomCategory);
                var deleted = await this.dbContext.SaveChangesAsync();
                if (deleted == 1)
                {
                    this.logger.LogInformation("Room Category Deleted Successfully!");
                }
            }
            return Redirect(this.ReturnUrl);
        }
    }
}
