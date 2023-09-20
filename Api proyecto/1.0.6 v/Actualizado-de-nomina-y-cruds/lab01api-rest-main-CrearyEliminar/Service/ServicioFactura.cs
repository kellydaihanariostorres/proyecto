using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class ServicioFactura : IServiceFactura
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ServicioFactura(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<FacturaDto> GetAllFacturas(bool trackChanges)
        {
            var facturas = _repository.Factura.GetAllFacturas(trackChanges);
            var facturasDto = facturas.Select(f => _mapper.Map<FacturaDto>(f));
            return facturasDto;
        }

        public FacturaDto GetFactura(Guid facturaId, bool trackChanges)
        {
            var factura = _repository.Factura.GetFactura(facturaId, trackChanges);
            var facturaDto = _mapper.Map<FacturaDto>(factura);
            return facturaDto;
        }

        
    }
}
