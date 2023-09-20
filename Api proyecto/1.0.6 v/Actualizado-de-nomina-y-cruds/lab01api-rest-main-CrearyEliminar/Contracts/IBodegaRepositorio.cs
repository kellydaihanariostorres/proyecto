using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IBodegaRepositorio
    {
        IEnumerable<Bodega> GetAllBodegas(bool trackChanges);
        Bodega GetBodega(Guid bodegaId, bool trackChanges);
        void CrearBodega(Bodega bodega);
        void EliminarBodega(Bodega bodega);

    }
}
