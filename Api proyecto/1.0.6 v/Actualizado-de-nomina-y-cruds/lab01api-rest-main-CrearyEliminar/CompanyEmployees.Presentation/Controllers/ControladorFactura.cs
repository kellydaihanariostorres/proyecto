using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployees.Presentation.Controllers
{

    [ApiController]
    [Route("api/facturas")]
    public class ControladorFactura : ControllerBase
    {
        private readonly IServiceManager _service;

        public ControladorFactura(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetFacturas()
        {
            var facturas = _service.ServicioFactura.GetAllFacturas(trackChanges: false);
            return Ok(facturas);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetFactura(Guid id)
        {
            var factura = _service.ServicioFactura.GetFactura(id, trackChanges: false);
            return Ok(factura);
        }

        
    }
}
