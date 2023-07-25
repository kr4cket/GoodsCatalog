using GoodsCatalog.Services;
using Microsoft.AspNetCore.Mvc;

namespace GoodsCatalog.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index(CatalogService service, int page)
        {
            var data = service.GetCatalogData(page);
            ViewData["Goods"] = data;
            return View();
        }
    }
}
