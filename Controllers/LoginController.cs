using Microsoft.AspNetCore.Mvc;

namespace Mvc.Net.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
