using Microsoft.AspNetCore.Mvc;
using Treats.Models;

namespace Treats.Controllers
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