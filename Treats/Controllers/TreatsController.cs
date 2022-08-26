using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Treats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Treats.Controllers
{
  // [Authorize]
  public class TreatsController : Controller
  {
    private readonly TreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    // public RecipesController(UserManager<ApplicationUser> userManager, RecipeBoxContext db)
    public TreatsController(TreatsContext db)
    {
      // _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }

    [Authorize]
    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Treat treat, int FlavorId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      treat.User = currentUser;
      _db.Treats.Add(treat);
      _db.SaveChanges();
      if (FlavorId != 0)
      {
        _db.FlavorTreat.Add(new FlavorTreat() { FlavorId = FlavorId, TreatId = treat.TreatId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
    [Authorize]
    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats
        .Include(treat => treat.JoinFlavors)
        .ThenInclude(join => join.Flavor)
        .FirstOrDefault(treat => treat.TreatId == id);
        return View(thisTreat);
    }
  }
}