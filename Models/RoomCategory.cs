using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public class RoomCategory
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public float CostPerNight { get; set; }
    }
}