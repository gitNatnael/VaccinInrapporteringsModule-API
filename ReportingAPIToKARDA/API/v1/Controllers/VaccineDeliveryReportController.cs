using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccinesDistributionReportAPI.API.v1.Models;
using VaccinesDistributionReportAPI.API.v1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VaccineDeliveryReportController : ControllerBase
    {
        private readonly IDeliveryRepository _IInleveransRepository;
        public VaccineDeliveryReportController(IDeliveryRepository inleveransRepository)
        {
            _IInleveransRepository = inleveransRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VaccineDeliveryReport>>> GetAllDeliveryReport()
        {
            return Ok(await _IInleveransRepository.GetAllDeliveryReport());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VaccineDeliveryReport>> GetDeliveryReportById(int id)
        {
            return Ok(await _IInleveransRepository.GetDeliveryReportById(id));
        }

        [HttpPost]
        public async Task<ActionResult<VaccineDeliveryReport>> AddDeliveryReport([FromBody] VaccineDeliveryReport report)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Invalid state...");
                return BadRequest(ModelState);
            }
            var newReport = await _IInleveransRepository.AddDeliveryReport(report);
            return CreatedAtAction(nameof(GetAllDeliveryReport), new { id = newReport.Id }, newReport);
        }


    }
}
