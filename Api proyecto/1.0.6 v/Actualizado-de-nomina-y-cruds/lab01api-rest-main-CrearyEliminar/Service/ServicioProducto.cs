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
    internal sealed class ServicioProducto : IServicioProducto
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ServicioProducto(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public IEnumerable<ProductoDto> GetAllProductos(bool trackChanges)
        {

            var productos = _repository.Producto.GetAllProductos(trackChanges);

            var productosDto = _mapper.Map<IEnumerable<ProductoDto>>(productos);
            return productosDto;

        }

        public ProductoDto GetProducto(Guid productoId, bool trackChanges)
        {
            var producto = _repository.Producto.GetProducto(productoId, trackChanges);
           
            var productoDto = _mapper.Map<ProductoDto>(producto);

            return productoDto;

        }
    }
}