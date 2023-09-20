using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Factura
    {
        [Column("FacturaId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "La fecha de compra es obligatoria.")]
        public DateTime FechaCompra { get; set; }

        [Required(ErrorMessage = "El IVA de la compra es obligatorio.")]
        public decimal IVACompra { get; set; }

        [Required(ErrorMessage = "El subtotal es obligatorio.")]
        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "El total es obligatorio.")]
        public decimal Total { get; set; }
    }
}
