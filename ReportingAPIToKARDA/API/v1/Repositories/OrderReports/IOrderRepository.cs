using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinesDistributionReportAPI.API.v1.Models;

namespace VaccinesDistributionReportAPI.API.v1.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderReport>> GetAllOrderReports();
        Task<OrderReport> GetOrderReportBy(int id);
        Task<OrderReport> AddOrderReport(OrderReport report);
        Task UpdateOrderReport(OrderReport report);
    }
}
