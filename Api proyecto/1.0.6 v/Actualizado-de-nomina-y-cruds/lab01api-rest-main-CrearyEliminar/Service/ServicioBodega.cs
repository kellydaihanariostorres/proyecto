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
    internal sealed class ServicioBodega : IServicioBodega
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
      
        public ServicioBodega(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<BodegaDto> GetAllBodegas(bool trackChanges)
        {
            
                var bodegas = _repository.Bodega.GetAllBodegas(trackChanges);

               
                var bodegasDto = _mapper.Map<IEnumerable<BodegaDto>>(bodegas);
                return bodegasDto;
            
        }

        public BodegaDto GetBodega(Guid id, bool trackChanges)
        {
            var bodega = _repository.Bodega.GetBodega(id, trackChanges);
          
            if(bodega is null)
            {
                throw new BodegaExcepcionNoEncontrada(id);
            }
                

            var bodegaDto = _mapper.Map<BodegaDto>(bodega);

            return bodegaDto;
        }

        public BodegaDto CrearBodega(CrearBodegaDto bodega)
        {
            var entidadbodega = _mapper.Map<Bodega>(bodega);

            _repository.Bodega.CrearBodega(entidadbodega);
            _repository.Save();

            var retornabodegas = _mapper.Map<BodegaDto>(entidadbodega);

            return retornabodegas;
        }

        public void EliminarBodega(Guid bodegaId, bool trackChanges)
        {
            var bodega = _repository.Bodega.GetBodega(bodegaId, trackChanges);
            if (bodega is null)
                throw new BodegaExcepcionNoEncontrada(bodegaId);
            _repository.Bodega.EliminarBodega(bodega);
            _repository.Save();
        }
        public void ActualizarBodega(Guid bodegaId, ActualizarBodegaDto actualizarBodegaDto, bool trackChanges)
        {
            var entidadbodega = _repository.Bodega.GetBodega(bodegaId, trackChanges);
            if (entidadbodega is null)
                throw new BodegaExcepcionNoEncontrada(bodegaId);
            _mapper.Map(actualizarBodegaDto, entidadbodega);
            _repository.Save(); 
        }
    }
}
