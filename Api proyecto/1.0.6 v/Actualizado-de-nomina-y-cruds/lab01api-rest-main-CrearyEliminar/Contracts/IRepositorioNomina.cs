using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositorioNomina
    {
        IEnumerable<Nomina> GetAllNominas(bool trackChanges);
        Nomina GetNomina(Guid nominaId, bool trackChanges);
        

    }
}
