using Microsoft.AspNetCore.Mvc;

namespace Project.Web.Controllers
{
 
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("1231232");
            return View();
        }
    }
}
