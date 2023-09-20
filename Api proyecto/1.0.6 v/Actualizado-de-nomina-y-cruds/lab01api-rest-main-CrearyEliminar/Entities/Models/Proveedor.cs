using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Proveedor
    {
        [Column("ProveedorId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Se requiere un nombre para el proveedor.")]
        [MaxLength(30, ErrorMessage = "La longitud máxima del nombre es de 50 caracteres..")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El numero de documento es un campo obligatorio..")]
        [MaxLength(50, ErrorMessage = "La longitud máxima para el número de documento es de 10 caracteres.")]
        public int numDocumento { get; set; }
        [Required(ErrorMessage = "La edad es obligatoria.")]
        [MaxLength(99, ErrorMessage = "La longitud máxima para la edad es de 99.")]
        public int? Edad { get; set; }
        [Required(ErrorMessage = "La dirección es un campo obligatorio.")]
        [MaxLength(50, ErrorMessage = "La longitud máxima para la dirección es de 50 caracteres.")]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "El telefono es un campo obligatorio.")]
        [MaxLength(11, ErrorMessage = "La longitud máxima para el numero de telefono es de 10 caracteres.")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El correo es un campo obligatorio.")]
        [MaxLength(40, ErrorMessage = "La longitud máxima para el correo electronico es de 40 caracteres.")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El nombre de la entidad bancaria es obligatoria.")]
        [MaxLength(30, ErrorMessage = "La longitud máxima para el nombre de la entidad bancaria es de 40 caracteres.")]
        public string? NombreEntidadBancaria { get; set; }

        [Required(ErrorMessage = "El numero de cuenta bancaria es obligatoria.")]
        [MaxLength(30, ErrorMessage = "La longitud máxima para el nombre de la entidad bancaria es de 25 caracteres.")]
        public int? NumeroCuentaBancaria { get; set; }
        


        //Si necesito información de otra tabla
        //[ForeignKey(nameof(Company))]
        //public Guid CompanyId { get; set; }
        //public Company? Company { get; set; }

    }
}
