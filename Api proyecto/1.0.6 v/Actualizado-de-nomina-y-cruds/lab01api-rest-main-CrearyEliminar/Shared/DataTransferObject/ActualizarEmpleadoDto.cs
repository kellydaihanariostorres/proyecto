using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record ActualizarEmpleadoDto(string Nombre,string Apellido,string Documento, string Cargo, string FechaInicio, string FechaFin,string Sueldo, string BodegaId);
  
}
