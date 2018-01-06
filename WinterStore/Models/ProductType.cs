using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WinterStore.Models
{
    public class ProductType
    {
        [Required]
        public int ProductTypeId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "The name of the product type must be 2 characters or more")]
        [Display(Name ="Name of the product type")]
        public string ProductTypeName { get; set; }

        [Required]
        [Display(Name ="Minimum height in centimeters required to use this product")]
        public double MinimumHeightRequiredInCm{ get; set; }

        [Required]
        [Display(Name = "Maximum height in centimeters to use this product")]
        public double MaximumHeightInCm { get; set; }

        [Required]
        [Display(Name = "Minimum weight in kilograms required to use this product")]
        public double MinimumWeightRequiredInKg { get; set; }

        [Required]
        [Display(Name = "Maximum weight in kilograms to use this product")]
        public double MaximumWeightInKg { get; set; }

    }
}