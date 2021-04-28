using VaccinesDistributionReportAPI.API.v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Repositories
{
    public interface IDeliveryRepository
    {
        Task<IEnumerable<VaccineDeliveryReport>> GetAllDeliveryReport();
        Task<VaccineDeliveryReport> GetDeliveryReportById(int id);
        Task<VaccineDeliveryReport> AddDeliveryReport(VaccineDeliveryReport report);
        Task UpdateDeliveryReport(VaccineDeliveryReport report);
        
    }
}
