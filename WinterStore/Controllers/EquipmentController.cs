using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinterStore.Models;
using WinterStore.Viewmodels;
using System.Data.Entity;

namespace WinterStore.Controllers
{
    [AllowAnonymous]
    public class EquipmentController : Controller
    {
        private ApplicationDbContext _context;

        public EquipmentController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Equipment
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.Admin))
                return View("ListWithAllOptions");

            else

                return View("ReadOnlyList");
        }

        //Not implemented yet
        //public JsonResult GetSnowboard()
        //{
        //    IQueryable<Equipment> snowboardEquipment = _context.Equipment
        //        .Include(m => m.EquipmentType)
        //        .Where(m => m.EquipmentType.EquipmentTypeTypeOfSport == "Snowboard");
                


        //    return Json(snowboardEquipment, JsonRequestBehavior.AllowGet);
        //}

        ////Not implemented yet
        //public JsonResult GetSkiing()
        //{
        //    return Json();
        //}

        ////Not implemented yet
        //public JsonResult GetAdults()
        //{
        //    return Json();
        //}

        ////Not implemented yet
        //public JsonResult GetJunior()
        //{
        //    return Json();
        //}



        public ViewResult New()
        {
            var equipmentTypes = _context.EquipmentTypes.ToList();

            var viewModel = new AddOrEditEquipmentViewModel
            {
              
                EquipmentTypes = equipmentTypes
            };

            return View("AddOrEditEquipment", viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public  ActionResult Save(Equipment equipment)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new AddOrEditEquipmentViewModel(equipment)
                {
                    EquipmentTypes = _context.EquipmentTypes.ToList()
                };

                return View("AddOrEditEquipment", viewModel);
            }

            if (equipment.Id == 0)
                _context.Equipment.Add(equipment);
            else
            {
                var equipmentInDb = _context.Equipment.Single(c => c.Id == equipment.Id);
                equipmentInDb.EquipmentName = equipment.EquipmentName;
                equipmentInDb.EquipmentTypeId = equipment.EquipmentTypeId;
                equipmentInDb.DateOfRent = equipment.DateOfRent;
                equipmentInDb.NumberInStock = equipment.NumberInStock;
                equipmentInDb.PriceFor1HourOfRent = equipment.PriceFor1HourOfRent;
            }

            _context.SaveChanges();

            return RedirectToAction("ListWithAllOptions", "Equipment");
        }


        public ActionResult Edit(int id)
        {
            var equipment = _context.Equipment.SingleOrDefault(c => c.Id == id);

            if (equipment == null)
                return HttpNotFound();

            var viewModel = new AddOrEditEquipmentViewModel(equipment)
            {
                EquipmentTypes = _context.EquipmentTypes.ToList()
            };

            return View("AddOrEditEquipment", viewModel);
        }

    }
}