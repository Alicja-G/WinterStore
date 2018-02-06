using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WinterStore.Models;
using WinterStore.Dtos;
using System.Web.Http;
using System.Data.Entity;

namespace WinterStore.Controllers.api
{
    public class EquipmentController : ApiController
    {
        private ApplicationDbContext _context;

        public EquipmentController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<EquipmentDto> GetEquipment()
        {
            return _context.Equipment
                .Include(m => m.EquipmentType)
                .ToList()
                .Select(Mapper.Map<Equipment, EquipmentDto>);
        }

       

        // GET /api/equipment/1
        public IHttpActionResult GetEquipment(int id)
        {
            var equipment = _context.Equipment.SingleOrDefault(c => c.Id == id);

            if (equipment == null)
                return NotFound();

            return Ok(Mapper.Map<Equipment, EquipmentDto>(equipment));
        }

        // POST /api/equipments
        [HttpPost]
        public IHttpActionResult CreateEquipment(EquipmentDto equipmentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var equipment = Mapper.Map<EquipmentDto, Equipment>(equipmentDto);
            _context.Equipment.Add(equipment);
            _context.SaveChanges();

            equipmentDto.Id = equipment.Id;
            return Created(new Uri(Request.RequestUri + "/" + equipment.Id), equipmentDto);
        }

        // PUT /api/equipment/1
        [HttpPut]
        public IHttpActionResult UpdateEquipment(int id, EquipmentDto equipmentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var equipmentInDb = _context.Equipment.SingleOrDefault(c => c.Id == id);

            if (equipmentInDb == null)
                return NotFound();

            Mapper.Map(equipmentDto, equipmentInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/equipment/1
        [HttpDelete]
        public IHttpActionResult DeleteEquipment(int id)
        {
            var equipmentInDb = _context.Equipment.SingleOrDefault(c => c.Id == id);

            if (equipmentInDb == null)
                return NotFound();

            _context.Equipment.Remove(equipmentInDb);
            _context.SaveChanges();

            return Ok();
        }
    }


    //DataTables warning: table id=equipment - Requested unknown parameter 'equipmentType.equipmentTypeTypeOfSport' for row 0, column 1.
}

