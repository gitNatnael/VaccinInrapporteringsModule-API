using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinesDistributionReportAPI.API.v1.Models;
using VaccinesDistributionReportAPI.Data;

namespace VaccinesDistributionReportAPI.API.v1.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ReportContext _reportContext;
        public OrderRepository(ReportContext reportContext)
        {
            _reportContext = reportContext;
        }
        public async Task<OrderReport> AddOrderReport(OrderReport report)
        {
            _reportContext.OrderReport.Add(report);
            await _reportContext.SaveChangesAsync();
            return report; ;
        }

        public async Task<IEnumerable<OrderReport>> GetAllOrderReports()
        {
            return await _reportContext.OrderReport.ToListAsync();
        }

        public async Task<OrderReport> GetOrderReportBy(int id)
        {
            return  await _reportContext.OrderReport.FindAsync(id);
        }

        public async Task UpdateOrderReport(OrderReport report)
        {
            _reportContext.Entry(report).State = EntityState.Modified;
            await _reportContext.SaveChangesAsync();
        }
    }
}
