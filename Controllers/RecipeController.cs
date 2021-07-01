using Microsoft.AspNetCore.Mvc;

namespace aspnetcookbook.Controllers
{
  public class RecipeController : Controller
  {
    private readonly JsonDataHelper _dataHelper;

    public RecipeController(JsonDataHelper dataHelper)
    {
      _dataHelper = dataHelper;
    }

    public IActionResult Index()
    {
      return View(_dataHelper.GetRecipes());
    }
  }
}