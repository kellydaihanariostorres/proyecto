using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class ClienteNotFoundException : NotFoundException
    {
        public ClienteNotFoundException(Guid ClienteId)
            : base($"El cliente con el id:{ClienteId} no existe en la base de datos.")
        {
        }
    }
}
