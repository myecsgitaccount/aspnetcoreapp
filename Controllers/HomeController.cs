using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreapp
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            return View(); 
        }

        public IActionResult About()
        {
            return View(); 
        }

        public IActionResult Contact()
        {
            return View(); 
        }
    }
}
