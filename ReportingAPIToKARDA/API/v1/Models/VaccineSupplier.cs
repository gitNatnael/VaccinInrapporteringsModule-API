
using System.ComponentModel.DataAnnotations;

namespace VaccinesDistributionReportAPI.API.v1.Models
{
    public class VaccineSupplier
    {
        [Required(ErrorMessage = "Id is required.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "SupplierCode is required.")]
        public string SupplierCode { get; set; }
        [Required(ErrorMessage = "Supplier name is required.")]
        public string Name { get; set; }
    }
}
