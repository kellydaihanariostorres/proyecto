using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Nomina
    {
        public Guid NominaId { get; set; }

        [Required(ErrorMessage = "La cuenta bancaria es obligatoria.")]
        public string CuentaBancaria { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El email no es válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Phone(ErrorMessage = "El teléfono no es válido.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La fecha de creación es obligatoria.")]
        public DateTime FechaCreacion { get; set; }
        

    }

}
