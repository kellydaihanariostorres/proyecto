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
    [Route("api/nominas")]
    public class ControladorNomina : ControllerBase
    {
        private readonly IServiceManager _service;

        public ControladorNomina(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetAllNominas()
        {
            var nominas = _service.ServiceNomina.GetAllNominas(trackChanges: false);
            return Ok(nominas);
        }

        [HttpGet("/api/nominas/{id:guid}")]
        public IActionResult GetNomina(Guid id)
        {
            var nomina = _service.ServiceNomina.GetNomina(id, trackChanges: false);
            return Ok(nomina);
        }



    }
}
