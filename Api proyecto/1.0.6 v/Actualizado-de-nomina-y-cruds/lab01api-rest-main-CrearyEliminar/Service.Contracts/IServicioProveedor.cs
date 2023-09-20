using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServicioProveedor
    {
        IEnumerable<ProveedorDto> GetAllProveedor(bool trackChanges);
        ProveedorDto GetProveedor(Guid proveedorId, bool trackChanges);
    }
}

