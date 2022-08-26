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

  }
}