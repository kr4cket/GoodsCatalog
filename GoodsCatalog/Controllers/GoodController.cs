using Microsoft.AspNetCore.Mvc;

namespace GoodsCatalog.Controllers
{
    public class GoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
