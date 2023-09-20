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
    internal sealed class ServicioProveedor : IServicioProveedor
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ServicioProveedor(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<ProveedorDto> GetAllProveedor(bool trackChanges)
        {

            var proveedor = _repository.Proveedor.GetAllProveedores(trackChanges);

            //var companiesDto = companies.Select(c => new CompanyDto(c.Id, c.Name ??"", string.Join(' ', c.Address, c.Country))).ToList();
            var proveedoresDto = _mapper.Map<IEnumerable<ProveedorDto>>(proveedor);
            return proveedoresDto;

        }

        public ProveedorDto GetProveedor(Guid proveedorId, bool trackChanges)
        {
            var proveedor = _repository.Proveedor.GetProveedor(proveedorId, trackChanges);
            //Check if the company is null
            if (proveedor is null)
                throw new ProveedorNotFoundException(proveedorId);

            var proveedorDto = _mapper.Map<ProveedorDto>(proveedor);

            return proveedorDto;
        }
    }
}
