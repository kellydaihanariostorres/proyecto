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
    internal sealed class ServicioNomina : IServiceNomina
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ServicioNomina(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<NominaDto> GetAllNominas(bool trackChanges)
        {

            var nominas = _repository.Nomina.GetAllNominas(trackChanges);

            var nominasDto = _mapper.Map<IEnumerable<NominaDto>>(nominas);
            return nominasDto;



        }

        public NominaDto GetNomina(Guid nominaId, bool trackChanges)
        {
            var nomina = _repository.Nomina.GetNomina(nominaId, trackChanges);
          
            var nominaDto = _mapper.Map<NominaDto>(nomina);

            return nominaDto;

        }


    }
}
