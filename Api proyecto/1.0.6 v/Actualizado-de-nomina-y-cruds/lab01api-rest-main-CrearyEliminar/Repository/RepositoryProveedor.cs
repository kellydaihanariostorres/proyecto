using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal sealed class RepositoryProveedor : RepositoryBase<Proveedor>, IProveedorRepositorio
    {
        public RepositoryProveedor(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public IEnumerable<Proveedor> GetAllProveedores(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(n => n.Nombre)
            .ToList();

        public Proveedor GetProveedor(Guid proveedorId, bool trackChanges) =>
            FindByCondition(n => n.Id.Equals(proveedorId), trackChanges)
            .SingleOrDefault();

    }
}
