using Microsoft.EntityFrameworkCore;
using VaccinesDistributionReportAPI.API.v1.Models;
using VaccinesDistributionReportAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Repositories
{
    public class VaccineSupplierRepository : IVaccineSupplierRepository
    {
        private readonly ReportContext _reportContext;
        public VaccineSupplierRepository(ReportContext reportContext)
        {
            _reportContext = reportContext;
        }
        public async Task<VaccineSupplier> AddSupplier(VaccineSupplier report)
        {
            _reportContext.Vaccinesuppliers.Add(report);
            await _reportContext.SaveChangesAsync();
            return report;
        }

        public async Task<VaccineSupplier> GetSupplierById(int id)
        {
            return await _reportContext.Vaccinesuppliers.FindAsync(id);
        }

        public async Task<IEnumerable<VaccineSupplier>> GetAllSuppliers()
        {
            return await _reportContext.Vaccinesuppliers.ToListAsync();
        }

      
    }
}
