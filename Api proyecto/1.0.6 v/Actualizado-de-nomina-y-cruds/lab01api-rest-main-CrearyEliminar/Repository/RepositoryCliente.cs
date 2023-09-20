using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal sealed class RepositoryCliente : RepositoryBase<Cliente>, IClienteRepositorio
    {
        public RepositoryCliente(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public IEnumerable<Cliente> GetAllClientes(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(n => n.Nombre)
            .ToList();

        public Cliente GetCliente(Guid clienteId, bool trackChanges) =>
            FindByCondition(n => n.Id.Equals(clienteId), trackChanges)
            .SingleOrDefault();
        
    }
}
