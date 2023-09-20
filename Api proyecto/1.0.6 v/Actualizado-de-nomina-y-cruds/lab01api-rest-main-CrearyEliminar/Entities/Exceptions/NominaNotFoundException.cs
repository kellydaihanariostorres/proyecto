using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class NominaNotFoundException : NotFoundException
    {
        public NominaNotFoundException(Guid nominaId)
            : base($"la nomina id:{nominaId} no esxiste en la base de datos.")
        {
        }
    }
}
