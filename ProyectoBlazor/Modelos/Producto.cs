using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Producto
{
    [Required(ErrorMessage = "El campo codigo es obligatorio")]
    public string Codigo { get; set; }
    [Required(ErrorMessage = "El campo descripcion es obligatorio")]
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Existencia { get; set; }
    public byte[] Imagen { get; set; }
}
