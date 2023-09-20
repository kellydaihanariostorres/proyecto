
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServicioBodega
    {
        IEnumerable<BodegaDto> GetAllBodegas(bool trackChanges);
        BodegaDto GetBodega(Guid bodegaId, bool trackChanges);

        BodegaDto CrearBodega(CrearBodegaDto bodega);

        void EliminarBodega(Guid bodegaId, bool trackChanges);
        void ActualizarBodega(Guid bodegaId, ActualizarBodegaDto actualizarBodegaDto, bool trackChanges);
    }
}
