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
                _context.Products.Add(new Product() { Name = "MasaÖrtüsü", Price = 45, Stock = 10,Color="Blue",Height=100,Width=20 });
                _context.Products.Add(new Product() { Name = "Dolap", Price = 70, Stock = 14, Color="Red",Height=10,Width=25 });
                _context.Products.Add(new Product() { Name = "Cüzdan", Price = 50, Stock = 19,Color="Black",Height=45,Width=12 });
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
