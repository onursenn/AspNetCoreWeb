using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWeb.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
