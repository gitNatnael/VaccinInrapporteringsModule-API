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
    public class VaccineSupplierController : ControllerBase
    {
        private readonly IVaccineSupplierRepository  _IVaccinLeverantörerRepository;
        public VaccineSupplierController(IVaccineSupplierRepository IVaccinLeverantörerRepository)
        {
            _IVaccinLeverantörerRepository = IVaccinLeverantörerRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<VaccineSupplier>> GetAllVaccinationSupplier()
        {
            return await _IVaccinLeverantörerRepository.GetAllSuppliers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VaccineSupplier>> GetSupplierById(int id)
        {
            return await _IVaccinLeverantörerRepository.GetSupplierById(id);
        }

        [HttpPost]
        public async Task<ActionResult<VaccineSupplier>> AddSupplier([FromBody] VaccineSupplier report)
        {
            var newReport = await _IVaccinLeverantörerRepository.AddSupplier(report);
            return CreatedAtAction(nameof(GetAllVaccinationSupplier), new { id = newReport.Id }, newReport);
        }
    }
}
