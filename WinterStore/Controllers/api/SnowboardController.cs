using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WinterStore.Models;
using WinterStore.Dtos;
using System.Data.Entity;
using AutoMapper;

namespace WinterStore.Controllers.api
{
    public class SnowboardController : ApiController
    {
        private ApplicationDbContext _context;

        public SnowboardController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IHttpActionResult GetSnowboard()
        {
            var equipmentQuery = _context.Equipment
                .Include(c => c.EquipmentType)
                .Where(c => c.EquipmentType.EquipmentTypeTypeOfSport == "Snowboard");


            var equipmentDtos = equipmentQuery
                .ToList()
                .Select(Mapper.Map<Equipment, EquipmentDto>);

            return Ok(equipmentDtos);
        }
    }
}
