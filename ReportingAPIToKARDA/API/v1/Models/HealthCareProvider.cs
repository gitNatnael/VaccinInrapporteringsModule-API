

using System.ComponentModel.DataAnnotations;

namespace VaccinesDistributionReportAPI.API.v1.Models
{
    public class HealthCareProvider
    {
        [Required(ErrorMessage = "Id is required.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "HealthCareProvider Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "HealthCareProvider code is required.")]
        public string ProviderCode { get; set; }
    }
}
