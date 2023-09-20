using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record ProductoDto(Guid Id, string NombreProducto, string PrecioProducto, string MarcaProducto, string ClasificacionProducto);
}
