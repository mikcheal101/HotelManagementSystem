using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace HotelManagementSystem.Models
{
    public enum RoomStatues
    {
        EMPTY,
        OCCUPIED
    }

    public class Room
    {
        [Key]
        public string Id { get; set; }
        public int FloorNumber { get; set; }
        public string RoomNumber { get; set; }
        public string RoomCategoryId { get; set; }

        [ForeignKey("RoomCategoryId")]
        public RoomCategory RoomCategory { get; set; }
        public RoomStatues RoomStatus { get; set; }

        public string PreferedName
        {
            get
            {
                return "Room : " + this.RoomNumber + " (Floor: " + this.FloorNumber + ").";
            }
        }
    }
}