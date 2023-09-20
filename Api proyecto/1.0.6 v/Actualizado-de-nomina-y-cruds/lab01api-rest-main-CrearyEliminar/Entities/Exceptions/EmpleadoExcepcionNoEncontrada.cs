using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    
   public sealed class EmpleadoExcepcionNoEncontrada : NotFoundException
   {
        public EmpleadoExcepcionNoEncontrada(Guid EmpleadoId)
            : base($"El empleado con id:{EmpleadoId} no existe en la base de datos.")
        {
        }
   }
}
