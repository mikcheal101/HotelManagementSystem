using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
namespace HotelManagementSystem.Pages.Secured.Bookings
{
    public class CheckoutModel : PageModel
    {
        private readonly ILogger<CheckoutModel> logger;
        private readonly ApplicationDbContext dbContext;
        private readonly string ReturnUrl;
        public CheckoutModel(ApplicationDbContext dbContext, ILogger<CheckoutModel> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.ReturnUrl = "/Secured/Bookings/Index";
        }

        public class FromControl
        {
            [Required]
            public DateTime CheckoutTime { get; set; }
            public float Penalty { get; set; }
        }

        [BindProperty]
        public FromControl Input { get; set; }
        public Booking Booking { get; set; }

        protected async Task LoadData(string Id)
        {
            this.Input = new FromControl();
            this.Input.CheckoutTime = DateTime.Now;
            this.Input.Penalty = 0;

            this.Booking = await this.dbContext.Bookings
            .Include(booking => booking.Customer)
            .Include(booking => booking.Room)
            .Include(booking => booking.Room.RoomCategory)
            .Where<Booking>(Booking => Booking.Id == Id)
            .FirstOrDefaultAsync();

            int overlap = (DateTime.Now - this.Booking.ExpectedCheckOutTime).Days + 1;
            if(overlap > 0)
            {
                this.Input.Penalty = overlap * this.Booking.Room.RoomCategory.CostPerNight;
            }
        }

        public async Task OnGetAsync(string Id)
        {
            await this.LoadData(Id);
        }

        public async Task<IActionResult> OnPostAsync(string Id)
        {
            await this.LoadData(Id);
            Room room = this.Booking.Room;
            room.Status = RoomStatues.EMPTY;
            this.dbContext.Rooms.Update(room);
            await this.dbContext.SaveChangesAsync();

            this.Booking.CheckOutTime = this.Input.CheckoutTime;
            this.Booking.IsActive = false;
            this.Booking.PaidPenalty = true;
            this.dbContext.Bookings.Update(this.Booking);

            await this.dbContext.SaveChangesAsync();
            return Redirect(this.ReturnUrl);
        }
    }
}
