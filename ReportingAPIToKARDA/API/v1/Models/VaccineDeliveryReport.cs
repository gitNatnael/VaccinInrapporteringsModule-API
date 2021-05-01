using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Models
{
    public class VaccineDeliveryReport
    {
        //public VaccineDeliveryReport()
        //{

        //}
        [Required(ErrorMessage = "Id is required.")]
        public int Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime ScheduledDeliveryDate { get; set; }
        [Required(ErrorMessage = "VaccineSupplier is required.")]
        public string VaccineSupplier { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Should be greater than zero")]
        public int  QuantityVial { get; set; }
        public string GLN { get; set; }
        [Required(ErrorMessage = "HealthCareProvider is required.")]
        public string HealthCareProvider { get; set; }

    }
}
