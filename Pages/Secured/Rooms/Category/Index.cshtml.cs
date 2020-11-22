using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Extensions.Logging;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Pages.Secured.Rooms.Category
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<IndexModel> logger;

        public ICollection<RoomCategory> RoomCategories { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }
        public void OnGet()
        {
            this.RoomCategories = this.dbContext.RoomCategories.ToList<RoomCategory>();
        }
    }
}
