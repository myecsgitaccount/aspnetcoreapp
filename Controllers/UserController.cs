using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreapp
{
    public class UserController : Controller
    {
        [Route("admin/[controller]/[action]")]
        public string Index()
        {
            return "Hello User Two"; 
        }
    }
}