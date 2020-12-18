using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker : Controller
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}