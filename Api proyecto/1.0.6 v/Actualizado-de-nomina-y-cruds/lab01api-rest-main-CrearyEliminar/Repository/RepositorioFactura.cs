using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositorioFactura : RepositoryBase<Factura>, IRepositorioFactura
    {
        public RepositorioFactura(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IQueryable<Factura> GetAllFacturas(bool trackChanges) =>
            FindAll(trackChanges);

        public Factura GetFactura(Guid facturaId, bool trackChanges) =>
            FindByCondition(f => f.Id == facturaId, trackChanges)
            .SingleOrDefault();
    }
}
