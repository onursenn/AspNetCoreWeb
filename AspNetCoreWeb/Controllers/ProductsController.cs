using AspNetCoreWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWeb.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ProductRepository _productRepository;

        public ProductsController()
        {

            _productRepository = new ProductRepository();


        }
        public IActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }
        public IActionResult remove(int id)
        {
            _productRepository.remove(id);
            return RedirectToAction("Index");
        }

        public IActionResult add()
        {
            return View();
        }

        public IActionResult update(int id)
        {
            return View();
        }


    }
}
