using VaccinesDistributionReportAPI.API.v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Repositories
{
   public interface IHealthCareProviderRepository
    {
        Task<IEnumerable<HealthCareProvider>> GetAllHealthCareProvider();
        Task<HealthCareProvider> GetHealthCareProviderById(int id);
        Task<HealthCareProvider> AddHealthCareProvider(HealthCareProvider report);

    }
}
