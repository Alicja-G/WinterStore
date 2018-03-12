using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WinterStore.Controllers
{
    public class SnowboardController : Controller
    {
        // GET: Snowboard
        public ActionResult Index()
        {
            return View("Snowboard");
        }
    }
}