using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tutorial_4_exercise1.Models;

namespace Tutorial_4_exercise1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }

    public IActionResult RegisterSeller()
    {
        return View();
    }

    public IActionResult RentalProperties()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

