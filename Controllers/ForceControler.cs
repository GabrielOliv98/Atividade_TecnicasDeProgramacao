using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using trabalho.Models;

namespace trabalho.Controllers;

public class ForceController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ForceController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Force()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
