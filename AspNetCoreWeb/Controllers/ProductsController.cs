using AspNetCoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;

namespace AspNetCoreWeb.Controllers
{
    public class ProductsController : Controller
    {
        private AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context =context;
            if (!_context.Products.Any())
            {
                _context.Products.Add(new Product() { Name = "MasaÖrtüsü", Price = 45, Stock = 10,Color="Blue" });
                _context.Products.Add(new Product() { Name = "Dolap", Price = 70, Stock = 14, Color="Red" });
                _context.Products.Add(new Product() { Name = "Cüzdan", Price = 50, Stock = 19,Color="Black"});
                _context.SaveChanges();
            }
        }
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
        public IActionResult Remove(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            return View();
        }
    }
}
