using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceFactura
    {
        IEnumerable<FacturaDto> GetAllFacturas(bool trackChanges);
        FacturaDto GetFactura(Guid facturaId, bool trackChanges);
        
    }
}
