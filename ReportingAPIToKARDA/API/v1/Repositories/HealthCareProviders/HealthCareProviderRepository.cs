using Microsoft.EntityFrameworkCore;
using VaccinesDistributionReportAPI.API.v1.Models;
using VaccinesDistributionReportAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Repositories
{
    public class HealthCareProviderRepository : IHealthCareProviderRepository
    {

        private readonly ReportContext _reportContext;
        public HealthCareProviderRepository(ReportContext reportContext)
        {
            _reportContext = reportContext;
        }
        public async Task<HealthCareProvider> AddHealthCareProvider(HealthCareProvider report)
        {
            _reportContext.HealthCareProviders.Add(report);
            await _reportContext.SaveChangesAsync();
            return report;
        }

        public async Task<HealthCareProvider> GetHealthCareProviderById(int id)
        {
            return await _reportContext.HealthCareProviders.FindAsync(id);
        }

        public async Task<IEnumerable<HealthCareProvider>> GetAllHealthCareProvider()
        {
            return await _reportContext.HealthCareProviders.ToListAsync();
        }

    }
}
