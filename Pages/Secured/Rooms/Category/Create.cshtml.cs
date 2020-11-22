using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Extensions.Logging;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Pages.Secured.Rooms.Category
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
            this.ReturnUrl = "/Secured/Rooms/Category/Index";
        }

        public class FormControl
        {
            [Required]
            public string Name { get; set; }

            [Required]
            [Display(Name = "Cost Per Night")]
            public float CostPerNight { get; set; }
        }


        [BindProperty]
        public FormControl Input { get; set; }

        public void OnGet()
        { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var category = new RoomCategory
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = Input.Name.ToUpper(),
                    CostPerNight = Input.CostPerNight
                };
                await this.dbContext.RoomCategories.AddAsync(category);
                var created = await this.dbContext.SaveChangesAsync();
                if (created == 1)
                {
                    this.logger.LogInformation("Room Category Created Successfully!");
                    return Redirect(this.ReturnUrl);
                }
            }

            return Page();
        }
    }
}
