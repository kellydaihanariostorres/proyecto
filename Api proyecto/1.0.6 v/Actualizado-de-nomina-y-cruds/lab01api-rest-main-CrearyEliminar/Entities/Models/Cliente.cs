using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Cliente
    {
        [Column("ClienteId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Se requiere un nombre para el cliente.")]
        [MaxLength(30, ErrorMessage = "La longitud máxima del nombre es de 30 caracteres..")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Se requiere un apellido para el cliente.")]
        [MaxLength(30, ErrorMessage = "La longitud máxima del nombre es de 30 caracteres..")]
        public string? Apellido { get; set; }


        [Required(ErrorMessage = "La edad es obligatoria.")]
        [MaxLength(99, ErrorMessage = "La longitud máxima para la edad es de 99.")]
        public int? Edad { get; set; }

        [Required(ErrorMessage = "El numero de documento es un campo obligatorio..")]
        [MaxLength(50, ErrorMessage = "La longitud máxima para el número de documento es de 10 caracteres.")]
        public string tipoDocumento { get; set; }

        [Required(ErrorMessage = "El numero de documento es un campo obligatorio..")]
        [MaxLength(50, ErrorMessage = "La longitud máxima para el número de documento es de 10 caracteres.")]
        public int numDocumento { get; set; }

        [Required(ErrorMessage = "El correo electronico es un campo obligatorio..")]
        [MaxLength(50, ErrorMessage = "La longitud máxima para el número de documento es de 50 caracteres.")]
        public string Correo { get; set; }


        //Si necesito información de otra tabla
        //[ForeignKey(nameof(Company))]
        //public Guid CompanyId { get; set; }
        //public Company? Company { get; set; }

    }
}
