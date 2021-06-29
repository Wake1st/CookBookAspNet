using Microsoft.AspNetCore.Mvc;

namespace aspnetcookbook.Controllers
{
  public class KitchenwareController : Controller
  {

    public KitchenwareController()
    {

    }

    public IActionResult Index()
    {
      return View();
    }
  }
}