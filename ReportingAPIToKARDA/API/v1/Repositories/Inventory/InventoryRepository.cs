using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinesDistributionReportAPI.API.v1.Models;
using VaccinesDistributionReportAPI.Data;

namespace VaccinesDistributionReportAPI.API.v1.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly ReportContext _reportContext;
        public InventoryRepository(ReportContext reportContext)
        {
            _reportContext = reportContext;
        }
        public async Task<InventoryReport> AddInventoryReport(InventoryReport report)
        {
            _reportContext.InventoryReport.Add(report);
            await _reportContext.SaveChangesAsync();
            return report;
        }

        public async Task<IEnumerable<InventoryReport>> GetAllInventoryReport()
        {
            return await _reportContext.InventoryReport.ToListAsync();
        }

        public async Task<InventoryReport> GetInventoryReportById(int id)
        {
            return await _reportContext.InventoryReport.FindAsync(id);
        }

       
    }
}
