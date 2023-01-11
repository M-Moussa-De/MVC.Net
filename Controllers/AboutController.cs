using Microsoft.AspNetCore.Mvc;

namespace Mvc.Net.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
