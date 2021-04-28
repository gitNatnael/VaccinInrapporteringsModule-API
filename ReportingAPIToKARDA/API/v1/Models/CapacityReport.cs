using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Models
{
    public class CapacityReport
    {
        public int Id { get; set; }
        public DateTime CapacitiyprognosisDate { get; set; }
        public uint CapacityDose { get; set; }
        public string HealthCareProviderCode { get; set; }
    }
}
