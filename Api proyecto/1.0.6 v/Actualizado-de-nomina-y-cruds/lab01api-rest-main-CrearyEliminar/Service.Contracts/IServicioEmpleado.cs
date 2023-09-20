using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServicioEmpleado
    {
        IEnumerable<EmpleadoDto> GetAllEmpleados(bool trackChanges);
        IEnumerable<EmpleadoDto> GetEmpleados(Guid bodegaId, bool trackChanges);
        EmpleadoDto GetEmpleado(Guid empleadoId, bool trackChanges);
        EmpleadoDto GetEmpleado(Guid bodegaId, Guid empleadoId, bool trackChanges);

        EmpleadoDto CrearEmpleado(CrearEmpleadoDto empleado);
        void EliminarEmpleadoDeBodega(Guid empleadoId, bool trackChanges);
        void ActualizarEmpleado(Guid empleadoId, ActualizarEmpleadoDto actualizarEmpleadoDto, bool trackChanges);
    }
}
