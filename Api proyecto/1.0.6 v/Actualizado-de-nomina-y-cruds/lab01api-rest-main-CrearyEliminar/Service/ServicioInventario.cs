using AutoMapper;
using Contracts;
using Entities.Exceptions;
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
    internal sealed class ServicioInventario : IServicioInventario
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ServicioInventario(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<InventarioDto> GetAllInventarios(bool trackChanges)
        {

            var inventarios = _repository.Inventario.GetAllInventarios(trackChanges);

            //var companiesDto = companies.Select(c => new CompanyDto(c.Id, c.Name ??"", string.Join(' ', c.Address, c.Country))).ToList();
            var inventariosDto = _mapper.Map<IEnumerable<InventarioDto>>(inventarios);
            return inventariosDto;

        }

        public InventarioDto GetInventario(Guid inventarioId, bool trackChanges)
        {
            var inventario = _repository.Inventario.GetInventario(inventarioId, trackChanges);
            //Check if the company is null
            if (inventario is null)
                throw new InventarioExcepcionNoEncontrada(inventarioId);

            var inventarioDto = _mapper.Map<InventarioDto>(inventario);

            return inventarioDto;
        }
    }
}
