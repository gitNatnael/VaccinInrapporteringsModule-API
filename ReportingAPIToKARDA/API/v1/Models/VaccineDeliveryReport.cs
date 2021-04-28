using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Models
{
    public class VaccineDeliveryReport
    {
        public VaccineDeliveryReport()
        {

        }
        public int Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime ScheduledDeliveryDate { get; set; }
        public string VaccineSupplier { get; set; }
        public int  QuantityVial { get; set; }
        public string GLN { get; set; }
        public string HealthCareProvider { get; set; }

    }
}
