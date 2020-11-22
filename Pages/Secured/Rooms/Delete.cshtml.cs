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

namespace HotelManagementSystem.Pages.Secured.Rooms
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
            this.ReturnUrl = "/Secured/Rooms/Index";
        }

        public async Task<IActionResult> OnGet(string Id)
        {
            Room room = await this.dbContext.Rooms.FindAsync(Id);
            if (room != null)
            {
                this.dbContext.Remove<Room>(room);
                await this.dbContext.SaveChangesAsync();

            }
            return Redirect(this.ReturnUrl);
        }
    }
}
