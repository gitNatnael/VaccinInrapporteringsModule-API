using Microsoft.EntityFrameworkCore;
using VaccinesDistributionReportAPI.API.v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.Data
{
    public class ReportContext: DbContext
    {

        public ReportContext(DbContextOptions<ReportContext> options) :base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<VaccineDeliveryReport> Delivery { get; set; }
        public DbSet<VaccineSupplier> Vaccinesuppliers { get; set; }
        public DbSet<HealthCareProvider> HealthCareProviders { get; set; }
        public DbSet<InventoryReport> InventoryReport { get; set; }
      
    }
}
