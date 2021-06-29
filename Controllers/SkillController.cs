using Microsoft.AspNetCore.Mvc;

namespace aspnetcookbook.Controllers
{
  public class SkillController : Controller
  {

    public SkillController()
    {

    }

    public IActionResult Index()
    {
      return View();
    }
  }
}