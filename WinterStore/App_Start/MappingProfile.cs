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
                //Domain to Dto
                Mapper.CreateMap<Equipment, EquipmentDto>();
                Mapper.CreateMap<EquipmentType, EquipmentTypeDto>();
                Mapper.CreateMap<Customer, CustomerDto>();

                //Dto to domain
                Mapper.CreateMap<EquipmentDto, Equipment>()
                .ForMember(c => c.Id, opt => opt.Ignore());

                Mapper.CreateMap<CustomerDto, Customer>()
               .ForMember(c => c.CustomerId, opt => opt.Ignore());
            }
        }
    }
}