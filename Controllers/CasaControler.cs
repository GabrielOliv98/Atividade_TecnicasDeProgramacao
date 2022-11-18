using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using trabalho.Models;

namespace trabalho.Controllers;

public class CasaController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public CasaController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Casa()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
