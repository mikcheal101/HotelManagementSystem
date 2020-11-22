using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace HotelManagementSystem.Models
{
    public class RoomCategory
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public float CostPerNight { get; set; }

        public List<Room> Rooms { get; set; }
    }
}