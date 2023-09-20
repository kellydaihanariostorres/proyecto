using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployees.Presentation.Controllers
{
    [ApiController]
    [Route("api/proveedores")]
    public class ProveedoresController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ProveedoresController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetProveedores()
        {
            //throw new Exception("Exception");
            var proveedores =
            _service.ServcioProveedor.GetAllProveedor(trackChanges: false);
            return Ok(proveedores);

        }

        [HttpGet("{id:guid}")]
        public IActionResult GetProveedor(Guid id)
        {
            var proveedor = _service.ServcioProveedor.GetProveedor(id, trackChanges: false);
            return Ok(proveedor);
        }
    }
}
