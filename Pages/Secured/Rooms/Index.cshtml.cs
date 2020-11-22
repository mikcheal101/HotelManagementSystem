using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using  Microsoft.Extensions.Logging;
namespace HotelManagementSystem.Pages.Secured.Rooms
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly ApplicationDbContext dbContext;

        public ICollection<Room> Rooms { get; set; }

        public IndexModel(ILogger<IndexModel> logger,  ApplicationDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
            this.Rooms = this.dbContext.Rooms.ToList<Room>();
        }

        public async Task OnGetAsync()
        {
            foreach (var room in this.Rooms)
            {
                room.RoomCategory = await this.dbContext.RoomCategories.FindAsync(room.RoomCategoryId);
            }
        }
    }
}
