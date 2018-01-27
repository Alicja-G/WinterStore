using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinterStore.Models;
using WinterStore.Dtos;
using System.Web.Http;

namespace WinterStore.Controllers.api
{
    public class EquipmentController : Controller
    {
        private ApplicationDbContext _context;

        public EquipmentController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetEquipment(string query = null)
        {
            var equipmentQuery = _context.Equipment
                 .Include(c => c.EquipmentType);

            if (!String.IsNullOrWhiteSpace(query))
                equipmentQuery = equipmentQuery.Where(c => c.EquipmentName.Contains(query));

            var equipmentDtos = equipmentQuery
                .ToList()
                .Select(Mapper.Map<Equipment, EquipmentDto>);

            return Ok(equipmentDtos);
        }

        

        //
    }
}
