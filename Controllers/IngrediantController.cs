using Microsoft.AspNetCore.Mvc;

namespace aspnetcookbook.Controllers
{
  public class IngrediantController : Controller
  {

    public IngrediantController()
    {

    }

    public IActionResult Index()
    {
      return View();
    }
  }
}