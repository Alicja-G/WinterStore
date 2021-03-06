﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WinterStore.Models;

namespace WinterStore.Models
{
    public class Equipment
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Name must be 2 characters or more")]
        [Display(Name = "Name of the equipment")]
        public string EquipmentName { get; set; }

        [Display(Name = "Price for 1 hour")]
        public double PriceFor1HourOfRent { get; set; }

        [Required]
        [Display(Name = "Number available in stock")]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }       


        [Display(Name = "Date of rent")]
        public DateTime? DateOfRent { get; set; }

        [Display(Name = "Date of return")]
        public DateTime? DateOfReturn { get; set; }


        public EquipmentType EquipmentType { get; set; }

        [Required]
        [ForeignKey("EquipmentType")]
        public byte EquipmentTypeId { get; set; }
       
        

       
        


    }
}