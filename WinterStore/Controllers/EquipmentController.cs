using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinterStore.Models;

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
        
        
    }
}