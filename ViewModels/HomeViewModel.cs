using CRUDWebApp.Models;

namespace CRUDWebApp.ViewModels;

public class HomeViewModel
{
    public List<ProductoModel> Productos { get; set; } = [];
    public ProductoModel ProductoNuevo { get; set; } = new();
}