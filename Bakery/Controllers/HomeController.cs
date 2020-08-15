  
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Linq;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryContext _db;
    public HomeController(BakeryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View();
    }
  }
}