using System.ComponentModel.DataAnnotations;

namespace CRUDWebApp.Models;

public class ProductoModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "La descripción es obligatoria")]
    public string Descripcion { get; set; } = string.Empty;

    [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
    public decimal Precio { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
    public int Stock { get; set; }

    public string Imagen { get; set; } = string.Empty;

    [Range(1, int.MaxValue, ErrorMessage = "Selecciona una categoría")]
    public int CategoriaId { get; set; }

    public CategoriaModel? Categoria { get; set; }
}