using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Models
{
    public class OrderReport
    {
        [Required(ErrorMessage = "Id is required.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "OrderDate Id is required.")]
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "DeliveryDate is required.")]
        public DateTime DeliveryDate { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Should be greater than zero")]
        public int QuantityDos { get; set; }
        public string GLN { get; set; }
        [Required(ErrorMessage = "HealthCareProvider is required.")]
        public string HealthCareProvider { get; set; }
    }
}
