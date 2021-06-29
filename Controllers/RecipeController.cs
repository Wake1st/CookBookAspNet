using Microsoft.AspNetCore.Mvc;

namespace aspnetcookbook.Controllers
{
  public class RecipeController : Controller
  {

    public RecipeController()
    {

    }

    public IActionResult Index()
    {
      return View();
    }
  }
}