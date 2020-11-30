using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;


using Microsoft.Extensions.Logging;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Pages.Secured.Rooms
{
    public class UpdateModel : PageModel
    {
        private readonly ILogger<CreateModel> logger;
        private readonly ApplicationDbContext dbContext;

        public string ReturnUrl { get; set; }

        public UpdateModel(ILogger<CreateModel> logger, ApplicationDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
            this.ReturnUrl = "/Secured/Rooms/Index";
            this.RoomCategories = new SelectList(this.dbContext.RoomCategories.ToList<RoomCategory>(), "Id", "Name");
        }

        public class FormModel
        {
            [Required]
            [Display(Name = "Floor Number")]
            public int FloorNumber { get; set; }

            [Required]
            [Display(Name = "Room Number")]
            public string RoomNumber { get; set; }


            [Required]
            [Display(Name = "Room Category")]
            public Guid RoomCategory { get; set; }
        }

        public SelectList RoomCategories { get; set; }

        [BindProperty]
        public FormModel Input { get; set; }

        public async Task OnGetAsync(string Id)
        {
            var room = await this.dbContext.Rooms.FindAsync(Id);
            if (room != null)
            {
                this.Input = new FormModel();
                this.Input.FloorNumber = room.FloorNumber;
                this.Input.RoomNumber = room.RoomNumber;
                this.Input.RoomCategory = Guid.Parse(room.RoomCategoryId);
            }
        }

        public async Task<IActionResult> OnPostAsync(string Id)
        {
            if (ModelState.IsValid)
            {
                var room = await this.dbContext.Rooms.FindAsync(Id);
                if (room != null)
                {
                    room.RoomCategoryId = this.Input.RoomCategory.ToString();
                    room.FloorNumber = Input.FloorNumber;
                    room.RoomNumber = Input.RoomNumber;
                    room.Status = RoomStatues.EMPTY;
                    room.RoomCategory = await this.dbContext.RoomCategories.FindAsync(Input.RoomCategory.ToString());

                    this.dbContext.Rooms.Update(room);
                    var updated = await this.dbContext.SaveChangesAsync();

                    if (updated == 1)
                    {
                        this.logger.LogInformation("Room updated successfully!");
                        return Redirect(this.ReturnUrl);
                    }
                }
            }
            return Page();
        }
    }
}
