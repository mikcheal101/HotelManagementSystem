using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
namespace HotelManagementSystem.Pages.Secured.Rooms
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly ApplicationDbContext dbContext;

        public ICollection<Room> Rooms { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }

        public async Task OnGetAsync()
        {
            this.Rooms = await this.dbContext.Rooms
                .Include(room => room.RoomCategory)
                .AsNoTracking()
                .ToListAsync<Room>();

            foreach (var room in this.Rooms)
            {
                room.RoomCategory = await this.dbContext.RoomCategories.FindAsync(room.RoomCategoryId);
            }
        }
    }
}
