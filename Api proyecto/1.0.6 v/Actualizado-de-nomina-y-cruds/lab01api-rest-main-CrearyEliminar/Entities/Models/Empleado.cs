using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Empleado
    {
        [Column("EmpleadoId")]
        public Guid EmpleadoId { get; set; }
        [Required(ErrorMessage = "Nombre del empleado es requerido")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteres es de 50")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Apellido del empleado es requerido")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteres es de 50")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "Documento del empleado es requerido")]
        [MaxLength(15, ErrorMessage = "Maximo de caracteres es de 15")]
        public string? Documento { get; set; }

        [Required(ErrorMessage = "Cargo del empleado es requerido")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteres es de 50")]
        public string? Cargo { get; set; }

        [Required(ErrorMessage = "Fecha de Inicio del empleado es requerido")]
       
        public string? FechaInicio { get; set; }


        [Required(ErrorMessage = "Fecha Final del empleado es requerido")]

        public string? FechaFin { get; set; }

        [Required(ErrorMessage = "Sueldo del empleado es requerido")]
        [MaxLength(1000, ErrorMessage = "Maximo de caracteres es de 1000")]
        public string? Sueldo { get; set; }

        [ForeignKey(nameof(Bodega))]
        public Guid BodegaId { get; set; }
        public Bodega? Bodega { get; set; }


    }
}
