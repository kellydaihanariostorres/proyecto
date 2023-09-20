using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal sealed class InventarioRepositorio : RepositoryBase<Inventario>, IInventarioRepositorio
    {
        public InventarioRepositorio(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public IEnumerable<Inventario> GetAllInventarios(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(n => n.NombreProducto)
            .ToList();

        public Inventario GetInventario(Guid inventarioId, bool trackChanges) =>
            FindByCondition(x => x.Id.Equals(inventarioId), trackChanges)
            .SingleOrDefault();

    }
}
