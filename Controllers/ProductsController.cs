using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreapp.Controllers
{
    public class ProductsController : Controller
    {
        public List<string> Index()
        {
            return new List<string>()
            {
                "Item 1",
                "Item 2"
            }; 
        }
    }
}