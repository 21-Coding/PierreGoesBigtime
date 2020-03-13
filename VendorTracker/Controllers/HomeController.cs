using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet ("/")]
      public ActionResult Index()
      {
        return View();
      }
    }

    
  }
