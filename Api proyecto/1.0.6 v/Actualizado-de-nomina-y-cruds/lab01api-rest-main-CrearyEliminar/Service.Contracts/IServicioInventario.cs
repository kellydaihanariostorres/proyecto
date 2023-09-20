using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServicioInventario
    {
        IEnumerable<InventarioDto> GetAllInventarios(bool trackChanges);
        InventarioDto GetInventario(Guid inventarioId, bool trackChanges);
    }
}
