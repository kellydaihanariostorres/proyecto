using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServicioProducto
    {
        IEnumerable<ProductoDto> GetAllProductos(bool trackChanges);
        ProductoDto GetProducto(Guid productoId, bool trackChanges);
    }
}
