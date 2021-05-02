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
    public class OrderReportController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        public OrderReportController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderReport>>> GetAllOrderReports()
        {
            return Ok(await _orderRepository.GetAllOrderReports());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderReport>> GetOrderReportBy(int id)
        {
            return Ok(await _orderRepository.GetOrderReportBy(id));
        }
        [HttpPost]
        public async Task<ActionResult<OrderReport>> AddDeliveryReport([FromBody] OrderReport report)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Invalid state...");
                return BadRequest(ModelState);
            }
            var newReport = await _orderRepository.AddOrderReport(report);
            return CreatedAtAction(nameof(GetAllOrderReports), new { id = newReport.Id }, newReport);
        }

    }
}
