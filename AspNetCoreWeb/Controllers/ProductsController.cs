using AspNetCoreWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWeb.Controllers
{
    public class ProductsController : Controller
    {
        private AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context = context;
            //if (!_context.Products.Any())
            //{
            //    _context.Products.Add(new Product() { Name = "MasaÖrtüsü", Price = 45, Stock = 10, Color = "Blue" });
            //    _context.Products.Add(new Product() { Name = "Dolap", Price = 70, Stock = 14, Color = "Red" });
            //    _context.Products.Add(new Product() { Name = "Cüzdan", Price = 50, Stock = 19, Color = "Black" });
            //    _context.SaveChanges();
            //}
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
            TempData["status"] = "Ürün Başarıyla Silindi.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {

            ViewBag.Expire = new Dictionary<string, int>()
            {
                {"1 Ay",1 },
                {"3 Ay",3 },
                {"6 Ay",6 },
                {"12 Ay",12 }
            };

            return View();
        }
        [HttpPost]
        public IActionResult SaveProduct(Product Newproduct)
        {
            //Product Newproduct = new Product { Name = Name, Price = Price, Stock = Stock, Color = Color };
            _context.Products.Add(Newproduct);
            _context.SaveChanges();

            TempData["status"] = "Ürün Başarıyla Eklendi.";
            return RedirectToAction("Index");

            
            

            //var name = HttpContext.Request.Form["Name"].ToString();
            //var price = decimal.Parse( HttpContext.Request.Form["Price"].ToString());
            //var stock = int.Parse( HttpContext.Request.Form["Stock"].ToString());
            //var color = HttpContext.Request.Form["Color"].ToString();
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
          var product= _context.Products.Find(id);
           
            return View(product);
        }

        [HttpPost]
        public IActionResult ProductUptade(Product UpdateProduct)
        {
            _context.Products.Update(UpdateProduct);
            _context.SaveChanges();
            TempData["status"] = "Ürün Başarıyla Güncellendi.";

            return RedirectToAction("Index");
        }


    }
}
