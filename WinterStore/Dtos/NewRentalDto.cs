using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinterStore.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> EquipmentIds { get; set; }

     }
}