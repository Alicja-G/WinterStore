using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinterStore.Models
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Name of the product must be 2 characters or more")]
        [Display(Name = "Name of the product")]
        public string ProductName { get; set; }

        [Display(Name = "Price for 1 day")]
        public double PriceFor1DayOfRent { get; set; }

        [Required]
        [Display(Name = "Number available in stock")]
        public byte NumberInStock { get; set; }

        [Required]
        [Display(Name = "Is it currently rented")]
        public bool IsCurrentlyRented { get; set; }

        [Display(Name = "Date of rent")]
        public DateTime DateOfRent { get; set; }

        [Display(Name = "Date of return")]
        public DateTime DateOfReturn { get; set; }

        [Display(Name = "Number of days left to return")]
        public int NumberOfDaysLeftToReturn { get; set; }

        [Required]
        public ProductType ProductType { get; set; }

    }
}