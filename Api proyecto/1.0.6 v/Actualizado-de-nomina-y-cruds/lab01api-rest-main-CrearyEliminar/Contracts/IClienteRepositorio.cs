using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IClienteRepositorio
    {
        IEnumerable<Cliente> GetAllClientes(bool trackChanges);
        Cliente GetCliente(Guid clienteId, bool trackChanges);

    }
}
