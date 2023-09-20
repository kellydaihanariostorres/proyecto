using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceNomina 
    {
        IEnumerable<NominaDto> GetAllNominas(bool trackChanges);
        NominaDto GetNomina(Guid nominaId, bool trackChanges);
    }
}
