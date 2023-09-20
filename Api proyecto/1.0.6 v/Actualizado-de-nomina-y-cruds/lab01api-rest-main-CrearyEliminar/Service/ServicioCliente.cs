using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class ServicioCliente : IServicioCliente
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ServicioCliente(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<ClienteDto> GetAllCliente(bool trackChanges)
        {
            
            var cliente = _repository.Cliente.GetAllClientes(trackChanges);

            //var companiesDto = companies.Select(c => new CompanyDto(c.Id, c.Name ??"", string.Join(' ', c.Address, c.Country))).ToList();
            var clientesDto = _mapper.Map<IEnumerable<ClienteDto>>(cliente);
            return clientesDto;

        }
        

        public ClienteDto GetCliente(Guid clienteId, bool trackChanges)
        {
            var cliente = _repository.Cliente.GetCliente(clienteId, trackChanges);
            //Check if the company is null
            if (cliente is null)
                throw new ClienteNotFoundException(clienteId);

            var clienteDto = _mapper.Map<ClienteDto>(cliente);
            return clienteDto; 
        }
    }
}
