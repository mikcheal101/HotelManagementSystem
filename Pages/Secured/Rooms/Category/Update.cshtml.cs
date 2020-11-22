using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Extensions.Logging;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Pages.Secured.Rooms.Category
{
    public class UpdateModel : PageModel
    {
        private readonly ILogger<UpdateModel> logger;
        private readonly ApplicationDbContext dbContext;

        public string ReturnUrl { get; set; }

        public UpdateModel(ILogger<UpdateModel> logger, ApplicationDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
            this.ReturnUrl = "/Secured/Rooms/Category/Index";
        }

        public class FormController
        {
            [Required]
            public string Name { get; set; }

            [Required]
            [Display(Name = "Cost Per Night")]
            public float CostPerNight { get; set; }
        }
        [BindProperty]
        public FormController Input { get; set; }

        public async Task OnGetAsync(string Id)
        {
            var RoomCategory = await this.dbContext.RoomCategories.FindAsync(Id);
            this.Input = new FormController
            {
                Name = RoomCategory.Name,
                CostPerNight = RoomCategory.CostPerNight
            };
        }

        public async Task<IActionResult> OnPostAsync(string Id)
        {
            var RoomCategory = await this.dbContext.RoomCategories.FindAsync(Id);
            RoomCategory.Name = Input.Name.ToUpper();
            RoomCategory.CostPerNight = Input.CostPerNight;
            this.dbContext.RoomCategories.Update(RoomCategory);
            var updated = await this.dbContext.SaveChangesAsync();
            if (updated == 1)
            {
                this.logger.LogDebug("Room category updated successfully!");
                return Redirect(this.ReturnUrl);
            }

            return Page();
        }
    }
}
