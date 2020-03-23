using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
    public class VendorsController : Controller
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
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor chosenVendor = Vendor.Find(id);
            List<Order> venOrders = chosenVendor.Orders;
            model.Add("vendor", chosenVendor);
            model.Add("orders", venOrders);
            return View(model);
        }

        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(string orderInfo, int vendorId, string orderPayment, string orderDate, string orderLocation)
        {
          Dictionary<string, object> model = new Dictionary<string, object>();
          Vendor foundVendor = Vendor.Find(vendorId);
          Order newOrder = new Order(orderInfo, orderPayment, orderDate, orderLocation);
          foundVendor.Add(newOrder);
          List<Order> venOrders = foundVendor.Orders;
          model.Add("orders", venOrders);
          model.Add("vendor", foundVendor);
          return View("Show", model);
        }

        }
      }
