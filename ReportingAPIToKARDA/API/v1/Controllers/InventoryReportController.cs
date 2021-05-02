using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinesDistributionReportAPI.API.v1.Models;
using VaccinesDistributionReportAPI.API.v1.Repositories;

namespace VaccinesDistributionReportAPI.API.v1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class InventoryReportController : ControllerBase
    {
        private readonly IInventoryRepository _inventoryRepository;
        public InventoryReportController(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository= inventoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryReport>>> GetAllInventoryReport()
        {
            return Ok(await _inventoryRepository.GetAllInventoryReport());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryReport>> GetInventoryReportById(int id)
        {
            return Ok(await _inventoryRepository.GetInventoryReportById(id));
        }

        [HttpPost]
        public async Task<ActionResult<InventoryReport>> AddDeliveryReport([FromBody] InventoryReport report)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Invalid state...");
                return BadRequest(ModelState);
            }
            var newReport = await _inventoryRepository.AddInventoryReport(report);
            return CreatedAtAction(nameof(GetAllInventoryReport), new { id = newReport.Id }, newReport);
        }


    }
}
