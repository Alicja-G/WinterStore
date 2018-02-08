using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinterStore.Dtos
{
    public class EquipmentTypeDto
    {
        public byte Id { get; set; }
        public string EquipmentTypeTypeOfSport { get; set; }
        public string EquipmentTypeAdultOrJunior { get; set; }
    }
}