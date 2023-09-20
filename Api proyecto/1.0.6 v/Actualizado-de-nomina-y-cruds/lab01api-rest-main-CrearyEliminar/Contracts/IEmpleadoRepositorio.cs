using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts;

public interface IEmpleadoRepositorio
{
    IEnumerable<Empleado> GetAllEmpleados(bool trackChanges);
    IEnumerable<Empleado> GetEmpleados(Guid bodegaId, bool trackChanges);

    Empleado GetEmpleado(Guid empleadoId, bool trackChanges);
    Empleado GetEmpleado(Guid bodegaId,Guid empleadoId, bool trackChanges);

    void CrearEmpleado(Empleado empleado);
    void EliminarEmpleado(Empleado empleado);

}
