using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WinterStore.Dtos
{
    public class EquipmentDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Name must be 2 characters or more")]
        public string EquipmentName { get; set; }

       
        public double PriceFor1HourOfRent { get; set; }

        [Required] 
        public byte NumberInStock { get; set; }

        [Required]
        public bool IsCurrentlyRented { get; set; }

        
        public DateTime DateOfRent { get; set; }

        
        public DateTime DateOfReturn { get; set; }

        public int NumberOfDaysLeftToReturn { get; set; }


       

    }
}