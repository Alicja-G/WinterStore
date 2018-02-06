using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinterStore.Models;

namespace WinterStore.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {

            return View("ListWithAllOptions");
        }

        //--------

        public ActionResult New()
        {
            var customer = new Customer();

            return View("Index", customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var newCustomer = new Customer
                {
                    CustomerName = customer.CustomerName
                };

                return View("Index", newCustomer);
            }

            if (customer.CustomerId == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.CustomerId == customer.CustomerId);
                customerInDb.CustomerName = customer.CustomerName;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

       

        
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);

            if (customer == null)
                return HttpNotFound();

            var newCustomer = new Customer
            {
                CustomerName = customer.CustomerName
            };

            return View("Index", customer);
        }
    }


}
