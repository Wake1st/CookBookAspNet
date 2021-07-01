using Microsoft.AspNetCore.Mvc;

namespace aspnetcookbook.Controllers
{
  public class SkillController : Controller
  {
    private readonly JsonDataHelper _dataHelper;

    public SkillController(JsonDataHelper dataHelper)
    {
      _dataHelper = dataHelper;
    }

    public IActionResult Index()
    {
      return View(_dataHelper.GetSkills());
    }
  }
}