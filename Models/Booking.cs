using System;
using System.ComponentModel.DataAnnotations;

using HotelManagementSystem.Models;

namespace HotelManagementSystem.Models
{
    public enum RoomStatues
    {
        EMPTY,
        OCCUPIED
    }

    public class Booking
    {
        [Key]
        public string Id { get; set; }
        public Customer Customer { get; set; }
        public Room Room { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public DateTime ExpectedCheckOutTime { get; set; }
        public Person Attendant { get; set; }
        public bool PaidPenalty { get; set; }

        public string RoomStatus { get; set; }

        public float Penalty
        {
            get
            {
                var overlap = this.CheckOutTime - this.ExpectedCheckOutTime;
                return overlap.Days * this.Room.RoomCategory.CostPerNight;
            }
        }

    }
}