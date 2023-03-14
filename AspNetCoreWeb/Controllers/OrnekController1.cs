using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWeb.Controllers
{
    public class urunler
    {
        public int Id { get; set; }
        public String UrunAdı { get; set; }

    }



    public class OrnekController1 : Controller
    {
        public IActionResult Index()
        {

            TempData["İller"] = "Adana";
          


            ViewBag.kisiler = new { Id = 1, İsim = "Murat", Yaş = 42 };
           
            ViewData["Yaş"] = 30;


            ViewData["İsimler"] = new List<string>() { "Ali", "Mehmet", "Furkan", "Deniz" };
          
            ViewBag.isim = "Onur.Sen";
            return View();



        }



        public IActionResult index2()
        {

            return RedirectToAction("index", "ornekcontroller1");

        }


        public IActionResult index3()
        {

            var urunlistesi = new List<urunler>()
            {
                new() {Id=1, UrunAdı="Teker"},
                new() {Id=5, UrunAdı="Jant"},
                new() {Id=12, UrunAdı="Cam Filmi"},

            };

            return View(urunlistesi);
        }




        public IActionResult ContentResult()
        {
            return Content("Denemedir.");
        }




    }

}
