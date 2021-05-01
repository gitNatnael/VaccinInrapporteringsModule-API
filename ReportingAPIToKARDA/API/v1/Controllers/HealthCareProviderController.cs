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
    public class HealthCareProviderController : ControllerBase
    {
        private readonly IHealthCareProviderRepository _IHealthCareProviderRepository;
        public HealthCareProviderController(IHealthCareProviderRepository IHealthCareProviderRepository)
        {
            _IHealthCareProviderRepository = IHealthCareProviderRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HealthCareProvider>>> GetAllHealthCareProvider()
        {
            return Ok( await _IHealthCareProviderRepository.GetAllHealthCareProvider());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HealthCareProvider>> GetHealthCareProviderById(int id)
        {
            return Ok( await _IHealthCareProviderRepository.GetHealthCareProviderById(id));
        }

        [HttpPost]
        public async Task<ActionResult<HealthCareProvider>> AddHealthCareProvider([FromBody] HealthCareProvider report)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Invalid state...");
                return BadRequest(ModelState);
            }
            var newReport = await _IHealthCareProviderRepository.AddHealthCareProvider(report);
            return CreatedAtAction(nameof(GetAllHealthCareProvider), new { id = newReport.Id }, newReport);
        }
    }
}
