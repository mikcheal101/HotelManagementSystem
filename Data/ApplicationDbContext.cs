using System;

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
        {
        }

        public DbSet<Person> People { get; set; }

        public DbSet<Usertype> Usertypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            PasswordHasher<Person> passwordHasher = new PasswordHasher<Person>();

            // create the usertypes
            var ADMIN_ID = Guid.NewGuid().ToString();
            var adminUsertype = new Usertype
            {
                Id = ADMIN_ID,
                ConcurrencyStamp = ADMIN_ID,
                Name = "system administrator".ToLower(),
                NormalizedName = "system administrator".ToUpper(),
            };

            var EMPLOYEE_ID = Guid.NewGuid().ToString();
            var employeeUsertype = new Usertype
            {
                Id = EMPLOYEE_ID,
                ConcurrencyStamp = EMPLOYEE_ID,
                Name = "employee".ToLower(),
                NormalizedName = "employee".ToUpper(),
            };

            var CUSTOMER_ID = Guid.NewGuid().ToString();
            var customerUsertype = new Usertype
            {
                Id = CUSTOMER_ID,
                ConcurrencyStamp = CUSTOMER_ID,
                Name = "customer".ToLower(),
                NormalizedName = "customer".ToUpper(),
            };

            // seed usertpes
            builder.Entity<Usertype>().HasData(adminUsertype, employeeUsertype, customerUsertype);

            // create default user
            var USER_ID = Guid.NewGuid().ToString();
            var user = new Person
            {
                Id = USER_ID,
                UserName = "admin@mail.com".ToLower(),
                Email = "admin@mail.com".ToLower(),
                NormalizedUserName = "admin@mail.com".ToUpper(),
                NormalizedEmail = "admin@mail.com".ToUpper(),
                EmailConfirmed = true,
                Firstname = "Hassan",
                Lastname = "Dalatu",
                PhoneNumber = "07020464737",
                PhoneNumberConfirmed = true,
            };
            user.PasswordHash = passwordHasher.HashPassword(user, "P@ssw0rd");

            // seed user
            builder.Entity<Person>().HasData(user);

            // add user to role
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {

                RoleId = ADMIN_ID,
                UserId = USER_ID
            });
        }
    }
}