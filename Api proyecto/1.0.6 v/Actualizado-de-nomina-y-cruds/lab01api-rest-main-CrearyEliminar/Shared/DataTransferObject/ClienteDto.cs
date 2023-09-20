using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record ClienteDto(Guid Id, string Nombre, string Apellido, int Edad, string tipoDocumento, int numDocumento, string Correo);

}
