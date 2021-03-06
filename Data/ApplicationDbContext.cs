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
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Usertype> Usertypes { get; set; }

        public DbSet<RoomCategory> RoomCategories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RoomCategory>()
                .HasIndex(i => i.Name)
                .IsUnique();
            builder.Entity<RoomCategory>()
                .HasMany(category => category.Rooms)
                .WithOne(room => room.RoomCategory);

            builder.Entity<Room>()
                .HasOne<RoomCategory>(room => room.RoomCategory)
                .WithMany(category => category.Rooms)
                .HasForeignKey(room => room.RoomCategoryId)
                .IsRequired();
            builder.Entity<Room>()
                .HasIndex(room => new { room.RoomNumber, room.FloorNumber })
                .IsUnique();


            builder.Entity<Booking>()
                .HasOne<Customer>(booking => booking.Customer);
            builder.Entity<Booking>()
                .HasOne<Person>(booking => booking.Attendant);
            builder.Entity<Booking>()
                .HasOne<Room>(booking => booking.Room);

            // base.OnModelCreating(builder);
            PasswordHasher<Person> passwordHasher = new PasswordHasher<Person>();

            // create the usertypes
            var ADMIN_ID = Guid.NewGuid().ToString();
            var adminUsertype = new Usertype
            {
                Id = ADMIN_ID,
                ConcurrencyStamp = ADMIN_ID,
                Name = UserRole.SYSTEM_ADMINISTRATOR.ToString().ToLower(),
                NormalizedName = UserRole.SYSTEM_ADMINISTRATOR.ToString().ToUpper(),
            };

            var EMPLOYEE_ID = Guid.NewGuid().ToString();
            var employeeUsertype = new Usertype
            {
                Id = EMPLOYEE_ID,
                ConcurrencyStamp = EMPLOYEE_ID,
                Name = UserRole.EMPLOYEE.ToString().ToLower(),
                NormalizedName = UserRole.EMPLOYEE.ToString().ToUpper(),
            };

            var CUSTOMER_ID = Guid.NewGuid().ToString();
            var customerUsertype = new Usertype
            {
                Id = CUSTOMER_ID,
                ConcurrencyStamp = CUSTOMER_ID,
                Name = UserRole.CUSTOMER.ToString().ToLower(),
                NormalizedName = UserRole.CUSTOMER.ToString().ToUpper(),
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
            builder.Entity<Person>()
                .HasIndex(person => new { person.Email, person.UserName })
                .IsUnique();

            // add user to role
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {

                RoleId = ADMIN_ID,
                UserId = USER_ID
            });

            base.OnModelCreating(builder);
        }
    }
}