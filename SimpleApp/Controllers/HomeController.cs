using Microsoft.AspNetCore.Mvc;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Download()
        {
            return File("~/introduction.pdf", "application/pdf");
        }
    }
}
