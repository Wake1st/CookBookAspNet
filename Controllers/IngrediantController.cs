using Microsoft.AspNetCore.Mvc;

namespace aspnetcookbook.Controllers
{
  public class IngrediantController : Controller
  {
    private readonly JsonDataHelper _dataHelper;

    public IngrediantController(JsonDataHelper dataHelper)
    {
      _dataHelper = dataHelper;
    }

    public IActionResult Index()
    {
      return View(_dataHelper.GetIngrediants());
    }
  }
}