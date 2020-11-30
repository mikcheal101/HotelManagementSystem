using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;

namespace HotelManagementSystem.Pages.Secured.Bookings
{
    public class IndexPage : PageModel
    {
        private readonly ILogger<IndexPage> logger;
        private readonly ApplicationDbContext dbContext;
        public IndexPage(ApplicationDbContext dbContext, ILogger<IndexPage> logger)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }

        [BindProperty]
        public ICollection<Booking> Bookings { get; set; }

        public void OnGet()
        {
            this.Bookings = this.dbContext.Bookings
                .Include(Booking => Booking.Attendant)
                .Include(Booking => Booking.Customer)
                .Include(Booking => Booking.Room)
                .Where<Booking>(Booking => Booking.IsActive == true)
                .ToList<Booking>();
        }
    }
}
