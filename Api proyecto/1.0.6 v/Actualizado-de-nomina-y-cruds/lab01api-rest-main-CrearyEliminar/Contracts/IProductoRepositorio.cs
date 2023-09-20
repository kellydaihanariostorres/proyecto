using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IProductoRepositorio
    {
        IEnumerable<Productos> GetAllProductos(bool trackChanges);
        Productos GetProducto(Guid productoId, bool trackChanges);
    }
}
