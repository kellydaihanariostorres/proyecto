using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record InventarioDto(Guid Id, string NombreProducto, int IdProducto, int IdFactura, string PrecioProducto, int CantidadProducto,string MarcaProducto, string ClasificacionProducto);

}
