using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;

namespace HotelManagementSystem.Pages.Secured.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> logger;
        private readonly ApplicationDbContext dbContext;
        private readonly string ReturnUrl;

        public SelectList Rooms { get; set; }
        private readonly UserManager<Person> userManager;

        public CreateModel(UserManager<Person> userManager, ApplicationDbContext dbContext, ILogger<CreateModel> logger)
        {
            this.userManager = userManager;
            this.dbContext = dbContext;
            this.logger = logger;
            this.ReturnUrl = "/Secured/Bookings/Index";
        }
        public class FormModel
        {
            [Display(Name = "Customer Details")]
            public Customer Customer { get; set; }

            [Required]
            [Display(Name = "Room Number")]
            public string Room { get; set; }

            [Required]
            [Display(Name = "Check-In Time")]
            public DateTime CheckInTime { get; set; }

            [Display(Name = "Nights")]
            [Range(1, 14, ErrorMessage = "Value must be between {1} and {2}.")]
            public int Nights { get; set; }

            [Display(Name = "Expected Check-Out Time")]
            public DateTime ExpectedCheckOutTime { get; set; }
        }

        [BindProperty]
        public FormModel Input { get; set; }

        public void CalculateCheckoutTime()
        {
            var current_time = DateTime.Now;
            var noon = current_time.Date + new TimeSpan(12, 0, 0);
            var checkout_time = noon;

            if (current_time > noon)
            {
                checkout_time = checkout_time.AddDays(1);
            }
            this.Input.ExpectedCheckOutTime = checkout_time;
        }

        public void OnGet(string customer_id)
        {
            this.Input = new FormModel();
            this.Input.CheckInTime = DateTime.Now;
            this.Input.Nights = 1;
            this.Rooms = new SelectList(this.dbContext.Rooms.Where<Room>(room => room.Status == RoomStatues.EMPTY).ToList<Room>(), "Id", "PreferedName");
            this.CalculateCheckoutTime();

            if (customer_id != null)
            {
                this.Input.Customer = this.dbContext.Customers.Find(customer_id);
            }
        }

        public async Task<IActionResult> OnPost(string customer_id)
        {
            if (customer_id != null)
            {
                this.Input.Customer = this.dbContext.Customers.Find(customer_id);

                if (ModelState.IsValid)
                {
                    Room room = this.dbContext.Rooms.Find(this.Input.Room);
                    room.Status = RoomStatues.OCCUPIED;
                    this.dbContext.Rooms.Update(room);

                    Booking booking = new Booking();
                    booking.Id = Guid.NewGuid().ToString();
                    booking.Attendant = await this.userManager.GetUserAsync(HttpContext.User);
                    booking.Customer = this.dbContext.Customers.Find(customer_id);
                    booking.CheckInTime = this.Input.CheckInTime;
                    booking.Room = room;
                    booking.ExpectedCheckOutTime = this.Input.ExpectedCheckOutTime.AddDays(this.Input.Nights - 1);
                    await this.dbContext.Bookings.AddAsync(booking);
                    await this.dbContext.SaveChangesAsync();

                    return Redirect(this.ReturnUrl);
                }
            }
            return Page();
        }
    }
}