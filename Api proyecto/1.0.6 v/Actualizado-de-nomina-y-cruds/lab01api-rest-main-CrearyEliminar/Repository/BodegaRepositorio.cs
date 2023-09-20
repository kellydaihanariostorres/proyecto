using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;

internal sealed class BodegaRepositorio : RepositoryBase<Bodega>, IBodegaRepositorio
{
    public BodegaRepositorio(RepositoryContext repositoryContext) 
        : base(repositoryContext)
    {

    }

    public IEnumerable<Bodega> GetAllBodegas(bool trackChanges) =>
        FindAll(trackChanges)
        .OrderBy(n=>n.Nombre)
        .ToList();

    public Bodega GetBodega(Guid bodegaId, bool trackChanges) =>
        FindByCondition(c => c.BodegaId.Equals(bodegaId), trackChanges)
        .SingleOrDefault();

    public void CrearBodega(Bodega bodega) => Create(bodega);

    public void EliminarBodega(Bodega bodega) => Delete(bodega);
}
