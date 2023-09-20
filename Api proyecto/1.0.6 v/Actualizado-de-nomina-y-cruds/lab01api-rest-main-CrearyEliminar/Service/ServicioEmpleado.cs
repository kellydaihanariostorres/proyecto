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
    internal sealed class ServicioEmpleado : IServicioEmpleado
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ServicioEmpleado(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public IEnumerable<EmpleadoDto> GetAllEmpleados( bool trackChanges)
        {
           
                var empleados = _repository.Empleado.GetAllEmpleados(trackChanges);

                var employeesDto = _mapper.Map<IEnumerable<EmpleadoDto>>(empleados);
                return employeesDto;
            
        }


        public IEnumerable<EmpleadoDto> GetEmpleados(Guid bodegaId, bool trackChanges)
        {
            var bodega = _repository.Empleado.GetEmpleados(bodegaId, trackChanges);
            if (bodega is null)
                throw new CompanyNotFoundException(bodegaId);

          
         var employeesFromDb = _repository.Empleado.GetEmpleados(bodegaId,
         trackChanges);
                    var employeesDto = _mapper.Map<IEnumerable<EmpleadoDto>>(employeesFromDb);
                return employeesDto;
        }

        public EmpleadoDto GetEmpleado(Guid id, bool trackChanges)
        {
            var empleado = _repository.Empleado.GetEmpleado(id, trackChanges);

            if (empleado is null)
            {
                throw new EmpleadoExcepcionNoEncontrada(id);
            }


            var empleadoDto = _mapper.Map<EmpleadoDto>(empleado);

            return empleadoDto;
        }


        public EmpleadoDto CrearEmpleado(CrearEmpleadoDto empleado)
        {
            var entidadempleado = _mapper.Map<Empleado>(empleado);

            _repository.Empleado.CrearEmpleado(entidadempleado);
            _repository.Save();

            var retornaempleados = _mapper.Map<EmpleadoDto>(entidadempleado);

            return retornaempleados;
        }
        public EmpleadoDto GetEmpleado(Guid bodegaId, Guid empleadoId, bool trackChanges)
        {
            var bodega = _repository.Bodega.GetBodega(bodegaId, trackChanges);
            if (bodega is null)
                throw new BodegaExcepcionNoEncontrada(bodegaId);
            var empleadoDb = _repository.Empleado.GetEmpleado(bodegaId, empleadoId, trackChanges);
            if (empleadoDb is null)
                throw new EmpleadoExcepcionNoEncontrada(empleadoId);
            var empleado = _mapper.Map<EmpleadoDto>(empleadoDb);
            return empleado;
        }

        
        public void EliminarEmpleadoDeBodega(Guid empleadoId, bool trackChanges)
        {
            var empleadodebodega = _repository.Empleado.GetEmpleado(empleadoId,trackChanges);
            if (empleadodebodega is null)
                throw new EmpleadoExcepcionNoEncontrada(empleadoId);
            _repository.Empleado.EliminarEmpleado(empleadodebodega);
            _repository.Save();
        }
        public void ActualizarEmpleado(Guid empleadoId, ActualizarEmpleadoDto actualizarEmpleadoDto, bool trackChanges)
        {
            var entidadempleado = _repository.Empleado.GetEmpleado(empleadoId, trackChanges);
            if (entidadempleado is null)
                throw new BodegaExcepcionNoEncontrada(empleadoId);
            _mapper.Map(actualizarEmpleadoDto, entidadempleado);
            _repository.Save();
        }
    }
}
