using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Inventario
    {
        [Column("InventarioId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Nombre del producto es requerido")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteres es de 50")]
        public string? NombreProducto { get; set; }

        [Required(ErrorMessage = "Id del producto es requerido")]
        [MaxLength(6, ErrorMessage = "Maximo de caracteres es de 6")]
        public int? IdProducto { get; set; }

        [Required(ErrorMessage = "Id de la factura es requerido")]
        [MaxLength(6, ErrorMessage = "Maximo de caracteres es de 6")]
        public int? IdFactura { get; set; }

        [Required(ErrorMessage = "Precio del producto es requerido")]
        [MaxLength(1000, ErrorMessage = "Maximo de caracteres es de 1000")]
        public string? PrecioProducto { get; set; }

        [Required(ErrorMessage = "Cantidad del producto es requerido")]
        [MaxLength(999, ErrorMessage = "Maximo de caracteres es de 999")]
        public int? CantidadProducto { get; set; }

        [Required(ErrorMessage = "Marca del producto es requerido")]
        [MaxLength(99, ErrorMessage = "Maximo de caracteres es de 99")]
        public string? MarcaProducto { get; set; }

        [Required(ErrorMessage = "Clasificacion del producto es requerido")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteres es de 50")]
        public string? ClasificacionProducto { get; set; }


    }
}

