using System.Collections.Generic;
using System; 
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers 
{
    public class VendorController : Controller 
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);

        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View(); 
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string name)
        {
            Vendor newVendor = new Vendor(name);
            return RedirectToAction("Index");

        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> tionaries = new Dictionary<string, object>();
            Vendor chosenVendor = Vendor.Find(id);
            List<Order> VenOrders = chosenVendor.Orders;
            tionaries.Add("vendor", chosenVendor);
            tionaries.Add("orders", typeOrders);
            return View(tionaries);
        }
    }
}