using VaccinesDistributionReportAPI.API.v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Repositories
{
   public interface IVaccineSupplierRepository
    {
        Task<IEnumerable<VaccineSupplier>> GetAllSuppliers();
        Task<VaccineSupplier> GetSupplierById(int id);
        Task<VaccineSupplier> AddSupplier(VaccineSupplier report);
    }
}
