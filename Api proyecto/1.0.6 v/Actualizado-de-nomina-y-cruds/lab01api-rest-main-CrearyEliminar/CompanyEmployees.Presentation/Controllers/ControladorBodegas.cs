using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObject;

namespace CompanyEmployees.Presentation.Controllers
{
    [ApiController]
    [Route("api/bodegas")]
    public class ControladorBodegas : ControllerBase
    {
        private readonly IServiceManager _service;

        public ControladorBodegas(IServiceManager service) => 
            _service = service;

        [HttpGet]
        public IActionResult GetallBodegas()
        {
           
            var bodegas =_service.ServicioBodega.GetAllBodegas(trackChanges: false);
            return Ok(bodegas);
            
      
        }
        [HttpGet("{id:guid}", Name="BodegaById")]
        public IActionResult GetBodega(Guid id)
        {
            var bodega = _service.ServicioBodega.GetBodega(id, trackChanges: false);
            return Ok(bodega);
        }
        [HttpPost]
        public IActionResult CrearBodega([FromBody] CrearBodegaDto bodega)
        {
            if (bodega is null)
                return BadRequest("El objeto CrearBodegaDto es nulo ");

            var crearbodega = _service.ServicioBodega.CrearBodega(bodega);

            return CreatedAtRoute("BodegaById", new { id = crearbodega.BodegaId }, crearbodega);
        }

        [HttpDelete("/api/bodegas/{bodegaId:guid}")]
        public IActionResult EliminarBodega(Guid bodegaId)
        {
            _service.ServicioBodega.EliminarBodega(bodegaId, trackChanges:
            false);
            return NoContent();
        }
        [HttpPut("/api/bodegas/{bodegaId:guid}")]
        public IActionResult ActualizarBodega(Guid bodegaId, [FromBody] ActualizarBodegaDto bodega)
        {
            if(bodega is null)
                return BadRequest("El objeto ActualizarBodegaDto es nulo");
            _service.ServicioBodega.ActualizarBodega(bodegaId, bodega, trackChanges: true);
            return NoContent() ;    

        }
    }
}
