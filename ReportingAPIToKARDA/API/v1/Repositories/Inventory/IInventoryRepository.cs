using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinesDistributionReportAPI.API.v1.Models;

namespace VaccinesDistributionReportAPI.API.v1.Repositories.Inventory
{
   public interface IInventoryRepository
    {
        Task<IEnumerable<InventoryReport>> GetAllInventoryReport();
        Task<InventoryReport> GetInventoryReportById(int id);
        Task<InventoryReport> AddInventoryReport(InventoryReport report);
      
    }
}
