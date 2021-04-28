using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Models
{
    public class VaccineConsumption
    {
        public int Id { get; set; }
        public DateTime ConsumptionReportDate { get; set; }
        public string VaccineSupplierCode { get; set; }
        public uint QuantityVial { get; set; }
        public string HealthCareProviderCode { get; set; }
    }
}
