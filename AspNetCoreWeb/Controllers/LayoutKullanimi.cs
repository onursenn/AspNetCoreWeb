using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWeb.Controllers
{
    public class LayoutKullanimi : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult layoutyok()
        {
            return View();
        }
    }
}
