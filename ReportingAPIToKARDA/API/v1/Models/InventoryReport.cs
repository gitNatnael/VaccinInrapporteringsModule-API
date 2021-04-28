using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Models
{
    public class InventoryReport
    {
        public int Id { get; set; }
        public DateTime InventoryUpdateDate { get; set; }
        public string VaccineSupplier { get; set; }
        public int QuantityVial { get; set; }
        public int QuantityDose { get; set; }
        public string HealthCareProvider { get; set; }
    }
}
