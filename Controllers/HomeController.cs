using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NDCuong114.Models;

namespace NDCuong114.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }
[HttpPost]
    public IActionResult Index(string fullName,string Email)
    {
        ViewBag.name = "hihi"+ " "+ fullName+"-"+ Email;
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
