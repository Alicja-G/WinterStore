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
        public string CustomerName { get; set; }

    }
}