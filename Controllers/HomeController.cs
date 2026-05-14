using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using recetify.Models;

namespace recetify.Controllers;

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

    [HttpPost]
    public IActionResult GenerarSugerencia(SugeridorReceta datos)
    {
        ViewBag.plato = datos.DeterminarPlato();
        ViewBag.tiempo = datos.CalcularTiempo();
        ViewBag.dificultad = datos.DeterminarDificultad();
        return View("Resultado");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
