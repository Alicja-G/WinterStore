using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WinterStore.Dtos
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "Name of the customer")]
        [StringLength(255)]
        [MinLength(3, ErrorMessage = "Name must be 3 or more characters long.")]
        public string CustomerName { get; set; }

    }
}