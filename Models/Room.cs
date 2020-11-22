using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public class Room
    {
        [Key]
        public string Id { get; set; }

        public int FloorNumber { get; set; }
        public string RoomNumber { get; set; }
        public RoomCategory RoomCategory { get; set; }
    }
}