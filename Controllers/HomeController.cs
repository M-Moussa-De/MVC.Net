using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mvc.Net.Models;

namespace Mvc.Net.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
