using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreapp
{
    [Route("Homes")]
    public class HomeController : Controller
    {
        [Route("index")]
        // GET: /<controller>/
        public string Index()
        {
            return "Hello From Controller"; 
        }

        [Route("about")]
        public string about()
        {
            return "About us"; 
        }
    }
}
