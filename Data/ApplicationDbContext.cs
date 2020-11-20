
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using System.Diagnostics;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<Person>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            PasswordHasher<Person> passwordHasher = new PasswordHasher<Person>();

            // create default user
            var user = new Person
            {
                UserName = "admin@mail.com",
                Email = "admin@mail.com",
                EmailConfirmed = true,
                Firstname = "Hassan",
                PhoneNumber = "07020464737",
                PhoneNumberConfirmed = true
            };

            user.PasswordHash = passwordHasher.HashPassword(user, "P@ssw0rd");

            // seed user
            builder.Entity<Person>().HasData(user);
        }
    }
}