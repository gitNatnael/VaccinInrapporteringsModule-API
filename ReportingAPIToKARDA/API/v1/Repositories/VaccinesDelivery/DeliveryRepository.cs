
using VaccinesDistributionReportAPI.API.v1.Models;
using VaccinesDistributionReportAPI.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VaccinesDistributionReportAPI.API.v1.Repositories
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly ReportContext _reportContext;
        public DeliveryRepository(ReportContext reportContext)
        {
            _reportContext = reportContext;
        }
        public async Task<VaccineDeliveryReport> AddDeliveryReport(VaccineDeliveryReport report)
        {
            _reportContext.Delivery.Add(report);
            await _reportContext.SaveChangesAsync();
            return report;
        }

        public async Task<VaccineDeliveryReport> GetDeliveryReportById(int id)
        {
            return await _reportContext.Delivery.FindAsync(id);
        }

        public async Task<IEnumerable<VaccineDeliveryReport>> GetAllDeliveryReport()
        {
            return await _reportContext.Delivery.ToListAsync();
        }

        public async Task UpdateDeliveryReport(VaccineDeliveryReport report)
        {
            _reportContext.Entry(report).State = EntityState.Modified;
            await _reportContext.SaveChangesAsync();
        }
    }
}
