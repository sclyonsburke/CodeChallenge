using CodeChallenge.Models;
using CodeChallenge.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace CodeChallenge.Controllers
{
    [ApiController]
    [Route("api/structure")]
    public class StructureController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IEmployeeService _employeeService;

        public StructureController(ILogger<StructureController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [HttpGet("{id}", Name = "getReportingStructureById")]
        public IActionResult GetReportingStructureById(String id)
        {
            _logger.LogDebug($"Received reporting structure get request for '{id}'");

            var employee = _employeeService.GetById(id);

            if (employee == null)
                return NotFound();

            var structure = new ReportingStructure(employee);

            return Ok(structure);
        }
    }
}
