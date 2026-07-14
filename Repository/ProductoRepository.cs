using CRUDWebApp.Models;

namespace CRUDWebApp.Repository;

public static class ProductoRepository
{
    private static int _nextId = 5;

    private static readonly Dictionary<int, CategoriaModel> Categorias = new()
    {
        [1] = new CategoriaModel { Id = 1, Nombre = "Electrónica" },
        [2] = new CategoriaModel { Id = 2, Nombre = "Accesorios" },
        [3] = new CategoriaModel { Id = 3, Nombre = "Hogar" }
    };

    private static readonly List<ProductoModel> _productos =
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
            Categoria = Categorias[1]
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
            Categoria = Categorias[2]
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
            Categoria = Categorias[3]
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
            Categoria = Categorias[1]
        }
    ];

    public static IReadOnlyList<ProductoModel> ObtenerTodos() => _productos;

    public static void Agregar(ProductoModel producto)
    {
        producto.Id = _nextId++;
        producto.Categoria = Categorias.GetValueOrDefault(producto.CategoriaId);

        if (string.IsNullOrWhiteSpace(producto.Imagen))
        {
            producto.Imagen = "https://placehold.co/400x250/6c757d/ffffff?text=Producto";
        }

        _productos.Add(producto);
    }
}
