using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Models
{
    public class InventoryReport
    {
        [Required(ErrorMessage = "Id is required.")]
        public int Id { get; set; }
        public DateTime InventoryUpdateDate { get; set; }
        [Required(ErrorMessage = "VaccineSupplier is required.")]
        public string VaccineSupplier { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Should be greater than zero")]
        public int QuantityVial { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Should be greater than zero")]
        public int QuantityDose { get; set; }
        [Required(ErrorMessage = "HealthCareProvider is required.")]
        public string HealthCareProvider { get; set; }
    }
}
