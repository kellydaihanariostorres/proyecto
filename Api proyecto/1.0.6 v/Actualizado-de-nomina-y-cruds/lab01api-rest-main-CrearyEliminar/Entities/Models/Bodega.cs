using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    
    public class Bodega
    {
        [Column("BodegaId")]
        public Guid BodegaId { get; set; }

        [Required(ErrorMessage = "Nombre de la bodega es requerido para el campo.")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteres es de 50.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El estado es requerido para el campo.")]
        [MaxLength(20, ErrorMessage = "Maximo de caracteres es de 20.")]
        public string? Estado { get; set; }

        [Required(ErrorMessage = "La direccion es requerida para el campo.")]
        [MaxLength(30, ErrorMessage = "Maximo de caracteres es de 30.")]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "La Ciudad es requerida para el campo.")]
        [MaxLength(30, ErrorMessage = "Maximo de caracteres es de 30.")]
        public string? Ciudad { get; set; }

        public ICollection<Empleado>? Empleados { get; set; }
    }
}
