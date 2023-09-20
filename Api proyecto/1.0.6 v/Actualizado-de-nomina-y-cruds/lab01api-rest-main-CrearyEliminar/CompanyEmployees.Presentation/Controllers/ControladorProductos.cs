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
    [Route("api/productos")]
    public class ControladorProductos : ControllerBase
    {
        private readonly IServiceManager _service;

        public ControladorProductos(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetAllProductos()
        {
            
            var productos = _service.ServicioProducto.GetAllProductos(trackChanges: false);
            return Ok(productos);


        }
        [HttpGet("{id:guid}")]
        public IActionResult GetProducto(Guid id)
        {
            var producto = _service.ServicioProducto.GetProducto(id, trackChanges: false);
            return Ok(producto);
        }
    }
}
