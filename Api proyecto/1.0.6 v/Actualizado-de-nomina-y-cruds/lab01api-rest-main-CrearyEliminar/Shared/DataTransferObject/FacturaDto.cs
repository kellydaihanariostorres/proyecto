using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record FacturaDto(Guid Id, DateTime FechaCompra, decimal IVACompra, decimal Subtotal, decimal Total);
}
