using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServicioCliente
    {
        IEnumerable<ClienteDto> GetAllCliente(bool trackChanges);
        ClienteDto GetCliente(Guid clienteId, bool trackChanges);
    }
}
