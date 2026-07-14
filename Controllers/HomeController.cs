using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDWebApp.Repository;
using CRUDWebApp.Models;
using CRUDWebApp.ViewModels;

namespace CRUDWebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeViewModel
        {
            Productos = ProductoRepository.ObtenerTodos().ToList()
        };

        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ProductoModel producto)
    {
        if (ModelState.IsValid)
        {
            ProductoRepository.Agregar(producto);
            return RedirectToAction(nameof(Index));
        }

        var viewModel = new HomeViewModel
        {
            Productos = ProductoRepository.ObtenerTodos().ToList()
        };

        return View("Index", viewModel);
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
