using Microsoft.AspNetCore.Mvc;

namespace aspnetcookbook.Controllers
{
  public class KitchenwareController : Controller
  {
    private readonly JsonDataHelper _dataHelper;

    public KitchenwareController(JsonDataHelper dataHelper)
    {
      _dataHelper = dataHelper;
    }

    public IActionResult Index()
    {
      return View(_dataHelper.GetKitchenware());
    }
  }
}