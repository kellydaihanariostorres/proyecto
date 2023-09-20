using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal sealed class ProductoRepositorio : RepositoryBase<Productos>, IProductoRepositorio
    {
        public ProductoRepositorio(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public IEnumerable<Productos> GetAllProductos(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(n => n.NombreProducto)
            .ToList();

        public Productos GetProducto(Guid productoId, bool trackChanges) =>
            FindByCondition(p => p.Id.Equals(productoId), trackChanges)
            .SingleOrDefault();
    }
}
