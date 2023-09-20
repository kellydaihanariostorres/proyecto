using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Productos
    {
        [Column("ProductoId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Nombre del Producto es requerido")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteres es de 50")]
        public string? NombreProducto { get; set; }

        [Required(ErrorMessage = "Precio del producto es requerido")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteres es de 50")]
        public string? PrecioProducto { get; set; }

        [Required(ErrorMessage = "Documento del empleado es requerido")]
        [MaxLength(15, ErrorMessage = "Maximo de caracteres es de 15")]
        public string? MarcaProducto { get; set; }

        [Required(ErrorMessage = "La clasificacion del producto es requerido")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteres es de 50")]
        public string? ClasificacionProducto { get; set; }
    }
}
