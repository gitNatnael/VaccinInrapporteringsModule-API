using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinesDistributionReportAPI.API.v1.Models
{
    public class CapacityReport
    {
        [Required(ErrorMessage = "Id is required.")]
        public int Id { get; set; }
        public DateTime CapacitiyprognosisDate { get; set; }
       [Range(0,int.MaxValue, ErrorMessage = "Should be greater than zero")]
        public int CapacityDose { get; set; }
        [Required(ErrorMessage = "HealthCareProvider is required.")]
        public string HealthCareProvider { get; set; }
    }
}
