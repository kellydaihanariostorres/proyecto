using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositorioFactura
    {
        IQueryable<Factura> GetAllFacturas(bool trackChanges);
        Factura GetFactura(Guid facturaId, bool trackChanges);
    }
}
