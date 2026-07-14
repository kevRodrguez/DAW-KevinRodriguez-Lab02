using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDWebApp.Models;
using CRUDWebApp.ViewModels;

namespace CRUDWebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeViewModel
        {
            Productos =
            [
                new ProductoModel
                {
                    Id = 1,
                    Nombre = "Audífonos Bluetooth",
                    Descripcion = "Sonido envolvente con cancelación de ruido y 20 horas de batería.",
                    Precio = 899.99m,
                    Stock = 15,
                    Imagen = "https://placehold.co/400x250/0d6efd/ffffff?text=Audifonos",
                    CategoriaId = 1,
                    Categoria = new CategoriaModel { Id = 1, Nombre = "Electrónica" }
                },
                new ProductoModel
                {
                    Id = 2,
                    Nombre = "Mochila Urbana",
                    Descripcion = "Compartimento para laptop de 15\" y material resistente al agua.",
                    Precio = 549.50m,
                    Stock = 8,
                    Imagen = "https://placehold.co/400x250/198754/ffffff?text=Mochila",
                    CategoriaId = 2,
                    Categoria = new CategoriaModel { Id = 2, Nombre = "Accesorios" }
                },
                new ProductoModel
                {
                    Id = 3,
                    Nombre = "Taza Cerámica",
                    Descripcion = "Diseño minimalista, apta para microondas y lavavajillas.",
                    Precio = 129.00m,
                    Stock = 0,
                    Imagen = "https://placehold.co/400x250/dc3545/ffffff?text=Taza",
                    CategoriaId = 3,
                    Categoria = new CategoriaModel { Id = 3, Nombre = "Hogar" }
                },
                new ProductoModel
                {
                    Id = 4,
                    Nombre = "Teclado Mecánico",
                    Descripcion = "Switches rojos, retroiluminación RGB y conexión USB-C.",
                    Precio = 1249.00m,
                    Stock = 5,
                    Imagen = "https://placehold.co/400x250/6f42c1/ffffff?text=Teclado",
                    CategoriaId = 1,
                    Categoria = new CategoriaModel { Id = 1, Nombre = "Electrónica" }
                }
            ]
        };

        return View(viewModel);
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
