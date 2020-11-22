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
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> logger;
        private readonly ApplicationDbContext dbContext;

        public string ReturnUrl { get; set; }

        public CreateModel(ILogger<CreateModel> logger, ApplicationDbContext dbContext)
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

        public void OnGet()
        { }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                string ROOM_ID = Guid.NewGuid().ToString();
                var room = new Room();
                room.Id = ROOM_ID;
                room.RoomCategoryId = ROOM_ID;
                room.FloorNumber = Input.FloorNumber;
                room.RoomNumber = Input.RoomNumber;
                room.RoomCategory = this.dbContext.RoomCategories.Find(Input.RoomCategory.ToString());

                var added = this.dbContext.Rooms.Add(room);
                var created = this.dbContext.SaveChanges();

                if (created == 1)
                {
                    this.logger.LogInformation("Room created successfully!");
                    return Redirect(this.ReturnUrl);
                }
            }
            return Page();
        }
    }
}
