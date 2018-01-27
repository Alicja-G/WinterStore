using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using WinterStore.Dtos;
using WinterStore.Models;

namespace WinterStore.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            {
                Mapper.CreateMap<Equipment, EquipmentDto>();
                Mapper.CreateMap<EquipmentDto, Equipment>();
            }
        }
    }
}